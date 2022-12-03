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
        private Sure sureform = new();
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tips.IsDisposed) {
                tips = new();
                tips.MdiParent = this;
            }
            tips.WindowState = FormWindowState.Maximized;
            tips.BringToFront();
            tips.Show();

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
            Custom_functions.color_Form(this);

            this.MinimumSize = new Size(900, 550);

            // TIPS //
            tips.MdiParent = this;
            tips.WindowState = FormWindowState.Maximized;
            //////////

            // ABOUT //
            aboutform.MdiParent = this;
            aboutform.WindowState = FormWindowState.Maximized;
            //////////

            // HELP //
            helpform.MdiParent = this;
            helpform.WindowState = FormWindowState.Maximized;
            //////////

        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            Custom_functions.Arrage_children(this, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (sureform.IsDisposed)
            {
                sureform = new();
            }

            sureform.Show();

        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            if (aboutform.IsDisposed) { 
                aboutform = new();
                aboutform.MdiParent = this;
            }
            aboutform.WindowState = FormWindowState.Maximized;
            aboutform.Update();
            aboutform.BringToFront();
            aboutform.Show();

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (helpform.IsDisposed) { 
                helpform = new();
                helpform.MdiParent = this;
            }

            helpform.WindowState = FormWindowState.Maximized;
            helpform.BringToFront();
            helpform.Show();
        }

        private void Arrange_Vertical_Click(object sender, EventArgs e)
        {
            Custom_functions.Arrage_children(this,1);
        }

        private void Arrange_Horizontal_Click(object sender, EventArgs e)
        {
            Custom_functions.Arrage_children(this,2);
        }

        private void Arrange_Minimize_Click(object sender, EventArgs e)
        {
            Custom_functions.Arrage_children(this, 3);
        }


        private void btnTrees_Click(object sender, EventArgs e)
        {
            if (fractaltrees.IsDisposed)
            {
                fractaltrees = new();
            }
            fractaltrees.Show();

            this.Close();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            Custom_functions.Arrage_children(this, Custom_functions.child_alignment);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!fractaltrees.Visible) { 
                Application.Exit();
            }
        }

        private void btnArange_Click(object sender, EventArgs e)
        {

        }
    }
}
