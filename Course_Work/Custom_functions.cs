using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using WinRT;
using Windows.Devices.Sensors;
using Windows.UI.Composition;
using System.ComponentModel;

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

        public static string file_root = "..\\..\\..\\..\\TextFiles\\";

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
        public static string[] ReadFile(string root= "..\\..\\..\\..\\TextFiles\\", string filename =  "Account.hash")
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

        public static List<Color> Get_Tree_Colors(int color_count,int alpha, Color darkest)
        {
            List<Color> colors= new List<Color>();

            double step = (255 - new[] { darkest.R, darkest.G, darkest.B }.Max()) / (color_count);

            for (int i=0;i<color_count;i++)
            {
                colors.Add(Color.FromArgb(alpha, (int)(darkest.R + step*i), (int)(darkest.G + step * i), (int)(darkest.B + step * i)));
            }

            return colors;
        }

        public static void Wait(BackgroundWorker worker)
        {
            while (worker.IsBusy)
            {
            }
        }

        public static void Cancel_Work(BackgroundWorker worker)
        {
            worker.WorkerSupportsCancellation = true;
            worker.CancelAsync();
            while (worker.IsBusy)
            {
                
            }
        }
    }
}
