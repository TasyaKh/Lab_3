
namespace WindowsFormsApp1
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
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRGB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(259, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(288, 359);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HSV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "RGB";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(141, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "toRGB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRGB
            // 
            this.textBoxRGB.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRGB.Location = new System.Drawing.Point(50, 37);
            this.textBoxRGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRGB.Name = "textBoxRGB";
            this.textBoxRGB.ReadOnly = true;
            this.textBoxRGB.Size = new System.Drawing.Size(168, 25);
            this.textBoxRGB.TabIndex = 22;
            this.textBoxRGB.Tag = "1";
            this.textBoxRGB.Text = "rgb(0, 0, 0)";
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(239, 359);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HSV->RGB";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(50, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 124);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.textBoxV);
            this.panel4.Controls.Add(this.textBoxRGB);
            this.panel4.Controls.Add(this.textBoxS);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxH);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel4.Location = new System.Drawing.Point(7, 161);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 120);
            this.panel4.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(556, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRGB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
    }
}

