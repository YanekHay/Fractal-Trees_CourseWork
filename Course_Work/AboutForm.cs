using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            Custom_functions.color_Form(this);
            this.BringToFront();
            timer1.Start();
        }

        private void btn_ok_MouseEnter(object sender, EventArgs e)
        {
            btn_ok.ForeColor = Custom_functions.backColors;

        }

        private void btn_ok_MouseLeave(object sender, EventArgs e)
        {
            btn_ok.ForeColor= Custom_functions.foreColors;
        }

        private float shrink_val = 0;
        private int shrink_count = -20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (shrink_count <=0)
            {
                shrink_val = -0.5f;
            }
            else if (shrink_count < 20)
            {
                shrink_val = 0.5f;
            }
            else if (shrink_count == 20)
            {
                shrink_count = -20;
            }
            shrink_count = shrink_count + 1;
            label2.Font = new Font("Segoi", label2.Font.Size + shrink_val);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Visible = false;

            Custom_functions.Arrage_children(this.MdiParent, Custom_functions.child_alignment);

        }

        private void AboutForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }


    }
}
