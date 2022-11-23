﻿using System;
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
            all_tips = Custom_functions.ReadFile(root: Custom_functions.file_root ,filename: "Tips.txt");
            TipsBox.Text = all_tips[tip_index] + "\n" + all_tips[tip_index+1];
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            tip_index = (tip_index + 2) % all_tips.Length;
            TipsBox.Text = all_tips[tip_index] + "\n" + all_tips[tip_index+1];
        }


        public void set_control_sizes()
        {
            this.MinimumSize = new Size(800,450);
            TipsBox.Width = TipsBox.Height;
        }

        private void Tips_Resize(object sender, EventArgs e)
        {
            TipsBox.Dock = DockStyle.Left;
            btn_ok.Left = TipsBox.Left + TipsBox.Width + Custom_functions.padding;
            btn_ok.Top = TipsBox.Top;

            btn_next.Left = btn_ok.Left;
            btn_next.Top = btn_ok.Top + btn_ok.Height + Custom_functions.padding;

        }
    }
}
