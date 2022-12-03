using Course_Work.Resources;
using System.Security.Cryptography;
using System.Text;

namespace Course_Work
{
    public partial class Start_form : Form
    {

        public Point start_position;
        public Point end_position;
        public byte dir = 0;
        private int padding = 50;
        public LogIn LogIn_Form = new LogIn();
        private int total_time = 0;
        public Start_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Custom_functions.backColors;
            pic1.BackColor = Custom_functions.foreColors;
            pic1.Location = new Point(this.Width - pic1.Width - padding + 30, this.Height - pic1.Height - padding);
            start_position = pic1.Location;
            end_position = new Point(0, 0);
            _ = Custom_functions.CreateLP(login:"Admin",password:"Admin");
            timer.Start();
        }


        private int line_from_two_points(int x_any, Point start_point, Point end_point)
        {
            float k = (float)((end_point.Y - start_point.Y)) / (end_point.X - start_point.X);
            return (int)(k * (x_any - start_point.X)+ start_point.Y);
        }

        int step = 5;
        /// <summary>
        /// dir: shows the direction where the picturebox goes.
        /// Values of dir:<br></br>
        ///                 0 -> from bottom-right corner to top-left corner<br></br>
        ///                 1 -> from top-left corner to top-right corner<br></br>
        ///                 2 -> from top-right corner to bottom-right corner<br></br>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (dir == 0)
            {
                pic1.Location = new Point(pic1.Location.X - step, line_from_two_points(pic1.Location.X - step, start_position, end_position));
            }
            else if (dir == 1)
            {
                pic1.Location = new Point(pic1.Location.X + step, pic1.Location.Y);
            }
            else if (dir == 2)
            {
                pic1.Location = new Point(pic1.Location.X, pic1.Location.Y + step);
            }

            if (pic1.Location.Y == end_position.Y && pic1.Location.X < start_position.X)
            {
                dir = 1;
            }
            else if (pic1.Location.X >= start_position.X && pic1.Location.Y < start_position.Y)
            {
                dir = 2;
            }
            else if (pic1.Location.Y >= start_position.Y )
            {
                dir = 0;
            }
            if (total_time > 800)
            {
                timer.Stop();
                this.Hide();
                LogIn_Form.Show();
            }
            total_time++;
        }

    }
}