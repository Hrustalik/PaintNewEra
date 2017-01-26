using System.Drawing;

namespace PaintNewEra.Figures
{
    class AnchorPoint : Figure
    {
        public Point centerPoint;
        public int side;//Сторона квадрата
        public Figure figure;
        public int index;//Индекс для определения того, на что именно указывает данная опорная точка

        public AnchorPoint(Point centerPoint, int index, Figure figure)
        {
            this.centerPoint = centerPoint;
            this.side = 10;
            this.index = index;
            this.figure = figure;
        }

        public bool contains(Point coord)
        {
            return coord.X > centerPoint.X - side / 2
                && coord.X < centerPoint.X + side / 2
                && coord.Y > centerPoint.Y - side / 2
                && coord.Y < centerPoint.Y + side / 2;
        }

        public override void draw(Graphics g)
        {
            Color lineCol;
            if (selected)
            {
                lineCol = Color.Red;
            } else
            {
                lineCol = Color.Blue;
            }
            Pen pen = new Pen(lineCol, lineWidth);
            pen.DashStyle = lineType;
            g.DrawRectangle(pen, centerPoint.X - side / 2, centerPoint.Y - side / 2, side, side);
        }

        public override bool isIn(Rectangle area)
        {
            var dots = new Point[]
            {
                new Point(centerPoint.X - side / 2, centerPoint.Y - side / 2),
                new Point(centerPoint.X + side / 2, centerPoint.Y - side / 2),
                new Point(centerPoint.X + side / 2, centerPoint.Y + side / 2),
                new Point(centerPoint.X - side / 2, centerPoint.Y + side / 2)
            };
            return isIn(area, dots);
        }

        public override object Clone()
        {
            return new AnchorPoint(this.centerPoint, this.index, this.figure)
            {
                lineColor = this.lineColor,
                lineType = this.lineType,
                lineWidth = this.lineWidth,
                side = this.side,
                selected = this.selected
            };
        }
    }
}
