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
        public  Tree Tree_Glob;
        public Graphics graphics;
        private void FractalTrees_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Branch root = new Branch(this.Width / 2, this.Height, this.Width / 2, this.Height - this.Height / 5, 10);
            Tree_Glob = new Tree(root_branch:    root,
                                 graphics:       this.graphics,
                                 colors:         Custom_functions.Get_Tree_Colors(35,255,Custom_functions.tree_darkest,Custom_functions.tree_brightest));
            this.graphics.Clear(Custom_functions.backColors);
            Tree_Glob.Draw_Tree(Custom_functions.backColors, Tree_Glob.colors);
            track_angle.Value = 45;
            track_factor.Value = 80;
            track_count.Value = 2;
            Custom_functions.color_Form(this);
        }

        private void track_count_ValueChanged(object sender, EventArgs e)
        {
            lbl_count.Text = track_count.Value.ToString();
        }

        private void track_angle_ValueChanged(object sender, EventArgs e)
        {
            lbl_angle.Text = track_angle.Value.ToString();
            
            Tree_Glob.Change_Angle_To(track_angle.Value);
            Tree_Glob.Draw_Tree(Custom_functions.backColors, Tree_Glob.colors);

            //Tree_Glob.branches[0].Set_New_Angle(Custom_functions.To_Radians(track_angle.Value+180));
            //Tree_Glob.branches[0].Draw(this.graphics,new Pen(Custom_functions.tree_darkest, 10));

            //int c = Tree_Glob.generation_indices.Count;
            //Tree_Glob.Reset();
            //for (int i = 1; i < c; i++)
            //{
            //    Tree_Glob.Add_Generation(Custom_functions.To_Radians(track_angle.Value), 0.8, width_decay: 0.5f, max_child_count: track_count.Value, randomize: true, draw: true);
            //}
            //Tree_Glob.Draw_Tree(Custom_functions.backColors,Tree_Glob.colors);
        }

        private void track_factor_ValueChanged(object sender, EventArgs e)
        {
            lbl_factor.Text = ((double)(track_factor.Value)/100).ToString();
        }

        private void FractalTrees_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Tree_Glob.Reset();
                Tree_Glob.Draw_Tree(Custom_functions.backColors,Tree_Glob.colors);
            }
            else
            {
                Tree_Glob.Add_Generation(Custom_functions.To_Radians(track_angle.Value), (double)track_factor.Value/100, width_decay: 0.5f, max_child_count:track_count.Value, randomize:true, draw:true);
            }
        }

        private void FractalTrees_Resize(object sender, EventArgs e)
        {
            this.graphics = this.CreateGraphics();
        }

        private void track_angle_MouseUp(object sender, MouseEventArgs e)
        {
            //    lbl_angle.Text = track_angle.Value.ToString();
            //    //Tree_Glob.Change_Angle_To(track_angle.Value, Custom_functions.backColors);
            //    //Tree_Glob.branches[0].Rotate_Rescale(Custom_functions.To_Radians(track_angle.Value+180) - Tree_Glob.branches[0].dir, 1, true);




            //    int c = Tree_Glob.generation_indices.Count;
            //    Tree_Glob.Reset();
            //    for (int i = 1; i < c; i++)
            //    {
            //        Tree_Glob.Add_Generation(Custom_functions.To_Radians(track_angle.Value), 0.8, width_decay: 0.5f, max_child_count: track_count.Value, randomize: true, draw: true);
            //    }
            //    Tree_Glob.Draw_Tree(Custom_functions.backColors, Tree_Glob.colors);
        }
    }
}
