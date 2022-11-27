using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
        public Graphics[] graphics = new Graphics[2];
        public BackgroundWorker[] workers = new BackgroundWorker[2];

        private void FractalTrees_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Branch root = new Branch(this.Width / 2, this.Height, this.Width / 2, this.Height - this.Height / 5, Custom_functions.tree_darkest, 10);

            for (int i = 0; i < this.graphics.Length; i++)
            {
                //Graphics
                this.graphics[i] = this.CreateGraphics();
                //Workers
                this.workers[i] = new BackgroundWorker();
                this.workers[i].WorkerSupportsCancellation = true;
            }


            Tree_Glob = new Tree(root_branch: root,
                                 graphics: this.graphics,
                                 colors: Custom_functions.Get_Tree_Colors(35, 255, Custom_functions.tree_darkest),
                                 workers: workers);

            Tree_Glob.Draw_Tree(Custom_functions.backColors);
            track_angle.Value = 45;
            track_gen_angle.Value = 45;
            track_factor.Value = 80;
            track_count.Value = 2;
            Custom_functions.color_Form(this);

        }
        private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            Tree_Glob.Draw_Tree(BackColor);
        }
        private void track_count_ValueChanged(object sender, EventArgs e)
        {
            lbl_count.Text = track_count.Value.ToString();
        }

        private void track_angle_ValueChanged(object sender, EventArgs e)
        {
            lbl_angle.Text = track_angle.Value.ToString();
            Tree_Glob.Draw_Tree(Custom_functions.backColors);
        }

        private void track_factor_ValueChanged(object sender, EventArgs e)
        {
            lbl_factor.Text = ((double)(track_factor.Value) / 100).ToString();
        }

        private void FractalTrees_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right )
            {
                Tree_Glob.Reset();

                Tree_Glob.Draw_Tree(Custom_functions.backColors);
            }
            else
            {
                Tree_Glob.Add_Generation(Custom_functions.To_Radians(track_gen_angle.Value), (double)track_factor.Value / 100, width_decay: 0.5f, max_child_count: track_count.Value, randomize: track_randomness.Value/30, draw: false);
                Tree_Glob.Change_Angle_To(track_angle.Value);
                Tree_Glob.Draw_Tree(Custom_functions.backColors);
            }
        }

        private void FractalTrees_Resize(object sender, EventArgs e)
        {

            for (int i = 0; i < this.graphics.Length; i++)
            {
                //Graphics
                this.graphics[i] = this.CreateGraphics();
            }
        }

        private void track_angle_MouseUp(object sender, MouseEventArgs e)
        {
                Tree_Glob.Change_Angle_To(track_angle.Value);
                Tree_Glob.Draw_Tree(Custom_functions.backColors);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {

        }

        private void track_gen_angle_ValueChanged(object sender, EventArgs e)
        {
            lbl_gen_angle.Text = track_gen_angle.Value.ToString();
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
            Tree_Glob.colors = Custom_functions.Get_Tree_Colors(35, 255, Custom_functions.tree_darkest);
        }

        private void track_R_ValueChanged(object sender, EventArgs e)
        {
            lbl_R.Text = track_R.Value.ToString();
            Tree_Glob.colors = Custom_functions.Get_Tree_Colors(35, 255, Color.FromArgb(255,track_R.Value, track_G.Value, track_B.Value));
            Tree_Glob.Draw_Tree(Custom_functions.backColors);

        }
        private void track_G_ValueChanged(object sender, EventArgs e)
        {
            lbl_G.Text = track_G.Value.ToString();
            Tree_Glob.colors = Custom_functions.Get_Tree_Colors(35, 255, Color.FromArgb(255,track_R.Value, track_G.Value, track_B.Value));
            Tree_Glob.Draw_Tree(Custom_functions.backColors);

        }

        private void track_B_ValueChanged(object sender, EventArgs e)
        {
            lbl_B.Text = track_B.Value.ToString();
            Tree_Glob.colors = Custom_functions.Get_Tree_Colors(35, 255, Color.FromArgb(255,track_R.Value, track_G.Value, track_B.Value));
            Tree_Glob.Draw_Tree(Custom_functions.backColors);

        }

        private void track_angle_Scroll(object sender, EventArgs e)
        {
            Tree_Glob.Change_Angle_To(track_angle.Value);
            Tree_Glob.Draw_Tree(Custom_functions.backColors);
        }

        private void track_factor_Scroll(object sender, EventArgs e)
        {

        }
    }
}
