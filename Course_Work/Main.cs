using Course_Work.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private Tips tips = new();
        private AboutForm aboutform = new();
        private HelpForm helpform = new();
        private FractalTrees fractaltrees = new();
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tips.WindowState = FormWindowState.Maximized;
            if (tips.IsDisposed) {
                tips = new();
                aboutform.MdiParent = this;
                Console.WriteLine(this.MdiChildren.Length.ToString());
            }
            tips.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnTrees_MouseEnter(object sender, EventArgs e)
        {
            Control? obj = sender as Control;
            if (obj != null) { 
                obj.BackColor = Custom_functions.mouse_over_backColors;
            }
        }

        private void btnTrees_MouseLeave(object sender, EventArgs e)
        {
            Control? obj = sender as Control;
            if (obj != null)
            {
                obj.BackColor = Custom_functions.backColors;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(900, 550);

            // TIPS //
            tips.TopLevel = false;
            this.Controls.Add(tips);
            tips.WindowState = FormWindowState.Maximized;
            tips.MdiParent = this;

            //////////

            // ABOUT //
            aboutform.MdiParent = this;
            aboutform.WindowState = FormWindowState.Maximized;
            //////////

            // HELP //
            helpform.MdiParent = this;
            helpform.WindowState = FormWindowState.Maximized;
            //////////

            // FRACTAL TREES //
            fractaltrees.MdiParent = this;
            fractaltrees.WindowState = FormWindowState.Maximized;
            //////////
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                //Console.WriteLine(child.Name);
                child.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            if (aboutform.IsDisposed) { 
                aboutform = new();
                aboutform.MdiParent = this;
                Console.WriteLine(this.MdiChildren.Length.ToString());
            }
            aboutform.WindowState = FormWindowState.Maximized;
            aboutform.Update();
            aboutform.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (helpform.IsDisposed) { 
                helpform = new();
                aboutform.MdiParent = this;
                Console.WriteLine(this.MdiChildren.Length); 
            }

            helpform.WindowState = FormWindowState.Maximized;
            helpform.Show();
        }

        private void Arrange_Vertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void Arrange_Horizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void Arrange_Minimize_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.WindowState= FormWindowState.Minimized;
            }
        }

        private void btnTrees_Click(object sender, EventArgs e)
        {
            if (fractaltrees.IsDisposed)
            {
                fractaltrees = new();
                fractaltrees.MdiParent = this;
                Console.WriteLine(this.MdiChildren.Length);
            }
            fractaltrees.Show();
        }
    }
}
