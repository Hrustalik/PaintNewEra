using PaintNewEra.Figures;
using System;
using System.Collections.Generic;

namespace PaintNewEra.CommandHistory
{
    [Serializable()]
    class History
    {
        private List<List<Figure>> statesHistory = new List<List<Figure>>();
        private int stateIndex = -1;

        public List<Figure> undo()
        {
            if (!hasUndo())
            {
                return null;
            }
            stateIndex--;
            return stateIndex == -1 ? new List<Figure>() : cloneState(statesHistory[stateIndex]);
        }

        public List<Figure> redo()
        {
            if (!hasRedo())
            {
                return null;
            }
            stateIndex++;
            return cloneState(statesHistory[stateIndex]);
        }

        public bool hasUndo()
        {
            return stateIndex != -1;
        }

        public bool hasRedo()
        {
            return stateIndex < statesHistory.Count - 1;
        }

        public void addNewState(List<Figure> state)
        {
            if (state == null)
            {
                return;
            }
            while (statesHistory.Count > stateIndex + 1)
            {
                statesHistory.RemoveAt(statesHistory.Count - 1);
            }
            var cloned = cloneState(state);
            statesHistory.Add(cloned);
            stateIndex++;
        }

        private List<Figure> cloneState(List<Figure> state)
        {
            List<Figure> res = new List<Figure>();
            foreach (var figure in state)
            {
                res.Add((Figure)figure.Clone());
            }
            return res;
        }
    }
}
