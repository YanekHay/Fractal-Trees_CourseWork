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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.track_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_factor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // track_count
            // 
            this.track_count.AutoSize = false;
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
            this.lbl_count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_count.Location = new System.Drawing.Point(161, 5);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(50, 20);
            this.lbl_count.TabIndex = 1;
            this.lbl_count.Text = "1";
            // 
            // lbl_angle
            // 
            this.lbl_angle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_angle.Location = new System.Drawing.Point(183, 60);
            this.lbl_angle.Name = "lbl_angle";
            this.lbl_angle.Size = new System.Drawing.Size(50, 20);
            this.lbl_angle.TabIndex = 3;
            this.lbl_angle.Text = "45";
            // 
            // track_angle
            // 
            this.track_angle.AutoSize = false;
            this.track_angle.BackColor = System.Drawing.Color.White;
            this.track_angle.Location = new System.Drawing.Point(1, 83);
            this.track_angle.Maximum = 360;
            this.track_angle.Name = "track_angle";
            this.track_angle.Size = new System.Drawing.Size(244, 30);
            this.track_angle.TabIndex = 2;
            this.track_angle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_angle.Value = 45;
            this.track_angle.ValueChanged += new System.EventHandler(this.track_angle_ValueChanged);
            this.track_angle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.track_angle_MouseUp);
            // 
            // lbl_factor
            // 
            this.lbl_factor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_factor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_factor.Location = new System.Drawing.Point(159, 172);
            this.lbl_factor.Name = "lbl_factor";
            this.lbl_factor.Size = new System.Drawing.Size(50, 20);
            this.lbl_factor.TabIndex = 5;
            this.lbl_factor.Text = "0.9";
            // 
            // track_factor
            // 
            this.track_factor.AutoSize = false;
            this.track_factor.Location = new System.Drawing.Point(-2, 195);
            this.track_factor.Maximum = 150;
            this.track_factor.Minimum = 10;
            this.track_factor.Name = "track_factor";
            this.track_factor.Size = new System.Drawing.Size(244, 30);
            this.track_factor.TabIndex = 4;
            this.track_factor.TickFrequency = 10;
            this.track_factor.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_factor.Value = 90;
            this.track_factor.ValueChanged += new System.EventHandler(this.track_factor_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Branch Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Generation Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-1, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Length Factor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(0, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Global Angles";
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(182, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "45";
            // 
            // trackBar4
            // 
            this.trackBar4.AutoSize = false;
            this.trackBar4.BackColor = System.Drawing.Color.White;
            this.trackBar4.Location = new System.Drawing.Point(0, 139);
            this.trackBar4.Maximum = 360;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(244, 30);
            this.trackBar4.TabIndex = 16;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar4.Value = 45;
            // 
            // FractalTrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.trackBar4);
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
            this.Name = "FractalTrees";
            this.Text = "FractalTrees";
            this.Load += new System.EventHandler(this.FractalTrees_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FractalTrees_MouseUp);
            this.Resize += new System.EventHandler(this.FractalTrees_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.track_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_factor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
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
        private Label label10;
        private Label label11;
        private TrackBar trackBar4;
    }
}