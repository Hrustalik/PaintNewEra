using PaintNewEra.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using PaintNewEra.CommandHistory;
using System.Drawing.Imaging;

namespace PaintNewEra
{
    public partial class MainForm : Form
    {
        private List<Figure> figures;
        private FigureType figureType;
        private Figure currentFigure;
        private int currentLineWidth;
        private Color currentLineColor;
        private Color currentBrushColor;
        private DashStyle currentLineType;
        private List<Figure> selectedFigures;
        private SelectionFigure selection;
        private List<Figure> clipboardFigures;
        private Point startMovement;
        private AnchorPoint movedAnchor;
        private History history;
        private SaverLoader saverLoader;

        public MainForm()
        {
            InitializeComponent();
            saverLoader = new SaverLoader();
            history = new History();
            resetEnabledForUndoRedo();
            selection = new SelectionFigure();
            selection.lineColor = Color.Red;
            selection.lineWidth = 1;
            selection.lineType = DashStyle.Solid;
            selectedFigures = new List<Figure>();
            currentLineWidth = 1;
            currentLineColor = Color.Black;
            currentBrushColor = Color.White;
            currentLineType = DashStyle.Solid;
            comboBoxLineType.SelectedIndex = 0;
            figureType = FigureType.Cursor;
            figures = new List<Figure>();
            clipboardFigures = new List<Figure>();
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            foreach (Figure figure in figures)
            {
                figure.draw(e.Graphics);
            }
            if (currentFigure != null)
            {
                currentFigure.draw(e.Graphics);
            }
            selection.draw(e.Graphics);
        }

