using ABI.System.Numerics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.StartScreen;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Course_Work
{
    public class Tree
    {
        // The starting and ending indices for each generation: [(0,1), (2,10), (10,20), ...,]
        public List<Point>generation_indices = new List<Point>();

        // The branches of the Tree
        public List<Branch> branches = new List<Branch>();
        public Graphics graphics;
        public List<Color> colors= new List<Color>();
        public BackgroundWorker worker = new BackgroundWorker();
        public Tree() {}
        public Tree(Branch root_branch, Graphics graphics, List<Color> colors)
        {
            this.generation_indices.Add(new Point(0,1));
            this.branches.Add(root_branch);
            this.graphics = graphics;
            this.colors = colors;

        }

        public void Add_Generation(double angle, double height_factor, float width_decay=0.5f, int max_child_count=2, double randomize = 0, bool draw = true)
        {
            List<Branch> new_generation = new List<Branch>();
            int i;
            for (i = this.generation_indices.Last().X; i < this.generation_indices.Last().Y;i++)
            {
                new_generation.AddRange(this.branches[i].Get_Child_Branches(child_num:   max_child_count,
                                                                          angle:         angle,
                                                                          height_factor: height_factor, 
                                                                          width_decay:   width_decay,
                                                                          randomize:     randomize
                                                                          )); 

            }
            this.branches.AddRange(new_generation);
            this.generation_indices.Add(new Point(i, this.branches.Count));
            if (draw)
            {
                Draw_branches(new_generation, this.colors[this.generation_indices.Count]);
            }
        }
        public void Draw_branches(IEnumerable<Branch> branches, Color branch_color)
        {
            foreach(Branch branch in branches)
            {
                Pen pen = new Pen(branch_color, branch.width);
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Bevel;
                branch.Draw(this.graphics, pen);
                if (this.worker.CancellationPending)
                {
                    return;
                }
            }
        }
        public void Change_Angle_To(double angle)
        {
            if (this.generation_indices.Count > 1)
            {
                int l = this.generation_indices[1].Y - this.generation_indices[1].X;          
                for (int i = 1; i <= l; i++)
                {
                    this.branches[i].Set_New_Angle(Custom_functions.To_Radians(angle));
                }
            }
        }

        public void Draw_Tree(Color back_color)
        {
            for (int i = 0; i < generation_indices.Count; i++)
            {
                Draw_branches(this.branches.Skip(this.generation_indices[i].X).Take(generation_indices[i].Y - generation_indices[i].X), this.colors[i]);
            }
        }


        public void Reset()
        {
            this.generation_indices = new List<Point>(this.generation_indices.Take(1));
            this.branches = new List<Branch>(this.branches.Take(1));
        }
    }
}
