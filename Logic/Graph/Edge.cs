using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Graph
{
    public class Edge
    {
        public int V1 { get; set; }
        public int V2 { get; set; }

        public Edge(int v1,int v2)
        {
            this.V1 = v1;
            this.V2 = v2;
        }

        public Edge()
        {
           
        }
       
        public List<Edge> SearchInMatrix(int[,] Matrix)
        {
            List<Edge> l = new List<Edge>();
            
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                for (int j = i; j < Matrix.GetLength(0); j++)
                    if (Matrix[j,i] == 1)
                    {
                        Edge edge = new Edge(i, j);
                        
                        l.Add(edge);
                    }
            }
            return l;
        }
    }
}
