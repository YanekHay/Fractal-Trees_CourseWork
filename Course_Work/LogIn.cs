using Course_Work.Resources;
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
    public partial class LogIn : Form
    {

        public LogIn()
        {
            InitializeComponent();
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string[] lp = Custom_functions.ReadFile(filename:"Account.hash");
            string login = Custom_functions.string_to_MD5(textBox1.Text);
            string password = Custom_functions.string_to_MD5(textBox2.Text);
            if (login != lp[0] || password != lp[1])
            {
                MessageBox.Show("Wrong Username or Password entered.");
                System.Windows.Forms.Application.Exit();
                
            }
            else
            {
                Custom_functions.main_form.Show();
                this.Close();
            }


        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            Custom_functions.color_Form(this);
        }
    }
}
