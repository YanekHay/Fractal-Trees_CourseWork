namespace Course_Work.Resources
{
    partial class FractalTrees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.track_count = new System.Windows.Forms.TrackBar();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_angle = new System.Windows.Forms.Label();
            this.track_angle = new System.Windows.Forms.TrackBar();
            this.lbl_factor = new System.Windows.Forms.Label();
            this.track_factor = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_randomness = new System.Windows.Forms.Label();
            this.track_randomness = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_colors = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_R = new System.Windows.Forms.Label();
            this.track_R = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_G = new System.Windows.Forms.Label();
            this.track_G = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.track_B = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_alpha = new System.Windows.Forms.Label();
            this.track_alpha = new System.Windows.Forms.TrackBar();
            this.track_width = new System.Windows.Forms.TrackBar();
            this.lbl_width = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.track_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_factor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_randomness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // track_count
            // 
            this.track_count.AutoSize = false;
            this.track_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.track_count.Location = new System.Drawing.Point(1, 28);
            this.track_count.Minimum = 1;
            this.track_count.Name = "track_count";
            this.track_count.Size = new System.Drawing.Size(244, 29);
            this.track_count.TabIndex = 0;
            this.track_count.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_count.Value = 1;
            this.track_count.ValueChanged += new System.EventHandler(this.track_count_ValueChanged);
            // 
            // lbl_count
            // 
            this.lbl_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.lbl_count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.lbl_count.Location = new System.Drawing.Point(182, 5);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(50, 20);
            this.lbl_count.TabIndex = 1;
            this.lbl_count.Text = "1";
            // 
            // lbl_angle
            // 
            this.lbl_angle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.lbl_angle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_angle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.lbl_angle.Location = new System.Drawing.Point(183, 60);
            this.lbl_angle.Name = "lbl_angle";
            this.lbl_angle.Size = new System.Drawing.Size(50, 20);
            this.lbl_angle.TabIndex = 3;
            this.lbl_angle.Text = "45";
            // 
            // track_angle
            // 
            this.track_angle.AutoSize = false;
            this.track_angle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.track_angle.Location = new System.Drawing.Point(1, 83);
            this.track_angle.Maximum = 360;
            this.track_angle.Name = "track_angle";
            this.track_angle.Size = new System.Drawing.Size(244, 30);
            this.track_angle.TabIndex = 2;
            this.track_angle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_angle.Value = 45;
            this.track_angle.Scroll += new System.EventHandler(this.track_angle_Scroll);
            this.track_angle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.track_angle_MouseUp);
            // 
            // lbl_factor
            // 
            this.lbl_factor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.lbl_factor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_factor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_factor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.lbl_factor.Location = new System.Drawing.Point(182, 172);
            this.lbl_factor.Name = "lbl_factor";
            this.lbl_factor.Size = new System.Drawing.Size(50, 20);
            this.lbl_factor.TabIndex = 5;
            this.lbl_factor.Text = "0.9";
            // 
            // track_factor
            // 
            this.track_factor.AutoSize = false;
            this.track_factor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.track_factor.Location = new System.Drawing.Point(-2, 195);
            this.track_factor.Maximum = 150;
            this.track_factor.Minimum = 10;
            this.track_factor.Name = "track_factor";
            this.track_factor.Size = new System.Drawing.Size(244, 30);
            this.track_factor.TabIndex = 4;
            this.track_factor.TickFrequency = 10;
            this.track_factor.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_factor.Value = 90;
            this.track_factor.Scroll += new System.EventHandler(this.track_factor_Scroll);
            this.track_factor.ValueChanged += new System.EventHandler(this.track_factor_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Branch Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(1, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Global Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(-1, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Length Factor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(1, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Randomness";
            // 
            // lbl_randomness
            // 
            this.lbl_randomness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.lbl_randomness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_randomness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_randomness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.lbl_randomness.Location = new System.Drawing.Point(184, 228);
            this.lbl_randomness.Name = "lbl_randomness";
            this.lbl_randomness.Size = new System.Drawing.Size(50, 20);
            this.lbl_randomness.TabIndex = 20;
            this.lbl_randomness.Text = "0.0";
            // 
            // track_randomness
            // 
            this.track_randomness.AutoSize = false;
            this.track_randomness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.track_randomness.Location = new System.Drawing.Point(0, 251);
            this.track_randomness.Maximum = 150;
            this.track_randomness.Name = "track_randomness";
            this.track_randomness.Size = new System.Drawing.Size(244, 30);
            this.track_randomness.TabIndex = 19;
            this.track_randomness.TickFrequency = 10;
            this.track_randomness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_randomness.Scroll += new System.EventHandler(this.track_randomness_Scroll);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // btn_colors
            // 
            this.btn_colors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.btn_colors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_colors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.btn_colors.Location = new System.Drawing.Point(324, -1);
            this.btn_colors.Name = "btn_colors";
            this.btn_colors.Size = new System.Drawing.Size(232, 33);
            this.btn_colors.TabIndex = 22;
            this.btn_colors.Text = "Change Colors";
            this.btn_colors.UseVisualStyleBackColor = false;
            this.btn_colors.Click += new System.EventHandler(this.btn_colors_Click);
            // 
            // colorDialog2
            // 
            this.colorDialog2.FullOpen = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(324, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Red Channel";
            // 
            // lbl_R
            // 
            this.lbl_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.lbl_R.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.lbl_R.Location = new System.Drawing.Point(506, 48);
            this.lbl_R.Name = "lbl_R";
            this.lbl_R.Size = new System.Drawing.Size(50, 20);
            this.lbl_R.TabIndex = 24;
            this.lbl_R.Text = "45";
            // 
            // track_R
            // 
            this.track_R.AutoSize = false;
            this.track_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.track_R.Location = new System.Drawing.Point(324, 71);
            this.track_R.Maximum = 255;
            this.track_R.Name = "track_R";
            this.track_R.Size = new System.Drawing.Size(244, 30);
            this.track_R.TabIndex = 23;
            this.track_R.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_R.Value = 45;
            this.track_R.Scroll += new System.EventHandler(this.track_R_Scrolled);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.label7.Location = new System.Drawing.Point(324, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Green Channel";
            // 
            // lbl_G
            // 
            this.lbl_G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.lbl_G.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_G.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_G.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.lbl_G.Location = new System.Drawing.Point(506, 104);
            this.lbl_G.Name = "lbl_G";
            this.lbl_G.Size = new System.Drawing.Size(50, 20);
            this.lbl_G.TabIndex = 27;
            this.lbl_G.Text = "45";
            // 
            // track_G
            // 
            this.track_G.AutoSize = false;
            this.track_G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.track_G.Location = new System.Drawing.Point(324, 127);
            this.track_G.Maximum = 255;
            this.track_G.Name = "track_G";
            this.track_G.Size = new System.Drawing.Size(244, 30);
            this.track_G.TabIndex = 26;
            this.track_G.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_G.Value = 45;
            this.track_G.Scroll += new System.EventHandler(this.track_G_Scrolled);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.label9.Location = new System.Drawing.Point(324, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Blue Channel";
            // 
            // lbl_B
            // 
            this.lbl_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.lbl_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.lbl_B.Location = new System.Drawing.Point(506, 160);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(50, 20);
            this.lbl_B.TabIndex = 30;
            this.lbl_B.Text = "45";
            // 
            // track_B
            // 
            this.track_B.AutoSize = false;
            this.track_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.track_B.Location = new System.Drawing.Point(324, 183);
            this.track_B.Maximum = 255;
            this.track_B.Name = "track_B";
            this.track_B.Size = new System.Drawing.Size(244, 30);
            this.track_B.TabIndex = 29;
            this.track_B.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_B.Value = 45;
            this.track_B.Scroll += new System.EventHandler(this.track_B_Scrolled);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.label6.Location = new System.Drawing.Point(324, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Alpha Channel";
            // 
            // lbl_alpha
            // 
            this.lbl_alpha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.lbl_alpha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_alpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_alpha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.lbl_alpha.Location = new System.Drawing.Point(506, 228);
            this.lbl_alpha.Name = "lbl_alpha";
            this.lbl_alpha.Size = new System.Drawing.Size(50, 20);
            this.lbl_alpha.TabIndex = 33;
            this.lbl_alpha.Text = "255";
            // 
            // track_alpha
            // 
            this.track_alpha.AutoSize = false;
            this.track_alpha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.track_alpha.Location = new System.Drawing.Point(324, 251);
            this.track_alpha.Maximum = 255;
            this.track_alpha.Name = "track_alpha";
            this.track_alpha.Size = new System.Drawing.Size(244, 30);
            this.track_alpha.TabIndex = 32;
            this.track_alpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_alpha.Value = 255;
            this.track_alpha.Scroll += new System.EventHandler(this.track_alpha_Scroll);
            // 
            // track_width
            // 
            this.track_width.AutoSize = false;
            this.track_width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.track_width.Location = new System.Drawing.Point(0, 139);
            this.track_width.Maximum = 30;
            this.track_width.Minimum = 5;
            this.track_width.Name = "track_width";
            this.track_width.Size = new System.Drawing.Size(244, 30);
            this.track_width.TabIndex = 16;
            this.track_width.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_width.Value = 10;
            this.track_width.Scroll += new System.EventHandler(this.track_width_Scroll);
            // 
            // lbl_width
            // 
            this.lbl_width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.lbl_width.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_width.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.lbl_width.Location = new System.Drawing.Point(182, 116);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(50, 20);
            this.lbl_width.TabIndex = 17;
            this.lbl_width.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.label10.Location = new System.Drawing.Point(0, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Generation Width";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(587, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 335);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // FractalTrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(945, 481);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_alpha);
            this.Controls.Add(this.track_alpha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.track_B);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_G);
            this.Controls.Add(this.track_G);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_R);
            this.Controls.Add(this.track_R);
            this.Controls.Add(this.btn_colors);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_randomness);
            this.Controls.Add(this.track_randomness);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_width);
            this.Controls.Add(this.track_width);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_factor);
            this.Controls.Add(this.track_factor);
            this.Controls.Add(this.lbl_angle);
            this.Controls.Add(this.track_angle);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.track_count);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.Name = "FractalTrees";
            this.Text = "FractalTrees";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FractalTrees_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FractalTrees_MouseUp);
            this.Resize += new System.EventHandler(this.FractalTrees_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.track_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_factor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_randomness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar track_count;
        private Label lbl_count;
        private Label lbl_angle;
        private TrackBar track_angle;
        private Label lbl_factor;
        private TrackBar track_factor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_randomness;
        private TrackBar track_randomness;
        private ColorDialog colorDialog1;
        private Button btn_colors;
        private ColorDialog colorDialog2;
        private Label label5;
        private Label lbl_R;
        private TrackBar track_R;
        private Label label7;
        private Label lbl_G;
        private TrackBar track_G;
        private Label label9;
        private Label lbl_B;
        private TrackBar track_B;
        private Label label6;
        private Label lbl_alpha;
        private TrackBar track_alpha;
        private TrackBar track_width;
        private Label lbl_width;
        private Label label10;
        private PictureBox pictureBox1;
    }
}