using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Graph
{
    public class Graph
    {
        public int[,] Matrix { get; set; }
        public List<Edge> ListE { get; set; }
        public List<Vertex> ListV { get; set; }

        public void GetLE()
        {
            Edge e = new Edge();
            ListE=e.SearchInMatrix(Matrix);
        }
        public void GetLV()
        {
            Vertex v = new Vertex();
            ListV = v.Coord(Matrix);
        }


        public List<string> catalogCycles=new List<string>();

        public string Search()
        {
            string s = "";
            int min = 99999;
            int num=-1;

            for(int i=0;i<catalogCycles.Count;i++)
            {
                if (catalogCycles[i].Length < min)
                {
                    min = catalogCycles[i].Length;
                    num = i;
                }
            }
            s += catalogCycles[num];
            return s;
        }
        public void cyclesSearch()
        {
            int[] color = new int[ListV.Count];
            for (int i = 0; i < ListV.Count; i++)
            {
                for (int k = 0; k < ListV.Count; k++)
                    color[k] = 1;
                List<int> cycle = new List<int>();
                cycle.Add(i + 1);
                DFScycle(i, i, ListE, color, i, cycle);
            }
        }

        private void DFScycle(int u, int endV, List<Edge> ListE, int[] color, int unavailableEdge, List<int> cycle)
        {
           
            if (u != endV)
                color[u] = 2;
            else if (cycle.Count >= 3)
            {
                cycle.Reverse();
                string s = cycle[0].ToString();
                for (int i = 1; i < cycle.Count; i++)
                    s += "->" + cycle[i].ToString();
                bool flag = false; 
                for (int i = 0; i < catalogCycles.Count; i++)
                    if (catalogCycles[i].ToString().Equals(s))
                    {
                        flag = true;
                        break;
                    }
                if (!flag)
                {
                    cycle.Reverse();
                    s = cycle[0].ToString();
                    for (int i = 1; i < cycle.Count; i++)
                        s += "->" + cycle[i].ToString();
                    if(s.Length > 7)
                    catalogCycles.Add(s);
                }
                return;
            }
            for (int w = 0; w < ListE.Count; w++)
            {
                if (w == unavailableEdge)
                    continue;
                if (color[ListE[w].V2] == 1 && ListE[w].V1 == u)
                {
                    List<int> cycleNEW = new List<int>(cycle);
                    cycleNEW.Add(ListE[w].V2 + 1);
                    DFScycle(ListE[w].V2, endV, ListE, color, w, cycleNEW);
                    color[ListE[w].V2] = 1;
                }
                else if (color[ListE[w].V1] == 1 && ListE[w].V2 == u)
                {
                    List<int> cycleNEW = new List<int>(cycle);
                    cycleNEW.Add(ListE[w].V1 + 1);
                    DFScycle(ListE[w].V1, endV, ListE, color, w, cycleNEW);
                    color[ListE[w].V1] = 1;
                }
            }
        }

        private void SystemOfGears(List<Vertex> V,List<Edge> E)
        {
            int[] color = new int[V.Count];
            color[0] = 1; //По часовой стрелке


        }
    }
}
