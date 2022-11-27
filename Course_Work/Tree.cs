using ABI.System.Numerics;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public List<Color> colors= new List<Color>();
        public Graphics[] graphic_list;
        public BackgroundWorker[] workers;


        //public BackgroundWorker worker = new BackgroundWorker();
        public Tree() {}
        public Tree(Branch root_branch, Graphics[] graphics, List<Color> colors, BackgroundWorker[] workers)
        {
            this.generation_indices.Add(new Point(0,1));
            this.branches.Add(root_branch);
            this.graphic_list = graphics;
            this.colors = colors;
            this.workers = workers;
        }

        public void Add_Generation(double angle, double height_factor, float width_decay=0.5f, int max_child_count=2, double randomize = 0, bool draw = true)
        {
            List<Branch> new_generation = new List<Branch>();
            int i;
            for (i = this.generation_indices.Last().X; i < this.generation_indices.Last().Y;i++)
            {
                new_generation.AddRange(this.branches[i].Get_Child_Branches(  child_num:     max_child_count,
                                                                              angle:         angle, 
                                                                              child_color:   this.colors[this.generation_indices.Count],
                                                                              height_factor: height_factor, 
                                                                              width_decay:   width_decay,
                                                                              randomize:     randomize
                                                                              ));; 

            }
            this.branches.AddRange(new_generation);
            this.generation_indices.Add(new Point(i, this.branches.Count));
            if (draw)
            {
                Draw_branches(new_generation, this.colors[this.generation_indices.Count]);
            }
        }

        public void Draw_branches(IEnumerable<Branch> branches, Color barnch_color)
        {
            if (this.branches.Count>4) { 
                int step = this.branches.Count/this.graphic_list.Length;
                int i = 0;
                for (int gr_ind=0;gr_ind<1;gr_ind++)
                {
                    //Custom_functions.Wait(this.workers[gr_ind]);
                    Console.WriteLine(gr_ind.ToString()+ "  " + this.workers[gr_ind].IsBusy.ToString());
                    this.workers[gr_ind].DoWork += (obj, e) =>
                    {
                    Draw_Branches_Async(    i,
                                            i + step,
                                            barnch_color,
                                            graphic_list[gr_ind],
                                            this.workers[gr_ind]);
                    };
                    this.workers[gr_ind].RunWorkerAsync();
                    i += step;
                }
                i = 0;
            }
            else {
                foreach (Branch branch in this.branches)
                {
                    branch.Draw(this.graphic_list[0]);
                }
            }
        }

        private void Draw_Branches_Async(int start, int end, Color barnch_color, Graphics graphic, BackgroundWorker worker)
        {
                for (int i = start; i < end; i++)
                {
                    if (worker.CancellationPending)
                    {
                        Console.WriteLine("PASSED");
                        return;
                    }
                    this.branches[i].Draw(graphic);
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
            //if (!this.worker.IsBusy) { 

            //    this.colors = generation_colors;
            //    this.graphics.Clear(back_color);
            //    this.worker.DoWork += (e, obj) => Worker_Draw_Branches(0, this.generation_indices.Count());
            //    this.worker.RunWorkerAsync();

            //}
            foreach(Graphics g in this.graphic_list)
            {
                g.Clear(back_color);

            }

            Draw_branches(this.branches, this.colors[2]);

            //for (int i = 1; i < generation_indices.Count; i++)
            //{
            //    Draw_branches(this.branches.Skip(this.generation_indices[i].X).Take(generation_indices[i].Y - generation_indices[i].X), this.colors[i]);
            //}

        }


        public void Reset()
        {
            this.Draw_Tree(Custom_functions.backColors);
            this.generation_indices = new List<Point>(this.generation_indices.Take(1));
            this.branches = new List<Branch>(this.branches.Take(1));
        }


    }
}
