using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Course_Work
{
    public class Branch
    {
        public Point pt1, pt2;

        public double dir;
        public float width;
        public double angle_shift;
        public double angle_shift_factor;
        public double height_shift;
        public bool visible;
        public int length;
        public Branch parent;
        public List<Branch> children;
        public Branch(int x1, int y1, int x2, int y2, float width = 10f, bool visible = false, double angle_shift = 0, double angle_shift_factor = 0, double height_shift=0)
        {
            this.pt1 = new Point(x1, y1);
            this.pt2 = new Point(x2, y2);
            // Computing the direction of branch with it's points
            this.Update_Dir();
            this.width = width;
            this.visible = visible;
            this.parent = null;
            this.children = new List<Branch>();
            this.angle_shift = angle_shift;
            this.angle_shift_factor = angle_shift_factor;
            this.height_shift = height_shift;
            this.length = this.Len();
        }
        public Branch(Point pt1, Point pt2, float width = 10f, bool visible = false, double angle_shift = 0, double angle_shift_factor=0, double height_shift = 0)
        {
            this.pt1 = pt1;
            this.pt2 = pt2;
            this.dir = -Math.Atan2(pt2.Y-pt1.Y,pt2.X-pt1.X);
            this.width = width;
            this.visible = visible;
            this.parent = null;
            this.children = new List<Branch>();
            this.angle_shift = angle_shift;
            this.angle_shift_factor = angle_shift_factor; 
            this.height_shift = height_shift;
            this.length = this.Len();

        }
        public Branch(Branch parent, Point pt2, float width = 10f, bool visible = false, double angle_shift = 0, double angle_shift_factor = 0, double height_shift = 0)
        {
            this.pt1 = parent.pt2;
            this.pt2 = pt2;
            this.dir = -Math.Atan2(pt2.Y - pt1.Y, pt2.X - pt1.X);
            this.width = width;
            this.visible = visible;
            this.parent = parent;
            this.children = new List<Branch>();
            this.angle_shift = angle_shift;
            this.angle_shift_factor = angle_shift_factor;
            this.height_shift = height_shift;
            this.length = this.Len();
        }

        public Branch(Point pt1, double dir, int length, float width=10f, bool visible = false, double angle_shift=0, double angle_shift_factor = 0, double height_shift = 0)
        {
            this.pt1 = pt1;
            this.length = length;
            this.dir = dir;
            this.width = width;
            this.visible = visible;
            this.angle_shift=angle_shift;
            this.angle_shift_factor=angle_shift_factor;
            this.height_shift = height_shift;

            this.pt2.X = (int)(this.pt1.X + this.length * Math.Cos(this.dir));
            this.pt2.Y = (int)(this.pt1.Y + this.length * Math.Sin(this.dir));
        }
        
        /// <summary>
        /// A function for drawing a line
        /// </summary>
        /// <param name="g"> The graphics where the line needs to be drawn</param>
        /// <param name="pen">The <see cref="Pen"/> with which the line will be drawn</param>
        public void Draw(Graphics g, Pen pen)
        {
           g.DrawLine(pen, this.pt1, this.pt2);
           this.visible = true;
        }

        /// <summary>
        /// A function for getting the two child branches of the <see cref="Branch"/>
        /// </summary>
        /// <param name="angle"> The angle at which the child branches should be</param>
        /// <param name="height_factor">The scale at which the child branches will be smaller from their parent</param>
        /// <param name="angle_jiggle">The randomness of the angles of children branches</param>
        /// <param name="height_jiggle">The randomness of the heights of children branches</param>
        /// <returns><see cref="Branch"/> [Left <see cref="Branch"/>, Right <see cref="Branch"/>]</returns>
        public List<Branch> Get_Child_Branches(int child_num, double angle, double height_factor, float width_decay = 0.4f, double angle_jiggle = 0.2, double height_jiggle = 0.1, bool randomize=true)
        {
            angle = -angle;
            double rnd = Custom_functions.Get_Random(-0.1, 0.1);
            if (!randomize)
            {
                width_decay = 0.2f;
                angle_jiggle = 0;
                height_jiggle = 0;
                rnd = 0;
            }
            List<Branch> new_children = new List<Branch> ();
            int ch_n = child_num;
            if (ch_n > 1)
            {
                ch_n -= 1;
            }
            double angle_step = (-Math.PI-angle*2) / ch_n + rnd;
            for (int i = 0; i < child_num; i++)
            {
                new_children.Add(Get_Child_Branch(angle, angle_step*i, height_factor, width_decay, angle_jiggle, height_jiggle));
                new_children.Last().angle_shift_factor = (double)i / ch_n;
            }

            return new_children;
        }

        public Branch Get_Child_Branch(double angle, double angle_shift, double height_factor, float width_decay = 0.4f, double angle_jiggle = 0.2, double height_jiggle = 0.1)
        {
            double angle_rand =  Custom_functions.Get_Random(angle + angle_shift - angle_jiggle/3, angle + angle_shift + angle_jiggle/3);
            double height_rand = Custom_functions.Get_Random(height_factor - height_jiggle/3, height_factor + height_jiggle/3);
            float width_rand = this.width;
            if (this.width>1f)
            {
                width_rand -= width_decay ;
            }
            //Branch child = this.Flipped().Rotate_Rescale(angle_rand, height_rand);
            Branch child = new Branch(this.pt2, angle_rand,(int)(this.length*height_shift), width_rand,true,angle_rand-angle,0,height_rand);
            child.parent = this;
            //child.width = width_rand;
            //child.angle_shift= angle_rand-angle;
            //child.height_shift= height_rand;

            this.children.Add(child);
            return child;
        }
        /// <summary>
        /// <b>Rotating</b> and <b>Rescaling</b> the branch. The <b>anchor point</b> of rotation is its starting point.
        /// </summary>
        /// <param name="angle"> The angle of rotation in Radians </param>
        /// <param name="scale"> The scale by which the original size will be multiplied</param>
        /// <param name="inplace">If <code>inplace==True</code> the values of the branch are changed, otherwise a new copy of branch is created and then the copy is transformed </param>
        /// <returns>The rescaled and rotated branch</returns>
        public Branch Rotate_Rescale(double angle=0, double scale=1, bool inplace=false)
        {
            if (!inplace)
            {
                Branch copy = (Branch)this.MemberwiseClone();
                double l = copy.length * scale;
                copy.dir = Custom_functions.Clean_Radians(copy.dir + angle);
                copy.pt2.X = (int)(copy.pt1.X + l * Math.Cos(copy.dir));
                copy.pt2.Y = (int)(copy.pt1.Y + l * Math.Sin(copy.dir));

                return copy;
            }
            else
            {
                double l = this.length * scale;
                this.dir = Custom_functions.Clean_Radians((this.dir + angle));
                this.pt2.X = (int)(this.pt1.X + l *  Math.Cos(this.dir));
                this.pt2.Y = (int)(this.pt1.Y + l *  Math.Sin(this.dir));
                return this;
            }
            
        }
        
        /// <summary>
        /// A method for getting the Length of the branch
        /// </summary>
        /// <returns><see cref="double"/> (Length of the <see cref="Branch"/>)</returns>
        public int Len()
        {
            return (int)Math.Sqrt(Math.Pow(this.pt2.X - this.pt1.X, 2) + Math.Pow(this.pt2.Y - this.pt1.Y, 2));
        }

        /// <summary>
        /// A function for swapping the starting and the end points of the <see cref="Branch"/>
        /// </summary>
        /// <returns><see cref="Branch"/>(<see cref="Point"/> pt1, <see cref="Point"/> pt2, <see cref="double"/> dir)</returns>
        public Branch Flipped()
        {
            Branch res = new Branch(this.pt2, this.pt1);
            res.dir = 0;
            return res;
        }

        /// <summary>
        /// Show the line parameters in human readable form
        /// </summary>
        /// <returns><see cref="string"/> ({x1,y1},{x2,y2},{dir})</returns>
        override public string ToString()
        {
            return string.Format("({0},{1},{2:f})", this.pt1.ToString(), this.pt2.ToString(), this.dir);
        }

        public void Update_Branch(Point new_pt1, Point new_pt2)
        {
            this.pt1 = new_pt1;
            this.pt2 = new_pt2;
            this.visible = false;
            this.Update_Dir();
        }
        
        public void Update_Dir()
        {
            this.dir = -Math.Atan2(this.pt2.Y - this.pt1.Y, this.pt2.X - this.pt1.X);
        }

        public void Update_Children()
        {
            foreach(Branch child in this.children)
            {
                child.pt2.X -= (child.pt1.X - this.pt2.X);
                child.pt2.Y -= (child.pt1.Y - this.pt2.Y);

                child.pt1 = this.pt2;
                //child.Update_Dir();   
            }
        }

        public void Translate(Point point)
        {
            this.pt2.X = this.pt2.X + point.X - this.pt1.X ;
            this.pt2.X = this.pt2.Y + point.Y - this.pt1.Y ;

            this.pt1 = point;

        }
        public void Set_New_Angle(double new_angle)
        {
            //if (this.angle_shift_factor < 0.5)
            //{
            //    this.angle_shift = this.angle_shift + (new_angle - this.dir) * this.angle_shift_factor;
            //}
            //else if (this.angle_shift_factor > 0.5)
            //{
            //    this.angle_shift = this.angle_shift - (new_angle - this.dir) * this.angle_shift_factor;
            //}
            this.dir = new_angle + this.angle_shift;// + (new_angle - this.dir)*2 * this.angle_shift_factor;
            this.pt2.X = (int)(this.pt1.X + this.length * Math.Cos(this.dir));
            this.pt2.Y = (int)(this.pt1.Y + this.length * Math.Sin(this.dir));
            foreach(Branch child in this.children)
            {
                child.Translate(this.pt2);
                child.Set_New_Angle(new_angle+this.angle_shift);
            }
        }
    }
}
