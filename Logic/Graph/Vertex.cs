using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Graph
{
    public class Vertex
    {
        public int X { get; set; }
        public int Y { get; set; }
       
        

        public Vertex(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public Vertex()
        {
            
        }

        public List<Vertex> Coord(int[,] Matrix)
        {
            int stepx= 75;

            List<Vertex> list = new List<Vertex>();
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                
                if (i%3==0)
                {
                    Vertex v = new Vertex(50+stepx*i , 300 );
                    list.Add(v);
                }
                else if(i%3==1)
                {
                    if (i != 4)
                    {
                        Vertex v = new Vertex(250 + stepx * i, 30);
                        list.Add(v);
                    }
                    else
                    {
                        Vertex v = new Vertex(250 + stepx * i, 100);
                        list.Add(v);
                    }
                        
                }
                else if (i % 3 == 2)
                {
                    if (i == 5)
                    {
                        Vertex v = new Vertex(250 + stepx * i, 630);
                        list.Add(v);
                    }
                    else
                    {
                        Vertex v = new Vertex(250 + stepx * i, 700);
                        list.Add(v);
                    }
                }

            }
            return list;
        }

    }
}
