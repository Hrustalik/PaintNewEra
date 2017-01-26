namespace PaintNewEra
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВBmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборИнструментаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повторитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radioBtnMovement = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn800x500 = new System.Windows.Forms.RadioButton();
            this.radioBtn600x300 = new System.Windows.Forms.RadioButton();
            this.radioBtn700x400 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLineType = new System.Windows.Forms.ComboBox();
            this.panelBrushColor = new System.Windows.Forms.Panel();
            this.buttonPickBrushColor = new System.Windows.Forms.Button();
            this.buttonPickLineColor = new System.Windows.Forms.Button();
            this.panelLineColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericLineWidth = new System.Windows.Forms.NumericUpDown();
            this.radioBtnLine = new System.Windows.Forms.RadioButton();
            this.radioBtnPolygon = new System.Windows.Forms.RadioButton();
            this.radioBtnPolyline = new System.Windows.Forms.RadioButton();
            this.radioBtnCircle = new System.Windows.Forms.RadioButton();
            this.radioBtnEllipse = new System.Windows.Forms.RadioButton();
            this.radioBtnCursor = new System.Windows.Forms.RadioButton();
            this.canvasPanel = new PaintNewEra.CanvasPanel();
            this.lineColorDialog = new System.Windows.Forms.ColorDialog();
            this.brushColorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.выборИнструментаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.открытьToolStripMenuItem1,
            this.сохранитьКакToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.экспортВBmpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.открытьToolStripMenuItem.Text = "Создать новый проект";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // экспортВBmpToolStripMenuItem
            // 
            this.экспортВBmpToolStripMenuItem.Name = "экспортВBmpToolStripMenuItem";
            this.экспортВBmpToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.экспортВBmpToolStripMenuItem.Text = "Экспорт в bmp";
            this.экспортВBmpToolStripMenuItem.Click += new System.EventHandler(this.экспортВBmpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // выборИнструментаToolStripMenuItem
            // 
            this.выборИнструментаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem,
            this.повторитьToolStripMenuItem,
            this.clearFormToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вставитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem});
            this.выборИнструментаToolStripMenuItem.Name = "выборИнструментаToolStripMenuItem";
            this.выборИнструментаToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.выборИнструментаToolStripMenuItem.Text = "Выбор инструмента";
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
            // 
            // повторитьToolStripMenuItem
            // 
            this.повторитьToolStripMenuItem.Name = "повторитьToolStripMenuItem";
            this.повторитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.повторитьToolStripMenuItem.Text = "Повторить";
            this.повторитьToolStripMenuItem.Click += new System.EventHandler(this.повторитьToolStripMenuItem_Click);
            // 
            // clearFormToolStripMenuItem
            // 
            this.clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            this.clearFormToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.clearFormToolStripMenuItem.Text = "Очистить форму";
            this.clearFormToolStripMenuItem.Click += new System.EventHandler(this.clearFormToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.вставитьToolStripMenuItem.Text = "Вырезать";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.вставитьToolStripMenuItem1.Text = "Вставить";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.вставитьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.radioBtnMovement);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxLineType);
            this.splitContainer1.Panel1.Controls.Add(this.panelBrushColor);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPickBrushColor);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPickLineColor);
            this.splitContainer1.Panel1.Controls.Add(this.panelLineColor);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.numericLineWidth);
            this.splitContainer1.Panel1.Controls.Add(this.radioBtnLine);
            this.splitContainer1.Panel1.Controls.Add(this.radioBtnPolygon);
            this.splitContainer1.Panel1.Controls.Add(this.radioBtnPolyline);
            this.splitContainer1.Panel1.Controls.Add(this.radioBtnCircle);
            this.splitContainer1.Panel1.Controls.Add(this.radioBtnEllipse);
            this.splitContainer1.Panel1.Controls.Add(this.radioBtnCursor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.canvasPanel);
            this.splitContainer1.Size = new System.Drawing.Size(864, 294);
            this.splitContainer1.SplitterDistance = 85;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // radioBtnMovement
            // 
            this.radioBtnMovement.AutoSize = true;
            this.radioBtnMovement.Location = new System.Drawing.Point(715, 16);
            this.radioBtnMovement.Name = "radioBtnMovement";
            this.radioBtnMovement.Size = new System.Drawing.Size(98, 17);
            this.radioBtnMovement.TabIndex = 17;
            this.radioBtnMovement.TabStop = true;
            this.radioBtnMovement.Text = "Перемещение";
            this.radioBtnMovement.UseVisualStyleBackColor = true;
            this.radioBtnMovement.CheckedChanged += new System.EventHandler(this.radioBtnMovement_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn800x500);
            this.groupBox1.Controls.Add(this.radioBtn600x300);
            this.groupBox1.Controls.Add(this.radioBtn700x400);
            this.groupBox1.Location = new System.Drawing.Point(597, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 79);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер канвы";
            // 
            // radioBtn800x500
            // 
            this.radioBtn800x500.AutoSize = true;
            this.radioBtn800x500.Checked = true;
            this.radioBtn800x500.Location = new System.Drawing.Point(2, 19);
            this.radioBtn800x500.Name = "radioBtn800x500";
            this.radioBtn800x500.Size = new System.Drawing.Size(66, 17);
            this.radioBtn800x500.TabIndex = 13;
            this.radioBtn800x500.TabStop = true;
            this.radioBtn800x500.Text = "800x500";
            this.radioBtn800x500.UseVisualStyleBackColor = true;
            this.radioBtn800x500.CheckedChanged += new System.EventHandler(this.radioBtn800x500_CheckedChanged);
            // 
            // radioBtn600x300
            // 
            this.radioBtn600x300.AutoSize = true;
            this.radioBtn600x300.Location = new System.Drawing.Point(2, 58);
            this.radioBtn600x300.Name = "radioBtn600x300";
            this.radioBtn600x300.Size = new System.Drawing.Size(66, 17);
            this.radioBtn600x300.TabIndex = 15;
            this.radioBtn600x300.Text = "600x300";
            this.radioBtn600x300.UseVisualStyleBackColor = true;
            this.radioBtn600x300.CheckedChanged += new System.EventHandler(this.radioBtn600x300_CheckedChanged);
            // 
            // radioBtn700x400
            // 
            this.radioBtn700x400.AutoSize = true;
            this.radioBtn700x400.Location = new System.Drawing.Point(2, 39);
            this.radioBtn700x400.Name = "radioBtn700x400";
            this.radioBtn700x400.Size = new System.Drawing.Size(66, 17);
            this.radioBtn700x400.TabIndex = 14;
            this.radioBtn700x400.Text = "700x400";
            this.radioBtn700x400.UseVisualStyleBackColor = true;
            this.radioBtn700x400.CheckedChanged += new System.EventHandler(this.radioBtn700x400_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тип линии:";
            // 
            // comboBoxLineType
            // 
            this.comboBoxLineType.FormattingEnabled = true;
            this.comboBoxLineType.Items.AddRange(new object[] {
            "Сплошная",
            "Тире",
            "Точка",
            "Тире-точка",
            "Тире-точка-точка"});
            this.comboBoxLineType.Location = new System.Drawing.Point(466, 7);
            this.comboBoxLineType.Name = "comboBoxLineType";
            this.comboBoxLineType.Size = new System.Drawing.Size(110, 21);
            this.comboBoxLineType.TabIndex = 11;
            this.comboBoxLineType.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineType_SelectedIndexChanged);
            // 
            // panelBrushColor
            // 
            this.panelBrushColor.BackColor = System.Drawing.Color.White;
            this.panelBrushColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBrushColor.Location = new System.Drawing.Point(460, 48);
            this.panelBrushColor.Name = "panelBrushColor";
            this.panelBrushColor.Size = new System.Drawing.Size(21, 18);
            this.panelBrushColor.TabIndex = 10;
            // 
            // buttonPickBrushColor
            // 
            this.buttonPickBrushColor.Location = new System.Drawing.Point(385, 42);
            this.buttonPickBrushColor.Name = "buttonPickBrushColor";
            this.buttonPickBrushColor.Size = new System.Drawing.Size(58, 36);
            this.buttonPickBrushColor.TabIndex = 9;
            this.buttonPickBrushColor.Text = "Цвет заливки";
            this.buttonPickBrushColor.UseVisualStyleBackColor = true;
            this.buttonPickBrushColor.Click += new System.EventHandler(this.buttonPickBrushColor_Click);
            // 
            // buttonPickLineColor
            // 
            this.buttonPickLineColor.Location = new System.Drawing.Point(258, 42);
            this.buttonPickLineColor.Name = "buttonPickLineColor";
            this.buttonPickLineColor.Size = new System.Drawing.Size(60, 38);
            this.buttonPickLineColor.TabIndex = 8;
            this.buttonPickLineColor.Text = "Цвет линии";
            this.buttonPickLineColor.UseVisualStyleBackColor = true;
            this.buttonPickLineColor.Click += new System.EventHandler(this.buttonPickLineColor_Click);
            // 
            // panelLineColor
            // 
            this.panelLineColor.BackColor = System.Drawing.Color.Black;
            this.panelLineColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLineColor.Location = new System.Drawing.Point(343, 48);
            this.panelLineColor.Name = "panelLineColor";
            this.panelLineColor.Size = new System.Drawing.Size(18, 18);
            this.panelLineColor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ширина линии:";
            // 
            // numericLineWidth
            // 
            this.numericLineWidth.Location = new System.Drawing.Point(343, 7);
            this.numericLineWidth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLineWidth.Name = "numericLineWidth";
            this.numericLineWidth.Size = new System.Drawing.Size(39, 20);
            this.numericLineWidth.TabIndex = 5;
            this.numericLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLineWidth.ValueChanged += new System.EventHandler(this.numericLineWidth_ValueChanged);
            // 
            // radioBtnLine
            // 
            this.radioBtnLine.AutoSize = true;
            this.radioBtnLine.Location = new System.Drawing.Point(128, 49);
            this.radioBtnLine.Name = "radioBtnLine";
            this.radioBtnLine.Size = new System.Drawing.Size(57, 17);
            this.radioBtnLine.TabIndex = 4;
            this.radioBtnLine.TabStop = true;
            this.radioBtnLine.Text = "Линия";
            this.radioBtnLine.UseVisualStyleBackColor = true;
            this.radioBtnLine.CheckedChanged += new System.EventHandler(this.radioBtnLine_CheckedChanged);
            // 
            // radioBtnPolygon
            // 
            this.radioBtnPolygon.AutoSize = true;
            this.radioBtnPolygon.Location = new System.Drawing.Point(128, 26);
            this.radioBtnPolygon.Name = "radioBtnPolygon";
            this.radioBtnPolygon.Size = new System.Drawing.Size(103, 17);
            this.radioBtnPolygon.TabIndex = 4;
            this.radioBtnPolygon.TabStop = true;
            this.radioBtnPolygon.Text = "Многоугольник";
            this.radioBtnPolygon.UseVisualStyleBackColor = true;
            this.radioBtnPolygon.CheckedChanged += new System.EventHandler(this.radioBtnPolygon_CheckedChanged);
            // 
            // radioBtnPolyline
            // 
            this.radioBtnPolyline.AutoSize = true;
            this.radioBtnPolyline.Location = new System.Drawing.Point(128, 3);
            this.radioBtnPolyline.Name = "radioBtnPolyline";
            this.radioBtnPolyline.Size = new System.Drawing.Size(81, 17);
            this.radioBtnPolyline.TabIndex = 3;
            this.radioBtnPolyline.TabStop = true;
            this.radioBtnPolyline.Text = "Полилиния";
            this.radioBtnPolyline.UseVisualStyleBackColor = true;
            this.radioBtnPolyline.CheckedChanged += new System.EventHandler(this.radioBtnPolyline_CheckedChanged);
            // 
            // radioBtnCircle
            // 
            this.radioBtnCircle.AutoSize = true;
            this.radioBtnCircle.Location = new System.Drawing.Point(12, 49);
            this.radioBtnCircle.Name = "radioBtnCircle";
            this.radioBtnCircle.Size = new System.Drawing.Size(48, 17);
            this.radioBtnCircle.TabIndex = 2;
            this.radioBtnCircle.TabStop = true;
            this.radioBtnCircle.Text = "Круг";
            this.radioBtnCircle.UseVisualStyleBackColor = true;
            this.radioBtnCircle.CheckedChanged += new System.EventHandler(this.radioBtnCircle_CheckedChanged);
            // 
            // radioBtnEllipse
            // 
            this.radioBtnEllipse.AutoSize = true;
            this.radioBtnEllipse.Location = new System.Drawing.Point(12, 26);
            this.radioBtnEllipse.Name = "radioBtnEllipse";
            this.radioBtnEllipse.Size = new System.Drawing.Size(62, 17);
            this.radioBtnEllipse.TabIndex = 1;
            this.radioBtnEllipse.TabStop = true;
            this.radioBtnEllipse.Text = "Эллипс";
            this.radioBtnEllipse.UseVisualStyleBackColor = true;
            this.radioBtnEllipse.CheckedChanged += new System.EventHandler(this.radioBtnEllipse_CheckedChanged);
            // 
            // radioBtnCursor
            // 
            this.radioBtnCursor.AutoSize = true;
            this.radioBtnCursor.Checked = true;
            this.radioBtnCursor.Location = new System.Drawing.Point(12, 3);
            this.radioBtnCursor.Name = "radioBtnCursor";
            this.radioBtnCursor.Size = new System.Drawing.Size(61, 17);
            this.radioBtnCursor.TabIndex = 0;
            this.radioBtnCursor.TabStop = true;
            this.radioBtnCursor.Text = "Курсор";
            this.radioBtnCursor.UseVisualStyleBackColor = true;
            this.radioBtnCursor.CheckedChanged += new System.EventHandler(this.radioBtnCursor_CheckedChanged);
            // 
            // canvasPanel
            // 
            this.canvasPanel.AutoSize = true;
            this.canvasPanel.BackColor = System.Drawing.Color.White;
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(800, 500);
            this.canvasPanel.TabIndex = 0;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPanel_Paint);
            this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseDown);
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseMove);
            this.canvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 318);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Инструмент для рисования";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выборИнструментаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private PaintNewEra.CanvasPanel canvasPanel;
        private System.Windows.Forms.RadioButton radioBtnPolygon;
        private System.Windows.Forms.RadioButton radioBtnPolyline;
        private System.Windows.Forms.RadioButton radioBtnCircle;
        private System.Windows.Forms.RadioButton radioBtnEllipse;
        private System.Windows.Forms.RadioButton radioBtnCursor;
        private System.Windows.Forms.RadioButton radioBtnLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericLineWidth;
        private System.Windows.Forms.Button buttonPickLineColor;
        private System.Windows.Forms.Panel panelLineColor;
        private System.Windows.Forms.ColorDialog lineColorDialog;
        private System.Windows.Forms.Button buttonPickBrushColor;
        private System.Windows.Forms.Panel panelBrushColor;
        private System.Windows.Forms.ColorDialog brushColorDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLineType;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повторитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFormToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioBtn600x300;
        private System.Windows.Forms.RadioButton radioBtn700x400;
        private System.Windows.Forms.RadioButton radioBtn800x500;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.RadioButton radioBtnMovement;
        private System.Windows.Forms.ToolStripMenuItem экспортВBmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
    }
}

