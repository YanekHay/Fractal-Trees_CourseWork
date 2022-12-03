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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private string help_filename = "Help.txt";

        private void btn_ok_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Visible=false;
            Custom_functions.Arrage_children(this.MdiParent, Custom_functions.child_alignment);

        }

        private string[] help_file;
        private int st_ind=0, line_count;
        private short dir = 1;
        private void HelpForm_Load(object sender, EventArgs e)
        {
            Custom_functions.color_Form(this);
            help_file = Custom_functions.ReadFile(root: Custom_functions.file_root, filename: help_filename);

            btn_text.Height = this.MdiParent.Height / 2;
            line_count = btn_text.Height / 27;
            foreach (string line in help_file[..line_count])
            {
                btn_text.Text = btn_text.Text + line.Replace("\t", "              ") + "\n";
            }
            timer1.Start();
        }
        private void btn_text_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void btn_text_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private int passed_time = 0;

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void HelpForm_Resize(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (passed_time>5) {
                st_ind = (st_ind + dir) % (help_file.Length - line_count);
                if (st_ind + line_count == help_file.Length-1)
                {
                    dir = -1;
                    passed_time = 0;
                }
                else if (st_ind==0)
                {
                    dir = 1;
                    passed_time = 0;
                }

            }
            passed_time++;
            
            btn_text.Text = "";
            foreach (string line in help_file[st_ind..(st_ind+line_count)])
            {
                btn_text.Text = btn_text.Text + line.Replace("\t", "              ") + "\n";
            }
        }
    }
}
