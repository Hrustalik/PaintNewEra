using System;
using System.Drawing;

namespace PaintNewEra.Figures
{
    [Serializable()]
    class Circle : Figure
    {
        public Point centerPoint;
        public int radius;
        public Color brushColor;
        

        public override void draw(Graphics g)
        {
            Brush brush = new SolidBrush(brushColor);
            g.FillEllipse(brush, centerPoint.X - radius, centerPoint.Y - radius,
                radius * 2, radius * 2);
            Pen pen = new Pen(lineColor, lineWidth);
            pen.DashStyle = lineType;
            g.DrawEllipse(pen, centerPoint.X - radius, centerPoint.Y - radius,
                radius * 2, radius * 2);
            drawAnchorPoints(g);
        }

        public override AnchorPoint[] getAllAnchorPoints()
        {
            return new AnchorPoint[]
            {
                new AnchorPoint(centerPoint, 0, this),
                new AnchorPoint(new Point(centerPoint.X, centerPoint.Y + radius), 1, this)
            };
        }

        public override void doOffsetForAnchorPoint(AnchorPoint anchor, Point offset)
        {
            if (anchor.index == 0)
            {
                centerPoint.X += offset.X;
                centerPoint.Y += offset.Y;
            }
            else if (anchor.index == 1)
            {
                radius += offset.Y;
                if (radius < 5)
                {
                    radius = 5;
                }
            }
        }

        public override bool isIn(Rectangle area)
        {
            var dots = new Point[] {
                new Point(centerPoint.X - radius, centerPoint.Y - radius),
                new Point(centerPoint.X + radius, centerPoint.Y + radius)
            };
            return isIn(area, dots);
        }

        public override object Clone()
        {
            return new Circle
            {
                lineColor = this.lineColor,
                lineType = this.lineType,
                lineWidth = this.lineWidth,
                centerPoint = this.centerPoint,
                radius = this.radius,
                brushColor = this.brushColor,
                selected = this.selected
            };
        }

        public override void doOffset(Point offset)
        {
            centerPoint.X = centerPoint.X + offset.X;
            centerPoint.Y = centerPoint.Y + offset.Y;
        }
    }
}
