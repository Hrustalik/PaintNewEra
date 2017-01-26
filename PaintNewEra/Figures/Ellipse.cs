using System;
using System.Drawing;

namespace PaintNewEra.Figures
{
    [Serializable()]
    class Ellipse : Figure
    {
        public Point location;
        public Size size;
        public Color brushColor;

        public override void draw(Graphics g)
        {
            Brush brush = new SolidBrush(brushColor);
            g.FillEllipse(brush, location.X, location.Y, size.Width, size.Height);
            Pen pen = new Pen(lineColor, lineWidth);
            pen.DashStyle = lineType;
            g.DrawEllipse(pen, location.X, location.Y, size.Width, size.Height);
            drawAnchorPoints(g);
        }

        public override AnchorPoint[] getAllAnchorPoints()
        {
            return new AnchorPoint[]
            {
                new AnchorPoint(location, 0, this),
                new AnchorPoint(new Point(location.X + size.Width, location.Y + size.Height), 1, this)
            };
        }

        public override void doOffsetForAnchorPoint(AnchorPoint anchor, Point offset)
        {
            if (anchor.index == 0)
            {
                location.X += offset.X;
                location.Y += offset.Y;
            }
            else if (anchor.index == 1)
            {
                size.Width += offset.X;
                size.Height += offset.Y;
            }
        }

        public override bool isIn(Rectangle area)
        {
            var dots = new Point[]
            {
                location,
                new Point(location.X + size.Width, location.Y + size.Height)
            };
            return isIn(area, dots);
        }

        public override object Clone()
        {
            return new Ellipse
            {
                lineColor = this.lineColor,
                lineType = this.lineType,
                lineWidth = this.lineWidth,
                location = this.location,
                size = this.size,
                brushColor = this.brushColor,
                selected = this.selected
            };
        }

        public override void doOffset(Point offset)
        {
            location.Offset(offset);
        }
    }
}
