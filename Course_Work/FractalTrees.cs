using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Course_Work.Resources
{
    public partial class FractalTrees : Form
    {
        public FractalTrees()
        {
            InitializeComponent();
        }
        public Tree Tree_Glob;
        public Graphics graphics;
        public BackgroundWorker backgroundWorker = new BackgroundWorker();
        private void FractalTrees_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.graphics = pictureBox1.CreateGraphics();

            //Branch root = new Branch(this.Width / 2, this.Height, this.Width / 2, this.Height - this.Height / 5, track_width.Value);
            pictureBox1.Size = this.Size;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.SendToBack();
            Branch root = new Branch(pictureBox1.Location.X + pictureBox1.Width / 2, pictureBox1.Location.Y + 2*pictureBox1.Height, pictureBox1.Location.X + pictureBox1.Width / 2, pictureBox1.Location.Y + 2*pictureBox1.Height - pictureBox1.Height / 5, track_width.Value);
            Tree_Glob = new Tree(root_branch: root,
                                 graphics: this.graphics,
                                 colors: Custom_functions.Get_Tree_Colors(35, Custom_functions.tree_darkest));
            
            
            Tree_Glob.worker = this.backgroundWorker;

            
            this.graphics.Clear(Custom_functions.backColors);
            Tree_Glob.Draw_Tree(Custom_functions.backColors);


            track_angle.Value = 45;
            track_factor.Value = 80;
            track_count.Value = 2;
            Custom_functions.color_Form(this);

            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
        }
        private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            Tree_Glob.Draw_Tree(BackColor);
        }
        private void track_count_ValueChanged(object sender, EventArgs e)
        {
            lbl_count.Text = track_count.Value.ToString();
        }


        private void track_factor_ValueChanged(object sender, EventArgs e)
        {
            lbl_factor.Text = ((double)(track_factor.Value) / 100).ToString();
        }

        private void FractalTrees_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!backgroundWorker.IsBusy)
                {
                    this.graphics.Clear(BackColor);
                    Tree_Glob.Reset();
                    Tree_Glob.Draw_Tree(Custom_functions.backColors);
                }
            }
            else
            {
                Tree_Glob.Add_Generation(Custom_functions.To_Radians(track_angle.Value), (double)track_factor.Value / 100, width_decay: 0.5f, max_child_count: track_count.Value, randomize: track_randomness.Value/30, draw: false);
                Tree_Glob.Change_Angle_To(track_angle.Value);
                if (!backgroundWorker.IsBusy)
                {
                    backgroundWorker.RunWorkerAsync();
                }
            }
        }

        private void FractalTrees_Resize(object sender, EventArgs e)
        {
            this.graphics = pictureBox1.CreateGraphics();
        }

        private void track_angle_MouseUp(object sender, MouseEventArgs e)
        {
            if (Tree_Glob.generation_indices.Count >= 10) { 
                Tree_Glob.Change_Angle_To(track_angle.Value);
                //Tree_Glob.Draw_Tree(BackColor);
                if (!backgroundWorker.IsBusy)
                {
                    this.graphics.Clear(BackColor);
                    backgroundWorker.RunWorkerAsync();
                }
            }
        }

        private void btn_colors_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Custom_functions.tree_darkest = colorDialog1.Color;
            }
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                Custom_functions.tree_brightest = colorDialog2.Color;
            }
            Tree_Glob.colors = Custom_functions.Get_Tree_Colors(35, Custom_functions.tree_darkest, Custom_functions.tree_brightest);
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void track_R_Scrolled(object sender, EventArgs e)
        {
            lbl_R.Text = track_R.Value.ToString();
            Tree_Glob.colors = Custom_functions.Get_Tree_Colors(35, Color.FromArgb(track_alpha.Value, track_R.Value, track_G.Value, track_B.Value));
            //Tree_Glob.Draw_Tree(Custom_functions.backColors);
            if (!backgroundWorker.IsBusy)
            {
                this.graphics.Clear(BackColor);
                backgroundWorker.RunWorkerAsync();
            }
        }
        private void track_G_Scrolled(object sender, EventArgs e)
        {
            lbl_G.Text = track_G.Value.ToString();
            Tree_Glob.colors = Custom_functions.Get_Tree_Colors(35, Color.FromArgb(track_alpha.Value, track_R.Value, track_G.Value, track_B.Value));
            //Tree_Glob.Draw_Tree(Custom_functions.backColors);
            if (!backgroundWorker.IsBusy)
            {
                this.graphics.Clear(BackColor);
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void track_B_Scrolled(object sender, EventArgs e)
        {
            lbl_B.Text = track_B.Value.ToString();
            Tree_Glob.colors = Custom_functions.Get_Tree_Colors(35, Color.FromArgb(track_alpha.Value, track_R.Value, track_G.Value, track_B.Value));
            //Tree_Glob.Draw_Tree(Custom_functions.backColors);
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }
 
        private void track_angle_Scroll(object sender, EventArgs e)
        {
            lbl_angle.Text = track_angle.Value.ToString();
            if (Tree_Glob.generation_indices.Count < 10)
            {
                Tree_Glob.Change_Angle_To(track_angle.Value);
                //Tree_Glob.Draw_Tree(BackColor);
                if (!backgroundWorker.IsBusy)
                {
                    this.graphics.Clear(BackColor);
                    backgroundWorker.RunWorkerAsync();
                }
            }
        }

        private void track_factor_Scroll(object sender, EventArgs e)
        {
            lbl_factor.Text = track_factor.Value.ToString();

        }

        private void track_randomness_Scroll(object sender, EventArgs e)
        {
            lbl_randomness.Text = track_randomness.Value.ToString();
        }

        private void track_alpha_Scroll(object sender, EventArgs e)
        {
            lbl_alpha.Text = track_alpha.Value.ToString();
            Tree_Glob.colors = Custom_functions.Get_Tree_Colors(35, Color.FromArgb(track_alpha.Value, track_R.Value, track_G.Value, track_B.Value));
            //Tree_Glob.Draw_Tree(Custom_functions.backColors);
            if (!backgroundWorker.IsBusy)
            {
                this.graphics.Clear(BackColor);
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void track_width_Scroll(object sender, EventArgs e)
        {
            float width_diff = track_width.Value - Tree_Glob.branches[0].width;
            foreach (Branch branch in Tree_Glob.branches) {
                branch.width = branch.width + width_diff;
            }
            if (!backgroundWorker.IsBusy)
            {
                this.graphics.Clear(BackColor);
                backgroundWorker.RunWorkerAsync();
            }
        }
    }
}
