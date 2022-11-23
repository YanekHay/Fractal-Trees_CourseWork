namespace Course_Work
{
    partial class Main
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTrees = new System.Windows.Forms.ToolStripButton();
            this.btnTips = new System.Windows.Forms.ToolStripButton();
            this.btnArange = new System.Windows.Forms.ToolStripDropDownButton();
            this.Arrange_Vertical = new System.Windows.Forms.ToolStripMenuItem();
            this.Arrange_Horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.Arrange_Minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAuthor = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnCloseAll = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(91)))));
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTrees,
            this.btnTips,
            this.btnArange,
            this.btnAuthor,
            this.btnHelp,
            this.btnCloseAll,
            this.btnExit});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnTrees
            // 
            this.btnTrees.AutoSize = false;
            this.btnTrees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTrees.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTrees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(158)))), ((int)(((byte)(107)))));
            this.btnTrees.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTrees.Name = "btnTrees";
            this.btnTrees.Size = new System.Drawing.Size(120, 50);
            this.btnTrees.Text = "FractalTrees";
            this.btnTrees.Click += new System.EventHandler(this.btnTrees_Click);
            this.btnTrees.MouseEnter += new System.EventHandler(this.btnTrees_MouseEnter);
            this.btnTrees.MouseLeave += new System.EventHandler(this.btnTrees_MouseLeave);
            // 
            // btnTips
            // 
            this.btnTips.AutoSize = false;
            this.btnTips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTips.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(158)))), ((int)(((byte)(107)))));
            this.btnTips.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTips.Name = "btnTips";
            this.btnTips.Size = new System.Drawing.Size(100, 50);
            this.btnTips.Text = "Tips";
            this.btnTips.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.btnTips.MouseEnter += new System.EventHandler(this.btnTrees_MouseEnter);
            this.btnTips.MouseLeave += new System.EventHandler(this.btnTrees_MouseLeave);
            // 
            // btnArange
            // 
            this.btnArange.AutoSize = false;
            this.btnArange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnArange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnArange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arrange_Vertical,
            this.Arrange_Horizontal,
            this.Arrange_Minimize});
            this.btnArange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(158)))), ((int)(((byte)(107)))));
            this.btnArange.Name = "btnArange";
            this.btnArange.Size = new System.Drawing.Size(100, 50);
            this.btnArange.Text = "Arrange";
            this.btnArange.MouseEnter += new System.EventHandler(this.btnTrees_MouseEnter);
            this.btnArange.MouseLeave += new System.EventHandler(this.btnTrees_MouseLeave);
            // 
            // Arrange_Vertical
            // 
            this.Arrange_Vertical.Name = "Arrange_Vertical";
            this.Arrange_Vertical.Size = new System.Drawing.Size(169, 26);
            this.Arrange_Vertical.Text = "Vertical";
            this.Arrange_Vertical.Click += new System.EventHandler(this.Arrange_Vertical_Click);
            // 
            // Arrange_Horizontal
            // 
            this.Arrange_Horizontal.Name = "Arrange_Horizontal";
            this.Arrange_Horizontal.Size = new System.Drawing.Size(169, 26);
            this.Arrange_Horizontal.Text = "Horizontal";
            this.Arrange_Horizontal.Click += new System.EventHandler(this.Arrange_Horizontal_Click);
            // 
            // Arrange_Minimize
            // 
            this.Arrange_Minimize.Name = "Arrange_Minimize";
            this.Arrange_Minimize.Size = new System.Drawing.Size(169, 26);
            this.Arrange_Minimize.Text = "Minimize";
            this.Arrange_Minimize.Click += new System.EventHandler(this.Arrange_Minimize_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.AutoSize = false;
            this.btnAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAuthor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(158)))), ((int)(((byte)(107)))));
            this.btnAuthor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(100, 50);
            this.btnAuthor.Text = "Author";
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            this.btnAuthor.MouseEnter += new System.EventHandler(this.btnTrees_MouseEnter);
            this.btnAuthor.MouseLeave += new System.EventHandler(this.btnTrees_MouseLeave);
            // 
            // btnHelp
            // 
            this.btnHelp.AutoSize = false;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(158)))), ((int)(((byte)(107)))));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 50);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.btnTrees_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.btnTrees_MouseLeave);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.AutoSize = false;
            this.btnCloseAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCloseAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(158)))), ((int)(((byte)(107)))));
            this.btnCloseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(100, 50);
            this.btnCloseAll.Text = "Close All";
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            this.btnCloseAll.MouseEnter += new System.EventHandler(this.btnTrees_MouseEnter);
            this.btnCloseAll.MouseLeave += new System.EventHandler(this.btnTrees_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(158)))), ((int)(((byte)(107)))));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnTrees_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnTrees_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnTrees;
        private ToolStripButton btnCloseAll;
        private ToolStripButton btnExit;
        private ToolStripButton btnTips;
        private ToolStripButton btnHelp;
        private ToolStripButton btnAuthor;
        private ToolStripDropDownButton btnArange;
        private ToolStripMenuItem Arrange_Vertical;
        private ToolStripMenuItem Arrange_Horizontal;
        private ToolStripMenuItem Arrange_Minimize;
    }
}