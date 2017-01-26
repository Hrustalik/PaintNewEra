using PaintNewEra.CommandHistory;
using PaintNewEra.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace PaintNewEra
{
    [Serializable()]
    class SavedStatus
    {
        public List<Figure> figures;
        public History history;
        public Size canvasSize;
    }
}