        private void radioBtnEllipse_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioBtnEllipse.Checked)
            {
                figureType = FigureType.Ellipse;
            }
        }

        private void radioBtnCursor_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioBtnCursor.Checked)
            {
                figureType = FigureType.Cursor;
            }
        }

        private void radioBtnCircle_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioBtnCircle.Checked)
            {
                figureType = FigureType.Circle;
            }
        }

        private void radioBtnPolyline_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioBtnPolyline.Checked)
            {
                figureType = FigureType.Polyline;
            }
        }

        private void radioBtnPolygon_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioBtnPolygon.Checked)
            {
                figureType = FigureType.Polygon;
            }
        }

        private void radioBtnLine_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioBtnLine.Checked)
            {
                figureType = FigureType.Line;
            }
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (figureType == FigureType.Cursor)
            {
                if (currentFigure != null)
                {
                    figures.Add(currentFigure);
                    saveState();
                    currentFigure = null;
                }
                AnchorPoint anchor = null;
                if (selectedFigures != null)
                {
                    foreach (var selectedFigure in selectedFigures)
                    {
                        anchor = selectedFigure.getAnchorPointAroundCoord(e.Location);
                        if (anchor != null)
                        {
                            break;
                        }
                    }
                }
                this.movedAnchor = anchor;
                if (anchor != null)
                {
                    anchor.selected = true;
                    startMovement = e.Location;
                }
                else
                {
                    foreach (var figure in figures)
                    {
                        if (figure.selected)
                        {
                            figure.selected = false;
                        }
                    }
                    selectedFigures.Clear();
                    selection.location = e.Location;
                    selection.size = new Size(0, 0);
                    selection.exists = true;
                }
                canvasPanel.Invalidate();
            }
            if (figureType == FigureType.Line)
            {
                if (currentFigure != null && !(currentFigure is Line))
                {
                    figures.Add(currentFigure);
                    saveState();
                    currentFigure = null;
                }
                currentFigure = new Line();
                currentFigure.lineColor = currentLineColor;
                currentFigure.lineType = currentLineType;
                currentFigure.lineWidth = currentLineWidth;
                Line copyLine = (Line)currentFigure;
                copyLine.startPoint = e.Location;
                copyLine.endPoint = e.Location;
                canvasPanel.Invalidate();
            }
            if (figureType == FigureType.Circle)
            {
                if (currentFigure != null && !(currentFigure is Circle))
                {
                    figures.Add(currentFigure);
                    saveState();
                    currentFigure = null;
                }
                currentFigure = new Circle();
                currentFigure.lineColor = currentLineColor;
                currentFigure.lineType = currentLineType;
                currentFigure.lineWidth = currentLineWidth;
                Circle copyCircle = (Circle)currentFigure;
                copyCircle.brushColor = currentBrushColor;
                Point A = new Point(e.Location.X, e.Location.Y);
                copyCircle.centerPoint = A;
                copyCircle.radius = 0;
                canvasPanel.Invalidate();
            }
            if (figureType == FigureType.Polyline)
            {
                if (currentFigure != null && !(currentFigure is Polyline))
                {
                    figures.Add(currentFigure);
                    saveState();
                    currentFigure = null;
                }
                if (e.Button == MouseButtons.Left)
                {
                    if (currentFigure == null)
                    {
                        currentFigure = new Polyline();
                        currentFigure.lineColor = currentLineColor;
                        currentFigure.lineType = currentLineType;
                        currentFigure.lineWidth = currentLineWidth;
                        Polyline copyPolyline = (Polyline)currentFigure;
                        copyPolyline.points = new List<Point>();
                        copyPolyline.points.Add(e.Location);
                    }
                    else
                    {
                        Polyline copyPolyline = (Polyline)currentFigure;
                        copyPolyline.points.Add(e.Location);
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (currentFigure != null)
                    {
                        figures.Add(currentFigure);
                        saveState();
                        currentFigure = null;
                    }
                }
                canvasPanel.Invalidate();
            }
            if (figureType == FigureType.Polygon)
            {
                if (currentFigure != null && !(currentFigure is Polygon))
                {
                    figures.Add(currentFigure);
                    saveState();
                    currentFigure = null;
                }

                if (e.Button == MouseButtons.Left)
                {
                    if (currentFigure == null)
                    {
                        currentFigure = new Polygon();
                        currentFigure.lineColor = currentLineColor;
                        currentFigure.lineType = currentLineType;
                        currentFigure.lineWidth = currentLineWidth;
                        Polygon copyPolygon = (Polygon)currentFigure;
                        copyPolygon.brushColor = currentBrushColor;
                        copyPolygon.points = new List<Point>();
                        copyPolygon.points.Add(e.Location);
                    }
                    else
                    {
                        Polygon copyPolygon = (Polygon)currentFigure;
                        copyPolygon.points.Add(e.Location);
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (currentFigure != null)
                    {
                        figures.Add(currentFigure);
                        saveState();
                        currentFigure = null;
                    }
                }
                canvasPanel.Invalidate();
            }
            if (figureType == FigureType.Ellipse)
            {
                if (currentFigure != null && !(currentFigure is Ellipse))
                {
                    figures.Add(currentFigure);
                    saveState();
                    currentFigure = null;
                }
                currentFigure = new Ellipse();
                currentFigure.lineColor = currentLineColor;
                currentFigure.lineType = currentLineType;
                currentFigure.lineWidth = currentLineWidth;
                Ellipse copyEllipse = (Ellipse)currentFigure;
                copyEllipse.brushColor = currentBrushColor;
                copyEllipse.location = e.Location;
                copyEllipse.size = new Size(0, 0);
                canvasPanel.Invalidate();
            }
            if (figureType == FigureType.Movement)
            {
                if (currentFigure != null)
                {
                    figures.Add(currentFigure);
                    saveState();
                    currentFigure = null;
                }
                startMovement = e.Location;
            }

        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (figureType == FigureType.Line)
            {
                //Если зажата какая-либо из кнопок мыши
                if (e.Button != MouseButtons.None)
                {
                    Line copyLine = (Line)currentFigure;
                    copyLine.endPoint = e.Location;
                    canvasPanel.Invalidate();
                }
            }
            if (figureType == FigureType.Polyline)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Polyline copyPolyline = currentFigure as Polyline;
                    if (copyPolyline != null)
                    {
                        copyPolyline.points[copyPolyline.points.Count - 1] = e.Location;
                        canvasPanel.Invalidate();
                    }
                }
            }
            if (figureType == FigureType.Polygon)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Polygon copyPolygon = currentFigure as Polygon;
                    if (copyPolygon != null)
                    {
                        copyPolygon.points[copyPolygon.points.Count - 1] = e.Location;
                        canvasPanel.Invalidate();
                    }
                }
            }

            if (figureType == FigureType.Circle)
            {
                if (e.Button != MouseButtons.None)
                {
                    Circle copyCircle = (Circle)currentFigure;
                    Point A = copyCircle.centerPoint;
                    copyCircle.radius = (int)(Math.Sqrt((A.X - e.Location.X) * (A.X - e.Location.X)
                        + (A.Y - e.Location.Y) * (A.Y - e.Location.Y)));
                    canvasPanel.Invalidate();
                }
            }
            if (figureType == FigureType.Ellipse)
            {
                if (e.Button != MouseButtons.None)
                {
                    Ellipse copyEllipse = (Ellipse)currentFigure;
                    copyEllipse.size = new Size((e.Location.X - copyEllipse.location.X), (e.Location.Y - copyEllipse.location.Y));
                    canvasPanel.Invalidate();
                }
            }
            if (figureType == FigureType.Cursor)
            {
                if (e.Button != MouseButtons.None)
                {
                    if (movedAnchor != null)
                    {
                        var figure = movedAnchor.figure;
                        if (figure != null)
                        {
                            figure.doOffsetForAnchorPoint(movedAnchor,
                                new Point(e.Location.X - startMovement.X, e.Location.Y - startMovement.Y));
                            startMovement = e.Location;
                        }
                    }
                    else
                    {
                        selectedFigures.Clear();
                        selection.size = new Size((e.Location.X - selection.location.X), (e.Location.Y - selection.location.Y));
                        foreach (var figure in figures)
                        {
                            Rectangle rect = new Rectangle(selection.location, selection.size);
                            if (selection.location.X > e.Location.X)
                            {
                                rect.X = e.Location.X;
                                rect.Width = selection.location.X - e.Location.X;
                            }
                            if (selection.location.Y > e.Location.Y)
                            {
                                rect.Y = e.Location.Y;
                                rect.Height = selection.location.Y - e.Location.Y;
                            }
                            var area = new Rectangle(rect.Location, rect.Size);
                            if (figure.isIn(area))
                            {
                                figure.selected = figure.isIn(area);
                                selectedFigures.Add(figure);
                            }
                            else
                            {
                                figure.selected = false;
                            }
                        }
                    }
                    canvasPanel.Invalidate();
                }
            }
            if (figureType == FigureType.Movement)
            {
                if (e.Button != MouseButtons.None)
                {
                    foreach (Figure figure in selectedFigures)
                    {
                        figure.doOffset(new Point(e.Location.X - startMovement.X, e.Location.Y - startMovement.Y));
                    }
                    startMovement = e.Location;
                    canvasPanel.Invalidate();
                }
            }

        }

        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (movedAnchor != null)
            {
                movedAnchor = null;
                saveState();
            }
            if (figureType == FigureType.Movement)
            {
                saveState();
            }
            if (figureType == FigureType.Cursor)
            {
                selection.exists = false;
                canvasPanel.Invalidate();
            }
            if (figureType == FigureType.Line ||
                figureType == FigureType.Circle ||
                figureType == FigureType.Ellipse)
            {
                if (currentFigure != null)
                {
                    figures.Add(currentFigure);
                    saveState();
                    currentFigure = null;
                    canvasPanel.Invalidate();
                }
            }
        }

        private void numericLineWidth_ValueChanged(object sender, EventArgs e)
        {
            currentLineWidth = (int)numericLineWidth.Value;
        }

        private void buttonPickLineColor_Click(object sender, EventArgs e)
        {
            DialogResult res = lineColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                currentLineColor = lineColorDialog.Color;
                panelLineColor.BackColor = currentLineColor;
            }
        }

        private void buttonPickBrushColor_Click(object sender, EventArgs e)
        {
            DialogResult res = brushColorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                currentBrushColor = brushColorDialog.Color;
                panelBrushColor.BackColor = currentBrushColor;
            }
        }

        private void comboBoxLineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLineType.SelectedIndex == 0)
            {
                currentLineType = DashStyle.Solid;
            }
            if (comboBoxLineType.SelectedIndex == 1)
            {
                currentLineType = DashStyle.Dash;
            }
            if (comboBoxLineType.SelectedIndex == 2)
            {
                currentLineType = DashStyle.Dot;
            }
            if (comboBoxLineType.SelectedIndex == 3)
            {
                currentLineType = DashStyle.DashDot;
            }
            if (comboBoxLineType.SelectedIndex == 4)
            {
                currentLineType = DashStyle.DashDotDot;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить файл?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (!saverLoader.canSaveWithoutAs())
                {
                    saveAs();
                    return;
                }
                var status = new SavedStatus()
                {
                    figures = figures,
                    history = history,
                    canvasSize = canvasPanel.Size
                };
                saverLoader.save(status);
            }
            Application.Exit();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void saveAs()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Paint New Era files (*.pna)|*.pna";
            dialog.FilterIndex = 0;
            DialogResult dialRes = dialog.ShowDialog();
            if (dialRes != DialogResult.OK)
            {
                return;
            }
            var status = new SavedStatus()
            {
                figures = figures,
                history = history,
                canvasSize = canvasPanel.Size
            };
            saverLoader.saveAs(dialog.FileName, status);
        }

        private void clearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figures.Clear();
            canvasPanel.Invalidate();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для рисования. \nАвтор - Баранская Ксения, группа 586-M1.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioBtn800x500_CheckedChanged(object sender, EventArgs e)
        {
            canvasPanel.Size = new Size(800, 500);
        }

        private void radioBtn700x400_CheckedChanged(object sender, EventArgs e)
        {
            canvasPanel.Size = new Size(700, 400);
        }

        private void radioBtn600x300_CheckedChanged(object sender, EventArgs e)
        {
            canvasPanel.Size = new Size(600, 300);
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clipboardFigures.Clear();
            foreach (Figure figure in selectedFigures)
            {
                clipboardFigures.Add((Figure)figure.Clone());
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clipboardFigures.Clear();
            foreach (Figure figure in selectedFigures)
            {
                clipboardFigures.Add((Figure)figure.Clone());
                figures.Remove(figure);
            }
            selectedFigures.Clear();
            canvasPanel.Invalidate();
            saveState();
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Figure figure in clipboardFigures)
            {
                figures.Add((Figure)figure.Clone());
            }
            canvasPanel.Invalidate();
            saveState();
        }

        private void radioBtnMovement_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnMovement.Checked)
            {
                figureType = FigureType.Movement;
            }
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (history.hasUndo())
            {
                figures = history.undo();
                foreach (var figure in figures)
                {
                    figure.selected = false;
                }
                selectedFigures.Clear();
                resetEnabledForUndoRedo();
                canvasPanel.Invalidate();
            }
        }

        private void повторитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (history.hasRedo())
            {
                currentFigure = null;
                figures = history.redo();
                foreach (var figure in figures)
                {
                    figure.selected = false;
                }
                selectedFigures.Clear();
                resetEnabledForUndoRedo();
                canvasPanel.Invalidate();
            }
        }

        private void resetEnabledForUndoRedo()
        {
            отменитьToolStripMenuItem.Enabled = history.hasUndo();
            повторитьToolStripMenuItem.Enabled = history.hasRedo();
        }

        private void saveState()
        {
            history.addNewState(figures);
            resetEnabledForUndoRedo();
        }

        private void экспортВBmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Bitmap files (*.bmp)|*.bmp";
            dialog.FilterIndex = 0;
            DialogResult dialRes = dialog.ShowDialog();
            if (dialRes != DialogResult.OK)
            {
                return;
            }
            int width = canvasPanel.Width;
            int height = canvasPanel.Height;
            Bitmap bmp = new Bitmap(width, height);
            canvasPanel.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
            bmp.Save(dialog.FileName, ImageFormat.Bmp);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saverLoader.canSaveWithoutAs())
            {
                saveAs();
                return;
            }
            var status = new SavedStatus()
            {
                figures = figures,
                history = history,
                canvasSize = canvasPanel.Size
            };
            saverLoader.save(status);
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Paint New Era files (*.pna)|*.pna";
            dialog.FilterIndex = 0;
            DialogResult dialRes = dialog.ShowDialog();
            if (dialRes != DialogResult.OK)
            {
                return;
            }
            var status = saverLoader.load(dialog.FileName);
            if (status == null)
            {
                MessageBox.Show("Не удалось загрузить.");
                return;
            }
            currentFigure = null;
            canvasPanel.Size = status.canvasSize;
            int w = canvasPanel.Width;
            if (w == 800)
            {
                radioBtn800x500.Checked = true;
            }
            else if (w == 700)
            {
                radioBtn700x400.Checked = true;
            }
            else
            {
                radioBtn600x300.Checked = true;
            }
            figures = status.figures;
            history = status.history;
            selectedFigures.Clear();
            foreach (var figure in figures)
            {
                figure.selected = false;
            }
            resetEnabledForUndoRedo();
            canvasPanel.Invalidate();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить изменения в текущем файле?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (!saverLoader.canSaveWithoutAs())
                {
                    saveAs();
                    return;
                }
                var status = new SavedStatus()
                {
                    figures = figures,
                    history = history,
                    canvasSize = canvasPanel.Size
                };
                saverLoader.save(status);
            }
            figures.Clear();
            history = new History();
            canvasPanel.Invalidate();            
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clipboardFigures.Clear();
            foreach (Figure figure in selectedFigures)
            {
                figures.Remove(figure);
            }
            selectedFigures.Clear();
            canvasPanel.Invalidate();
            saveState();
        }
    }
}
