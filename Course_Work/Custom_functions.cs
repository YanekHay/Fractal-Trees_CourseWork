using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using WinRT;
using Windows.Devices.Sensors;
using System.Runtime.CompilerServices;
using Windows.Gaming.Input.Custom;

namespace Course_Work
{
    internal class Custom_functions
    {
        public static Color backColors =  Color.FromArgb(255, 64,81,91);
        public static Color mouse_over_backColors = Color.FromArgb(255, 74,81,91);
        public static Color foreColors = Color.FromArgb(255, 255,240,230);
        public static Color borderColors = Color.FromArgb(255, 255, 240, 230);

        public static Color tree_darkest = Color.FromArgb(255, 32, 46, 23);
        public static Color tree_brightest = Color.FromArgb(255, 96, 138, 71);


        public const double TWO_PI = Math.PI * 2;
        public static Random rand = new Random();
        public static int padding = 20;

        public static Main main_form = new Main();

        public static string file_root = ".\\MyFiles\\";

        public static int child_alignment=1;
        /// <summary>
        /// A method for converting any string to a Hash with MD5 algorithm
        /// </summary>
        /// <param name="str">the string that needs to be converted</param>
        /// <returns></returns>
        public static string string_to_MD5(string str)
        {
            MD5 md5 = MD5.Create();

            //Converting to bytes
            byte[] s = Encoding.ASCII.GetBytes(str);
            byte[] s_hash = md5.ComputeHash(s);

            //Building a string by converting bytes to string
            StringBuilder hash_builder = new StringBuilder();
            foreach (byte b in s_hash)
            {
                hash_builder.Append(b.ToString("X2"));
            }

            return hash_builder.ToString();
        }

        /// <summary>
        /// Reading from the given file all the lines into a string array and returning those values.
        /// </summary>
        /// <param name="filename">The path of the file which will be read</param>
        /// <returns></returns>
        public static string[] ReadFile(string root= ".\\MyFiles\\", string filename =  "Account.hash")
        {
            string[] lines = System.IO.File.ReadAllLines(root + filename);
            return lines;
        }

        /// <summary>
        /// Encoding Login and Password to MD5, and writing to a text
        /// </summary>
        /// <param name="login">Login you want to convert, default: "Administrator1"</param>
        /// <param name="password">Password you want to convert, default: "AdminTest123*"</param>
        /// <param name="filename">The path of file where the data will be saved, default: "Account.hash"</param>
        /// <returns></returns>
        public static async Task CreateLP(string login = "Administrator1", string password = "AdminTest123*", string filename = "Account.hash")
        {
            login = string_to_MD5(login);
            password = string_to_MD5(password);
            await File.WriteAllTextAsync(file_root + filename, login + "\n" + password);
        }

        public static void color_Form(Form form)
        {
            form.BackColor = backColors;
            foreach(Control control in form.Controls)
            {
                control.BackColor = backColors;
                control.ForeColor = foreColors;
            }
        }

        public static double To_Radians(double degree)
        {
            return degree *  Math.PI / 180;
        }
        public static double Clean_Radians(double radian)
        {
            if (Math.Abs(radian) > TWO_PI) { 
                return radian - (Math.Floor(radian / TWO_PI) * TWO_PI);
            }
            return radian;
        }
        public static double Get_Random(double min, double max)
        {
           return rand.NextDouble() * (max - min) + min;
        }
        public static LinkedList<Branch> Concatenate(LinkedList<Branch> a, LinkedList<Branch> b)
        {
            foreach (Branch branch in b)
            {
                a.AddLast(branch);
            }

            return a;
        }

        public static List<Color> Get_Tree_Colors(int color_count, Color darkest)
        {
            List<Color> colors= new List<Color>();

            double step = (255 - new[] { darkest.R, darkest.G, darkest.B }.Max()) / (color_count);
            int alpha = darkest.A;
            for (int i=0;i<color_count;i++)
            {
                colors.Add(Color.FromArgb(alpha, (int)(darkest.R + step*i), (int)(darkest.G + step * i), (int)(darkest.B + step * i)));
            }

            return colors;
        }

        public static List<Color> Get_Tree_Colors(int color_count, Color darkest, Color brightest)
        {
            List<Color> colors = new List<Color>();

            double R_step = (brightest.R - darkest.R) / color_count;
            double G_step = (brightest.G - darkest.G) / color_count;
            double B_step = (brightest.B - darkest.B) / color_count;

            int alpha = darkest.A;
            for (int i = 0; i < color_count; i++)
            {
                colors.Add(Color.FromArgb(alpha, (int)(darkest.R + R_step * i), (int)(darkest.G + G_step * i), (int)(darkest.B + B_step * i)));
            }

            return colors;
        }


        /// <summary>
        /// A function for getting a list of open MdiChildren of given form
        /// </summary>
        /// <param name="form"></param>
        /// <returns><see cref="List{Form}"/> List of the open MdiChildren</returns>
        public static List<Form> Get_Open_Children(Form form)
        {
            List<Form> open_children = new();
            foreach (Form child in form.MdiChildren)
            {
                if (child.Visible)
                {
                    open_children.Add(child);
                }
            }
            return open_children;
        }
        public static void Arrage_children(Form form, int child_alignment)
        {
            List<Form> open_children = Get_Open_Children(form);
            if (open_children.Count == 0)
            {
                return;
            }
            switch (child_alignment)
            {
                case 0: //Close All
                    Custom_functions.child_alignment = 0;
                    foreach (Form child in open_children)
                    {
                        if (!child.IsDisposed) { 
                            child.Hide();
                        }
                    }
                    break;
                case 1: //Vertical
                    int width = (form.Width-50) / open_children.Count;
                    int left = 0;
                    Custom_functions.child_alignment = 1;
                    foreach (Form child in open_children)
                    {
                        child.WindowState = FormWindowState.Normal;
                        child.Width = width;
                        child.Height = form.Height-100;

                        child.Left = left;
                        child.Top = 0;
                        child.Show();
                        left += child.Width;
                    }
                    break;
                case 2: //Horizontal
                    int height = (form.Height-100) / open_children.Count;
                    int top = 0;
                    Custom_functions.child_alignment = 2;

                    foreach (Form child in open_children)
                    {
                        child.WindowState = FormWindowState.Normal;
                        child.Top = top;
                        child.Height = height;
                        child.Width = form.Width-50;
                        child.Left = 0;
                        child.Show();
                        top += height;
                    }
                    break;
                case 3: //Minimized
                    Custom_functions.child_alignment = 2;

                    foreach (Form child in open_children)
                    {
                        child.WindowState = FormWindowState.Minimized;
                    }
                    break;

            }
        }
    }
}
