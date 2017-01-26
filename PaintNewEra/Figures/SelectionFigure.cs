using System.Drawing;

namespace PaintNewEra.Figures
{
    class SelectionFigure : Figure
    {
        public Point location;
        public Size size;
        public bool exists;
        public override void draw(Graphics g)
        {
            if (exists)
            {
                Pen pen = new Pen(lineColor, lineWidth);
                pen.DashStyle = lineType;
                Rectangle rect = new Rectangle(location, size);
                if (size.Width < 0)
                {
                    rect.X = location.X + size.Width;
                    rect.Width = -size.Width;
                }
                if (size.Height < 0)
                {
                    rect.Y = location.Y + size.Height;
                    rect.Height = -size.Height;
                }
                g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
            }
        }
    }
}
