using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintNewEra.Figures
{
    [Serializable()]
    class Figure : ICloneable
    {
        public Color lineColor;
        public int lineWidth;
        public DashStyle lineType;
        public bool selected;

        protected void drawAnchorPoints(Graphics g)
        {
            if (selected)
            {
                var allAnchors = getAllAnchorPoints();
                if (allAnchors != null)
                {
                    foreach (var anchor in allAnchors)
                    {
                        anchor.draw(g);
                    }
                }
            }
        }

        public virtual void draw(Graphics g)
        {

        }

        public virtual bool isIn(Rectangle area)
        {
            return false;
        }

        protected bool isIn(Rectangle area, Point[] dots)
        {
            foreach (var dot in dots)
            {
                if (dot.X <= area.X || dot.Y <= area.Y
                    || dot.X >= area.Right || dot.Y >= area.Bottom)
                {
                    return false;
                }
            }
            return true;
        }

        public virtual object Clone()
        {
            return new Figure
            {
                lineColor = this.lineColor,
                lineWidth = this.lineWidth,
                lineType = this.lineType,
                selected = this.selected
            };
        }

        public virtual void doOffset(Point offset)
        {
            
        }

        public virtual void doOffsetForAnchorPoint(AnchorPoint anchor, Point offset)
        {

        }

        public AnchorPoint getAnchorPointAroundCoord(Point coord)
        {
            var anchors = getAllAnchorPoints();
            AnchorPoint importantAnchor = null;
            if (anchors != null)
            {
                foreach (var anchor in anchors)
                {
                    if (anchor.contains(coord))
                    {
                        importantAnchor = anchor;
                        break;
                    }
                }
            }
            return importantAnchor;
        }

        public virtual AnchorPoint[] getAllAnchorPoints()
        {
            return null;
        }
    }
}
