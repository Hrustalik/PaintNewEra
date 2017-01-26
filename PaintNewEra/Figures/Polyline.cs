using System;
using System.Collections.Generic;
using System.Drawing;

namespace PaintNewEra.Figures
{
    [Serializable()]
    class Polyline : Figure
    {
        public List<Point> points;

        public override void draw(Graphics g)
        {
            Pen pen = new Pen(lineColor, lineWidth);
            pen.DashStyle = lineType;
            if (points.Count > 1)
            {
                g.DrawLines(pen, points.ToArray());
                drawAnchorPoints(g);
            }
        }

        public override AnchorPoint[] getAllAnchorPoints()
        {
            var anchors = new AnchorPoint[points.Count];
            for (int i = 0; i < anchors.Length; i++)
            {
                anchors[i] = new AnchorPoint(points[i], i, this);
            }
            return anchors;
        }

        public override void doOffsetForAnchorPoint(AnchorPoint anchor, Point offset)
        {
            if (anchor.index >= 0 && anchor.index < points.Count)
            {
                points[anchor.index] = new Point(points[anchor.index].X + offset.X,
                    points[anchor.index].Y + offset.Y);
            }
        }

        public override bool isIn(Rectangle area)
        {
            return isIn(area, points.ToArray());
        }

        public override object Clone()
        {
            List<Point> resPoints = new List<Point>();
            foreach (Point point in points)
            {
                resPoints.Add(point);
            }
            return new Polyline
            {
                lineColor = this.lineColor,
                lineType = this.lineType,
                lineWidth = this.lineWidth,
                points = resPoints,
                selected = this.selected
            };
        }

        public override void doOffset(Point offset)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X + offset.X, points[i].Y + offset.Y);
            }
        }
    }
}
