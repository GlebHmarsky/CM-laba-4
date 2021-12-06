namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Par_D = new System.Windows.Forms.NumericUpDown();
            this.Par_C = new System.Windows.Forms.NumericUpDown();
            this.Par_B = new System.Windows.Forms.NumericUpDown();
            this.Par_A = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxRo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxEpsilon = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxFi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxBeta = new System.Windows.Forms.TextBox();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_points = new System.Windows.Forms.NumericUpDown();
            this.Build_up = new System.Windows.Forms.Button();
            this.Graph = new ZedGraph.ZedGraphControl();
            this.Clear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSigma = new System.Windows.Forms.TextBox();
            this.textBoxHalfLife = new System.Windows.Forms.TextBox();
            this.textBoxNu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Par_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_A)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_points)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Par_D
            // 
            this.Par_D.DecimalPlaces = 3;
            this.Par_D.Location = new System.Drawing.Point(735, 134);
            this.Par_D.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_D.Name = "Par_D";
            this.Par_D.Size = new System.Drawing.Size(80, 20);
            this.Par_D.TabIndex = 12;
            this.Par_D.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // Par_C
            // 
            this.Par_C.DecimalPlaces = 3;
            this.Par_C.Location = new System.Drawing.Point(735, 94);
            this.Par_C.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_C.Name = "Par_C";
            this.Par_C.Size = new System.Drawing.Size(80, 20);
            this.Par_C.TabIndex = 11;
            this.Par_C.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Par_B
            // 
            this.Par_B.DecimalPlaces = 3;
            this.Par_B.Location = new System.Drawing.Point(735, 52);
            this.Par_B.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_B.Name = "Par_B";
            this.Par_B.Size = new System.Drawing.Size(80, 20);
            this.Par_B.TabIndex = 10;
            this.Par_B.Value = new decimal(new int[] {
            105,
            0,
            0,
            131072});
            // 
            // Par_A
            // 
            this.Par_A.DecimalPlaces = 3;
            this.Par_A.Location = new System.Drawing.Point(735, 12);
            this.Par_A.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Par_A.Name = "Par_A";
            this.Par_A.Size = new System.Drawing.Size(80, 20);
            this.Par_A.TabIndex = 9;
            this.Par_A.Value = new decimal(new int[] {
            95,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "А";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1027, 282);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "+";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(952, 282);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "+";
            // 
            // textBoxRo
            // 
            this.textBoxRo.Location = new System.Drawing.Point(831, 278);
            this.textBoxRo.Name = "textBoxRo";
            this.textBoxRo.Size = new System.Drawing.Size(37, 20);
            this.textBoxRo.TabIndex = 25;
            this.textBoxRo.Text = "50";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(1012, 280);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 17);
            this.label23.TabIndex = 23;
            this.label23.Text = "y";
            // 
            // textBoxEpsilon
            // 
            this.textBoxEpsilon.Location = new System.Drawing.Point(928, 232);
            this.textBoxEpsilon.Name = "textBoxEpsilon";
            this.textBoxEpsilon.Size = new System.Drawing.Size(37, 20);
            this.textBoxEpsilon.TabIndex = 22;
            this.textBoxEpsilon.Text = "15";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(717, 280);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(16, 17);
            this.label24.TabIndex = 19;
            this.label24.Text = "=";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(792, 280);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 17);
            this.label25.TabIndex = 21;
            this.label25.Text = "x";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(819, 236);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "+";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(909, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "+";
            // 
            // textBoxFi
            // 
            this.textBoxFi.Location = new System.Drawing.Point(1046, 278);
            this.textBoxFi.Name = "textBoxFi";
            this.textBoxFi.Size = new System.Drawing.Size(37, 20);
            this.textBoxFi.TabIndex = 10;
            this.textBoxFi.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(790, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "x^2";
            // 
            // textBoxBeta
            // 
            this.textBoxBeta.Location = new System.Drawing.Point(840, 232);
            this.textBoxBeta.Name = "textBoxBeta";
            this.textBoxBeta.Size = new System.Drawing.Size(37, 20);
            this.textBoxBeta.TabIndex = 7;
            this.textBoxBeta.Text = "50";
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(751, 232);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(37, 20);
            this.textBoxAlpha.TabIndex = 5;
            this.textBoxAlpha.Text = "-100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(705, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "ẏ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(717, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(705, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "ẋ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(880, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "y^2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numeric_points);
            this.groupBox3.Location = new System.Drawing.Point(687, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Точность и число шагов";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(235, 89);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(58, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "0,0001";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(170, 89);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "0,001";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(111, 89);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "0,01";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(58, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(40, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "0,1";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 89);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Число шагов n";
            // 
            // numeric_points
            // 
            this.numeric_points.Location = new System.Drawing.Point(195, 36);
            this.numeric_points.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_points.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_points.Name = "numeric_points";
            this.numeric_points.Size = new System.Drawing.Size(90, 20);
            this.numeric_points.TabIndex = 0;
            this.numeric_points.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // Build_up
            // 
            this.Build_up.BackColor = System.Drawing.Color.OliveDrab;
            this.Build_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Build_up.Location = new System.Drawing.Point(687, 597);
            this.Build_up.Name = "Build_up";
            this.Build_up.Size = new System.Drawing.Size(153, 59);
            this.Build_up.TabIndex = 4;
            this.Build_up.Text = "Применить";
            this.Build_up.UseVisualStyleBackColor = false;
            this.Build_up.Click += new System.EventHandler(this.Build_up_Click);
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.SystemColors.Control;
            this.Graph.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Graph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Graph.IsEnableHZoom = false;
            this.Graph.IsEnableVZoom = false;
            this.Graph.Location = new System.Drawing.Point(12, 124);
            this.Graph.Name = "Graph";
            this.Graph.ScrollGrace = 0D;
            this.Graph.ScrollMaxX = 0D;
            this.Graph.ScrollMaxY = 0D;
            this.Graph.ScrollMaxY2 = 0D;
            this.Graph.ScrollMinX = 0D;
            this.Graph.ScrollMinY = 0D;
            this.Graph.ScrollMinY2 = 0D;
            this.Graph.Size = new System.Drawing.Size(660, 532);
            this.Graph.TabIndex = 5;
            this.Graph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Graph_MouseClick);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.SandyBrown;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Clear.Location = new System.Drawing.Point(882, 597);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(110, 59);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Очистить всё";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Resource1.Хмаркий_Глеб_Лаба4;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(660, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(732, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "(";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(869, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = ")";
            // 
            // textBoxSigma
            // 
            this.textBoxSigma.Location = new System.Drawing.Point(751, 278);
            this.textBoxSigma.Name = "textBoxSigma";
            this.textBoxSigma.Size = new System.Drawing.Size(37, 20);
            this.textBoxSigma.TabIndex = 20;
            this.textBoxSigma.Text = "-50";
            // 
            // textBoxHalfLife
            // 
            this.textBoxHalfLife.Location = new System.Drawing.Point(893, 278);
            this.textBoxHalfLife.Name = "textBoxHalfLife";
            this.textBoxHalfLife.Size = new System.Drawing.Size(37, 20);
            this.textBoxHalfLife.TabIndex = 25;
            this.textBoxHalfLife.Text = "1000";
            // 
            // textBoxNu
            // 
            this.textBoxNu.Location = new System.Drawing.Point(969, 278);
            this.textBoxNu.Name = "textBoxNu";
            this.textBoxNu.Size = new System.Drawing.Size(37, 20);
            this.textBoxNu.TabIndex = 25;
            this.textBoxNu.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(812, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "+";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(879, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 17);
            this.label16.TabIndex = 30;
            this.label16.Text = "(";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(1089, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = ")";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(932, 280);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "x";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Linen;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.Location = new System.Drawing.Point(893, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(171, 84);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "С помощью СКМ можно перетаскивать отображаемую часть графика";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1114, 668);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Par_D);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxNu);
            this.Controls.Add(this.textBoxHalfLife);
            this.Controls.Add(this.textBoxRo);
            this.Controls.Add(this.Par_C);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.Par_B);
            this.Controls.Add(this.textBoxEpsilon);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.textBoxSigma);
            this.Controls.Add(this.Par_A);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Build_up);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBeta);
            this.Controls.Add(this.textBoxAlpha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1020, 610);
            this.Name = "Form1";
            this.Text = "Численное решение системы ОДУ. Хмарский Глеб ИВТ-41 БО";
            ((System.ComponentModel.ISupportInitialize)(this.Par_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Par_A)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_points)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeric_points;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button Build_up;
        private System.Windows.Forms.Button Clear;
        private ZedGraph.ZedGraphControl Graph;
        private System.Windows.Forms.NumericUpDown Par_D;
        private System.Windows.Forms.NumericUpDown Par_C;
        private System.Windows.Forms.NumericUpDown Par_B;
        private System.Windows.Forms.NumericUpDown Par_A;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxBeta;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxRo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxEpsilon;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSigma;
        private System.Windows.Forms.TextBox textBoxHalfLife;
        private System.Windows.Forms.TextBox textBoxNu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
    }
}

