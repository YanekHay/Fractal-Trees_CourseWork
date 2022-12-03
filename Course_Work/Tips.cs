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
    public partial class Tips : Form
    {
        public Tips()
        {
            InitializeComponent();
            TipsBox.ReadOnly = true;
        }

        private string[] all_tips;
        private int tip_index = 0;
        private void Tips_Load(object sender, EventArgs e)
        {
            Custom_functions.color_Form(this);
            this.Size = this.MdiParent.Size;

            all_tips = Custom_functions.ReadFile(root: Custom_functions.file_root ,filename: "Tips.txt");
            TipsBox.Text = all_tips[tip_index] + "\n" + all_tips[tip_index+1];
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Custom_functions.Arrage_children(this.MdiParent, Custom_functions.child_alignment);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            tip_index = (tip_index + 2) % all_tips.Length;
            TipsBox.Text = all_tips[tip_index] + "\n" + all_tips[tip_index+1];
        }


        public void set_control_sizes()
        {
            TipsBox.Width = TipsBox.Height;
        }

        private void Tips_Resize(object sender, EventArgs e)
        {
            TipsBox.Width = this.Width/2;
            TipsBox.Height = TipsBox.Width;
            TipsBox.Dock = DockStyle.Left;
            btn_ok.Left = TipsBox.Left + TipsBox.Width + Custom_functions.padding;
            btn_ok.Top = TipsBox.Top;

            btn_next.Left = btn_ok.Left;
            btn_next.Top = btn_ok.Top + btn_ok.Height + Custom_functions.padding;
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
