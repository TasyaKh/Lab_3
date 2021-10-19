
namespace Lab_3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxColor1 = new System.Windows.Forms.TextBox();
            this.textBoxSaturation1 = new System.Windows.Forms.TextBox();
            this.textBoxBright1 = new System.Windows.Forms.TextBox();
            this.comboBoxDates1 = new System.Windows.Forms.ComboBox();
            this.comboBoxDates2 = new System.Windows.Forms.ComboBox();
            this.comboBoxDates3 = new System.Windows.Forms.ComboBox();
            this.comboBoxSymbol1 = new System.Windows.Forms.ComboBox();
            this.textBoxColor2 = new System.Windows.Forms.TextBox();
            this.comboBoxSymbol2 = new System.Windows.Forms.ComboBox();
            this.textBoxSaturation2 = new System.Windows.Forms.TextBox();
            this.textBoxBright2 = new System.Windows.Forms.TextBox();
            this.comboBoxSymbol3 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Question = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxHSV = new System.Windows.Forms.GroupBox();
            this.groupBoxRGB = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.groupBoxConvert = new System.Windows.Forms.GroupBox();
            this.labelRGB = new System.Windows.Forms.Label();
            this.labelHSV = new System.Windows.Forms.Label();
            this.pictureBoxReplacerRGB_HSV = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxReplacerHSBtoRGB = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxHSV.SuspendLayout();
            this.groupBoxRGB.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            this.groupBoxConvert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReplacerRGB_HSV)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReplacerHSBtoRGB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цвет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Насыщенность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Яркость";
            // 
            // textBoxColor1
            // 
            this.textBoxColor1.Location = new System.Drawing.Point(123, 32);
            this.textBoxColor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxColor1.Name = "textBoxColor1";
            this.textBoxColor1.Size = new System.Drawing.Size(52, 22);
            this.textBoxColor1.TabIndex = 4;
            this.textBoxColor1.Tag = "1";
            this.textBoxColor1.TextChanged += new System.EventHandler(this.textBoxColor1_TextChanged);
            this.textBoxColor1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxColor1_KeyDown);
            this.textBoxColor1.Leave += new System.EventHandler(this.textBoxColor1_Leave);
            // 
            // textBoxSaturation1
            // 
            this.textBoxSaturation1.Location = new System.Drawing.Point(123, 27);
            this.textBoxSaturation1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSaturation1.Name = "textBoxSaturation1";
            this.textBoxSaturation1.Size = new System.Drawing.Size(49, 22);
            this.textBoxSaturation1.TabIndex = 5;
            this.textBoxSaturation1.Tag = "3";
            this.textBoxSaturation1.TextChanged += new System.EventHandler(this.textBoxSaturation1_TextChanged);
            this.textBoxSaturation1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSaturation1_KeyDown);
            this.textBoxSaturation1.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxBright1
            // 
            this.textBoxBright1.Location = new System.Drawing.Point(124, 31);
            this.textBoxBright1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBright1.Name = "textBoxBright1";
            this.textBoxBright1.Size = new System.Drawing.Size(49, 22);
            this.textBoxBright1.TabIndex = 6;
            this.textBoxBright1.Tag = "5";
            this.textBoxBright1.TextChanged += new System.EventHandler(this.textBoxBright1_TextChanged);
            this.textBoxBright1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBright1_KeyDown);
            this.textBoxBright1.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // comboBoxDates1
            // 
            this.comboBoxDates1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxDates1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDates1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDates1.FormattingEnabled = true;
            this.comboBoxDates1.Items.AddRange(new object[] {
            "degr.",
            "%",
            "pt."});
            this.comboBoxDates1.Location = new System.Drawing.Point(179, 30);
            this.comboBoxDates1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDates1.Name = "comboBoxDates1";
            this.comboBoxDates1.Size = new System.Drawing.Size(73, 24);
            this.comboBoxDates1.TabIndex = 8;
            this.comboBoxDates1.SelectedIndexChanged += new System.EventHandler(this.comboBoxDates1_SelectedIndexChanged);
            // 
            // comboBoxDates2
            // 
            this.comboBoxDates2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxDates2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDates2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDates2.FormattingEnabled = true;
            this.comboBoxDates2.Items.AddRange(new object[] {
            "%",
            "pt."});
            this.comboBoxDates2.Location = new System.Drawing.Point(179, 25);
            this.comboBoxDates2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDates2.Name = "comboBoxDates2";
            this.comboBoxDates2.Size = new System.Drawing.Size(73, 24);
            this.comboBoxDates2.TabIndex = 9;
            this.comboBoxDates2.SelectedIndexChanged += new System.EventHandler(this.comboBoxDates2_SelectedIndexChanged);
            // 
            // comboBoxDates3
            // 
            this.comboBoxDates3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxDates3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDates3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDates3.FormattingEnabled = true;
            this.comboBoxDates3.Items.AddRange(new object[] {
            "%",
            "pt."});
            this.comboBoxDates3.Location = new System.Drawing.Point(180, 30);
            this.comboBoxDates3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDates3.Name = "comboBoxDates3";
            this.comboBoxDates3.Size = new System.Drawing.Size(73, 24);
            this.comboBoxDates3.TabIndex = 10;
            this.comboBoxDates3.SelectedIndexChanged += new System.EventHandler(this.comboBoxDates3_SelectedIndexChanged);
            // 
            // comboBoxSymbol1
            // 
            this.comboBoxSymbol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxSymbol1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSymbol1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSymbol1.FormattingEnabled = true;
            this.comboBoxSymbol1.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBoxSymbol1.Location = new System.Drawing.Point(64, 69);
            this.comboBoxSymbol1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSymbol1.Name = "comboBoxSymbol1";
            this.comboBoxSymbol1.Size = new System.Drawing.Size(49, 24);
            this.comboBoxSymbol1.TabIndex = 11;
            this.comboBoxSymbol1.Tag = "1";
            this.comboBoxSymbol1.SelectedIndexChanged += new System.EventHandler(this.comboBoxSymbol1_SelectedIndexChanged);
            // 
            // textBoxColor2
            // 
            this.textBoxColor2.Location = new System.Drawing.Point(123, 69);
            this.textBoxColor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxColor2.Name = "textBoxColor2";
            this.textBoxColor2.Size = new System.Drawing.Size(52, 22);
            this.textBoxColor2.TabIndex = 12;
            this.textBoxColor2.Tag = "2";
            this.textBoxColor2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxColor2_KeyDown);
            this.textBoxColor2.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // comboBoxSymbol2
            // 
            this.comboBoxSymbol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxSymbol2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSymbol2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSymbol2.FormattingEnabled = true;
            this.comboBoxSymbol2.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBoxSymbol2.Location = new System.Drawing.Point(68, 44);
            this.comboBoxSymbol2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSymbol2.Name = "comboBoxSymbol2";
            this.comboBoxSymbol2.Size = new System.Drawing.Size(49, 24);
            this.comboBoxSymbol2.TabIndex = 13;
            this.comboBoxSymbol2.Tag = "2";
            this.comboBoxSymbol2.SelectedIndexChanged += new System.EventHandler(this.comboBoxSymbol2And3_SelectedIndexChanged);
            // 
            // textBoxSaturation2
            // 
            this.textBoxSaturation2.Location = new System.Drawing.Point(123, 66);
            this.textBoxSaturation2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSaturation2.Name = "textBoxSaturation2";
            this.textBoxSaturation2.Size = new System.Drawing.Size(52, 22);
            this.textBoxSaturation2.TabIndex = 14;
            this.textBoxSaturation2.Tag = "4";
            this.textBoxSaturation2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSaturation2_KeyDown);
            this.textBoxSaturation2.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxBright2
            // 
            this.textBoxBright2.Location = new System.Drawing.Point(123, 70);
            this.textBoxBright2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBright2.Name = "textBoxBright2";
            this.textBoxBright2.Size = new System.Drawing.Size(52, 22);
            this.textBoxBright2.TabIndex = 16;
            this.textBoxBright2.Tag = "6";
            this.textBoxBright2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBright2_KeyDown);
            this.textBoxBright2.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // comboBoxSymbol3
            // 
            this.comboBoxSymbol3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxSymbol3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSymbol3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSymbol3.FormattingEnabled = true;
            this.comboBoxSymbol3.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBoxSymbol3.Location = new System.Drawing.Point(69, 50);
            this.comboBoxSymbol3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSymbol3.Name = "comboBoxSymbol3";
            this.comboBoxSymbol3.Size = new System.Drawing.Size(49, 24);
            this.comboBoxSymbol3.TabIndex = 15;
            this.comboBoxSymbol3.Tag = "3";
            this.comboBoxSymbol3.SelectedIndexChanged += new System.EventHandler(this.comboBoxSymbol2And3_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Question);
            this.panel1.Controls.Add(this.comboBoxDates1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxColor1);
            this.panel1.Controls.Add(this.comboBoxColor);
            this.panel1.Controls.Add(this.comboBoxSymbol1);
            this.panel1.Controls.Add(this.textBoxColor2);
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(8, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 107);
            this.panel1.TabIndex = 17;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.ForeColor = System.Drawing.SystemColors.Window;
            this.Question.Location = new System.Drawing.Point(-3, 30);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(19, 20);
            this.Question.TabIndex = 15;
            this.Question.Text = "?";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.comboBoxColor.Location = new System.Drawing.Point(19, 30);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(95, 24);
            this.comboBoxColor.TabIndex = 7;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBoxDates2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxSaturation1);
            this.panel2.Controls.Add(this.comboBoxSymbol2);
            this.panel2.Controls.Add(this.textBoxSaturation2);
            this.panel2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Location = new System.Drawing.Point(8, 132);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 107);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBoxDates3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxBright1);
            this.panel3.Controls.Add(this.textBoxBright2);
            this.panel3.Controls.Add(this.comboBoxSymbol3);
            this.panel3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Location = new System.Drawing.Point(8, 243);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 107);
            this.panel3.TabIndex = 19;
            // 
            // groupBoxHSV
            // 
            this.groupBoxHSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.groupBoxHSV.Controls.Add(this.panel3);
            this.groupBoxHSV.Controls.Add(this.panel1);
            this.groupBoxHSV.Controls.Add(this.panel2);
            this.groupBoxHSV.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxHSV.Location = new System.Drawing.Point(266, 13);
            this.groupBoxHSV.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxHSV.Name = "groupBoxHSV";
            this.groupBoxHSV.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxHSV.Size = new System.Drawing.Size(288, 359);
            this.groupBoxHSV.TabIndex = 23;
            this.groupBoxHSV.TabStop = false;
            this.groupBoxHSV.Text = "HSV";
            // 
            // groupBoxRGB
            // 
            this.groupBoxRGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.groupBoxRGB.Controls.Add(this.panel5);
            this.groupBoxRGB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxRGB.Location = new System.Drawing.Point(266, 380);
            this.groupBoxRGB.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRGB.Name = "groupBoxRGB";
            this.groupBoxRGB.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRGB.Size = new System.Drawing.Size(288, 359);
            this.groupBoxRGB.TabIndex = 25;
            this.groupBoxRGB.TabStop = false;
            this.groupBoxRGB.Text = "RGB";
            this.groupBoxRGB.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.numericUpDownBlue);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.numericUpDownGreen);
            this.panel5.Controls.Add(this.numericUpDownRed);
            this.panel5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel5.Location = new System.Drawing.Point(7, 21);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(273, 107);
            this.panel5.TabIndex = 29;
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.ForeColor = System.Drawing.Color.Blue;
            this.numericUpDownBlue.Location = new System.Drawing.Point(163, 54);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownBlue.TabIndex = 31;
            this.numericUpDownBlue.Leave += new System.EventHandler(this.numericUpDownBlue_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Цвет в RGB";
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numericUpDownGreen.Location = new System.Drawing.Point(97, 54);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownGreen.TabIndex = 30;
            this.numericUpDownGreen.Leave += new System.EventHandler(this.numericUpDownGreen_Leave);
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.ForeColor = System.Drawing.Color.Red;
            this.numericUpDownRed.Location = new System.Drawing.Point(28, 54);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(63, 22);
            this.numericUpDownRed.TabIndex = 29;
            this.numericUpDownRed.Leave += new System.EventHandler(this.numericUpDownRed_Leave);
            // 
            // groupBoxConvert
            // 
            this.groupBoxConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.groupBoxConvert.Controls.Add(this.labelRGB);
            this.groupBoxConvert.Controls.Add(this.labelHSV);
            this.groupBoxConvert.Controls.Add(this.pictureBoxReplacerRGB_HSV);
            this.groupBoxConvert.Controls.Add(this.panel4);
            this.groupBoxConvert.Controls.Add(this.pictureBoxColor);
            this.groupBoxConvert.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxConvert.Location = new System.Drawing.Point(13, 13);
            this.groupBoxConvert.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxConvert.Name = "groupBoxConvert";
            this.groupBoxConvert.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxConvert.Size = new System.Drawing.Size(239, 359);
            this.groupBoxConvert.TabIndex = 28;
            this.groupBoxConvert.TabStop = false;
            this.groupBoxConvert.Text = "HSV->RGB";
            // 
            // labelRGB
            // 
            this.labelRGB.AutoSize = true;
            this.labelRGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRGB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelRGB.Location = new System.Drawing.Point(139, 160);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(79, 32);
            this.labelRGB.TabIndex = 31;
            this.labelRGB.Text = "RGB";
            // 
            // labelHSV
            // 
            this.labelHSV.AutoSize = true;
            this.labelHSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHSV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelHSV.Location = new System.Drawing.Point(11, 160);
            this.labelHSV.Name = "labelHSV";
            this.labelHSV.Size = new System.Drawing.Size(76, 32);
            this.labelHSV.TabIndex = 30;
            this.labelHSV.Text = "HSV";
            // 
            // pictureBoxReplacerRGB_HSV
            // 
            this.pictureBoxReplacerRGB_HSV.BackColor = System.Drawing.Color.Black;
            this.pictureBoxReplacerRGB_HSV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxReplacerRGB_HSV.Image")));
            this.pictureBoxReplacerRGB_HSV.Location = new System.Drawing.Point(98, 167);
            this.pictureBoxReplacerRGB_HSV.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.pictureBoxReplacerRGB_HSV.Name = "pictureBoxReplacerRGB_HSV";
            this.pictureBoxReplacerRGB_HSV.Size = new System.Drawing.Size(38, 25);
            this.pictureBoxReplacerRGB_HSV.TabIndex = 32;
            this.pictureBoxReplacerRGB_HSV.TabStop = false;
            this.pictureBoxReplacerRGB_HSV.Click += new System.EventHandler(this.pictureBoxReplacerRGB_HSV_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.textBoxB);
            this.panel4.Controls.Add(this.textBoxG);
            this.panel4.Controls.Add(this.textBoxR);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBoxV);
            this.panel4.Controls.Add(this.textBoxS);
            this.panel4.Controls.Add(this.textBoxH);
            this.panel4.Controls.Add(this.buttonConverter);
            this.panel4.Controls.Add(this.label5);
            this.panel4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel4.Location = new System.Drawing.Point(7, 200);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 120);
            this.panel4.TabIndex = 26;
            // 
            // textBoxB
            // 
            this.textBoxB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxB.ForeColor = System.Drawing.Color.Blue;
            this.textBoxB.Location = new System.Drawing.Point(166, 41);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ReadOnly = true;
            this.textBoxB.Size = new System.Drawing.Size(52, 22);
            this.textBoxB.TabIndex = 32;
            this.textBoxB.Tag = "2";
            this.textBoxB.Text = "0";
            this.textBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxG
            // 
            this.textBoxG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxG.Location = new System.Drawing.Point(108, 41);
            this.textBoxG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.ReadOnly = true;
            this.textBoxG.Size = new System.Drawing.Size(52, 22);
            this.textBoxG.TabIndex = 31;
            this.textBoxG.Tag = "2";
            this.textBoxG.Text = "0";
            this.textBoxG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxR
            // 
            this.textBoxR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxR.ForeColor = System.Drawing.Color.Red;
            this.textBoxR.Location = new System.Drawing.Point(50, 41);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.Size = new System.Drawing.Size(52, 22);
            this.textBoxR.TabIndex = 30;
            this.textBoxR.Tag = "2";
            this.textBoxR.Text = "0";
            this.textBoxR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(5, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "RGB";
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(166, 3);
            this.textBoxV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.ReadOnly = true;
            this.textBoxV.Size = new System.Drawing.Size(52, 22);
            this.textBoxV.TabIndex = 26;
            this.textBoxV.Tag = "2";
            this.textBoxV.Text = "0";
            this.textBoxV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(108, 3);
            this.textBoxS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.ReadOnly = true;
            this.textBoxS.Size = new System.Drawing.Size(52, 22);
            this.textBoxS.TabIndex = 25;
            this.textBoxS.Tag = "2";
            this.textBoxS.Text = "0";
            this.textBoxS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(50, 3);
            this.textBoxH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.ReadOnly = true;
            this.textBoxH.Size = new System.Drawing.Size(52, 22);
            this.textBoxH.TabIndex = 24;
            this.textBoxH.Tag = "2";
            this.textBoxH.Text = "0";
            this.textBoxH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonConverter
            // 
            this.buttonConverter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonConverter.Location = new System.Drawing.Point(141, 77);
            this.buttonConverter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(77, 32);
            this.buttonConverter.TabIndex = 0;
            this.buttonConverter.Text = "toRGB";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.button1_ClickToRGB);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(5, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "HSV";
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BackColor = System.Drawing.Color.Black;
            this.pictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxColor.Location = new System.Drawing.Point(50, 21);
            this.pictureBoxColor.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(137, 124);
            this.pictureBoxColor.TabIndex = 25;
            this.pictureBoxColor.TabStop = false;
            // 
            // pictureBoxReplacerHSBtoRGB
            // 
            this.pictureBoxReplacerHSBtoRGB.BackColor = System.Drawing.Color.Black;
            this.pictureBoxReplacerHSBtoRGB.Location = new System.Drawing.Point(4, 25);
            this.pictureBoxReplacerHSBtoRGB.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxReplacerHSBtoRGB.Name = "pictureBoxReplacerHSBtoRGB";
            this.pictureBoxReplacerHSBtoRGB.Size = new System.Drawing.Size(42, 25);
            this.pictureBoxReplacerHSBtoRGB.TabIndex = 29;
            this.pictureBoxReplacerHSBtoRGB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(566, 380);
            this.Controls.Add(this.groupBoxRGB);
            this.Controls.Add(this.groupBoxConvert);
            this.Controls.Add(this.groupBoxHSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная №3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBoxHSV.ResumeLayout(false);
            this.groupBoxRGB.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            this.groupBoxConvert.ResumeLayout(false);
            this.groupBoxConvert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReplacerRGB_HSV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReplacerHSBtoRGB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxColor1;
        private System.Windows.Forms.TextBox textBoxSaturation1;
        private System.Windows.Forms.TextBox textBoxBright1;
        private System.Windows.Forms.ComboBox comboBoxDates1;
        private System.Windows.Forms.ComboBox comboBoxDates2;
        private System.Windows.Forms.ComboBox comboBoxDates3;
        private System.Windows.Forms.ComboBox comboBoxSymbol1;
        private System.Windows.Forms.TextBox textBoxColor2;
        private System.Windows.Forms.ComboBox comboBoxSymbol2;
        private System.Windows.Forms.TextBox textBoxSaturation2;
        private System.Windows.Forms.TextBox textBoxBright2;
        private System.Windows.Forms.ComboBox comboBoxSymbol3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.GroupBox groupBoxHSV;
        private System.Windows.Forms.GroupBox groupBoxRGB;
        private System.Windows.Forms.GroupBox groupBoxConvert;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.PictureBox pictureBoxReplacerHSBtoRGB;
        private System.Windows.Forms.Label labelRGB;
        private System.Windows.Forms.Label labelHSV;
        private System.Windows.Forms.PictureBox pictureBoxReplacerRGB_HSV;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

