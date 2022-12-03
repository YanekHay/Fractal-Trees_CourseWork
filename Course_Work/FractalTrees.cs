using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
            Branch root = new Branch(this.Width / 2, this.Height, this.Width / 2, this.Height - this.Height / 5, track_width.Value);
            Tree_Glob = new Tree(root_branch: root,
                                 graphics: this.graphics,
                                 colors: Custom_functions.Get_Tree_Colors(35, Custom_functions.tree_darkest));
            
            
            Tree_Glob.worker = this.backgroundWorker;
            btn_hide.Location = new Point(this.Width - btn_hide.Width,0);
            btnSave.Size = btn_hide.Size;
            btnSave.Location = new Point(this.Width - btnSave.Width, btn_hide.Height+3);

            this.graphics.Clear(Custom_functions.backColors);
            Tree_Glob.Draw_Tree(Custom_functions.backColors);


            track_angle.Value = 45;
            track_factor.Value = 80;
            track_count.Value = 2;
            Custom_functions.color_Form(this);

            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            this.Activate();
            timer1.Start();

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
                if (!this.backgroundWorker.IsBusy) { 
                    this.graphics.Clear(Custom_functions.backColors);
                    Tree_Glob.Reset();
                    Tree_Glob.Draw_Tree(Custom_functions.backColors);
                }
                else { 
                MessageBox.Show("Please wait untill the tree will be drawn","Drawing not finished",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (!backgroundWorker.IsBusy)
                {
                    Tree_Glob.Add_Generation(Custom_functions.To_Radians(track_angle.Value), (double)track_factor.Value / 100, width_decay: 0.5f, max_child_count: track_count.Value, randomize: track_randomness.Value/30, draw: false);
                    Tree_Glob.Change_Angle_To(track_angle.Value);
                    backgroundWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Please wait untill the tree will be drawn", "Drawing not finished", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void FractalTrees_Resize(object sender, EventArgs e)
        {
            this.graphics = this.CreateGraphics();
        }
        private void track_angle_MouseUp(object sender, MouseEventArgs e)
        {
            if (Tree_Glob.generation_indices.Count >= 7) { 
                Tree_Glob.Change_Angle_To(track_angle.Value);
                if (!backgroundWorker.IsBusy)
                {
                    this.graphics.Clear(Custom_functions.backColors);
                    backgroundWorker.RunWorkerAsync();
                }
            }
        }

        private void change_tree_colors()
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
        private void btn_colors_Click(object sender, EventArgs e)
        {
            change_tree_colors();
        }

        private void track_R_Scrolled(object sender, EventArgs e)
        {
            lbl_R.Text = track_R.Value.ToString();
            Tree_Glob.colors = Custom_functions.Get_Tree_Colors(35, Color.FromArgb(track_alpha.Value, track_R.Value, track_G.Value, track_B.Value));
            //Tree_Glob.Draw_Tree(Custom_functions.backColors);
            if (!backgroundWorker.IsBusy)
            {
                this.graphics.Clear(Custom_functions.backColors);
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
                this.graphics.Clear(Custom_functions.backColors);
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
                this.graphics.Clear(Custom_functions.backColors);
                backgroundWorker.RunWorkerAsync();
            }
        }
 
        private void track_angle_Scroll(object sender, EventArgs e)
        {
            lbl_angle.Text = track_angle.Value.ToString();
            if (Tree_Glob.generation_indices.Count < 7)
            {
                Tree_Glob.Change_Angle_To(track_angle.Value);
                //Tree_Glob.Draw_Tree(BackColor);
                if (!backgroundWorker.IsBusy)
                {
                    this.graphics.Clear(Custom_functions.backColors);
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
            lbl_randomness.Text = ((double)track_randomness.Value/30).ToString();
        }
        private void track_alpha_Scroll(object sender, EventArgs e)
        {
            lbl_alpha.Text = track_alpha.Value.ToString();
            Tree_Glob.colors = Custom_functions.Get_Tree_Colors(35, Color.FromArgb(track_alpha.Value, track_R.Value, track_G.Value, track_B.Value));
            //Tree_Glob.Draw_Tree(Custom_functions.backColors);
            if (!backgroundWorker.IsBusy)
            {
                this.graphics.Clear(Custom_functions.backColors);
                backgroundWorker.RunWorkerAsync();
            }
        }
        private void track_width_Scroll(object sender, EventArgs e)
        {
            lbl_width.Text = track_width.Value.ToString(); 
            float width_diff = track_width.Value - Tree_Glob.branches[0].width;
            foreach (Branch branch in Tree_Glob.branches) {
                branch.width = branch.width + width_diff;
            }
            if (!backgroundWorker.IsBusy)
            {
                this.graphics.Clear(Custom_functions.backColors);
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void Save_Function()
        {
            btnSave.Visible = false;
            btn_hide.Visible = false;
            // Displays a SaveFileDialog so the user can save the Image
            if (backgroundWorker.IsBusy)
            {
                DialogResult res = MessageBox.Show("The drawing is not finished yet. Do you want to save the image?", "Not Finished Yet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                {
                    return;
                }
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Png Image|*.png|Jpeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save the tree as an image";
            saveFileDialog1.ShowDialog();

            Thread.Sleep(1000);
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
            g.CopyFromScreen(this.Location, Point.Empty, this.Size, CopyPixelOperation.SourceCopy);

            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        bmp.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                        break;

                    case 2:
                        bmp.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 3:

                        bmp.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 4:
                        bmp.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save_Function();
        }

        private void FractalTrees_KeyUp(object sender, KeyEventArgs e)
        {
            /// If Escape is pressed, exit the program
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Custom_functions.main_form = new();
                Custom_functions.main_form.Show();
            }

            /// Else if f is pressed, hide/show all controls
            else if (e.KeyCode == Keys.F)
            {
                if (this.Tag.ToString() == "Hidden")
                {
                    foreach (Control cnt in this.Controls)
                    {
                        cnt.Visible = true;
                    }

                    btn_hide.Text = "Hide Controls (F)";
                    this.Tag = "Visible";
                }
                else
                {
                    foreach (Control cnt in this.Controls)
                    {
                        cnt.Visible = false;
                    }
                    btnSave.Visible = true;
                    btn_hide.Visible = true;

                    btn_hide.Text = "Show Controls (F)";
                    this.Tag = "Hidden";

                }
            }

            /// Else if B is pressed open back_color dialog
            else if(e.KeyCode == Keys.B) {
                if (colorDialog3.ShowDialog() == DialogResult.OK)
                {
                    Custom_functions.backColors = colorDialog3.Color;
                    this.BackColor = colorDialog3.Color;
                    Custom_functions.foreColors = Color.FromArgb(colorDialog3.Color.ToArgb() ^ 0xffffff);
                    Custom_functions.color_Form(this);

                    if (!backgroundWorker.IsBusy)
                    {
                        this.graphics.Clear(Custom_functions.backColors);
                        backgroundWorker.RunWorkerAsync();
                    }
                }
            }

            /// Else if C is pressed open tree_color dialogs
            else if (e.KeyCode == Keys.C)
            {
                change_tree_colors();
            }
            /// Else if S is pressed Save the image
            else if (e.KeyCode == Keys.S)
            {
                Save_Function();
            }
            btnSave.Visible = true;
            btn_hide.Visible = true;
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            if (btn_colors.Visible)
            {
                foreach (Control cnt in this.Controls)
                {
                    cnt.Visible = false;
                }
                btn_hide.Visible= true;
                btnSave.Visible= true;

                btn_hide.Text = "Show Controls (F)";
                this.Tag = "Hidden";
            }
            else
            {
                btn_hide.Text = "Hide Controls (F)";
                this.Tag = "Visible";
                foreach (Control cnt in this.Controls)
                {
                    cnt.Visible = true;
                }
            }
        }

        private void btn_backcolor_Click(object sender, EventArgs e)
        {
            if (colorDialog3.ShowDialog() == DialogResult.OK)
            {
                Custom_functions.backColors = colorDialog3.Color;
                this.BackColor = colorDialog3.Color;
                Custom_functions.foreColors = Color.FromArgb(colorDialog3.Color.ToArgb() ^ 0xffffff);
                Custom_functions.color_Form(this);
                if (!backgroundWorker.IsBusy)
                {
                    this.graphics.Clear(Custom_functions.backColors);
                    backgroundWorker.RunWorkerAsync();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.backgroundWorker.IsBusy && Tree_Glob.generation_indices.Count>7)
            {
                track_angle.Enabled = false;
            }
            else
            {
                track_angle.Enabled = true;
            }
        }



    }
}
