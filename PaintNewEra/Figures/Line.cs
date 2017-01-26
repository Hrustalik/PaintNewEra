using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintNewEra.Figures
{
    [Serializable()]
    class Line : Figure
    {
        public Point startPoint;
        public Point endPoint;

        public override void draw(Graphics g)
        {
            Pen pen = new Pen(lineColor, lineWidth);
            pen.DashStyle = lineType;
            g.DrawLine(pen, startPoint, endPoint);
            drawAnchorPoints(g);
        }

        public override AnchorPoint[] getAllAnchorPoints()
        {
            return new AnchorPoint[]
            {
                new AnchorPoint(startPoint, 0, this),
                new AnchorPoint(endPoint, 1, this)
            };
        }

        public override void doOffsetForAnchorPoint(AnchorPoint anchor, Point offset)
        {
            if (anchor.index == 0)
            {
                startPoint.X += offset.X;//startPoint.X = startPoint.X + offset.X;
                startPoint.Y += offset.Y;
            } else if (anchor.index == 1)
            {
                endPoint.X += offset.X;
                endPoint.Y += offset.Y;
            }
        }

        public override bool isIn(Rectangle area)
        {
            var dots = new Point[] {
                new Point(startPoint.X, startPoint.Y),
                new Point(endPoint.X, endPoint.Y)
            };
            return isIn(area, dots);
        }

        public override object Clone()
        {
            return new Line
            {
                lineColor = this.lineColor,
                lineType = this.lineType,
                lineWidth = this.lineWidth,
                startPoint = this.startPoint,
                endPoint = this.endPoint,
                selected = this.selected
            };
        }
        public override void doOffset(Point offset)
        {
            startPoint.Offset(offset);
            endPoint.Offset(offset);
        }
    }
}
