using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Logic;

namespace Drawing
{
    public class DrawGraph
    {
        Bitmap bitmap;
        Pen blackPen;
        Pen redPen;
        Pen DarkColor;
        Graphics gr;
        Font fo;
        Brush br;
        PointF point;
        public int R = 25; //радиус окружности вершины

        public DrawGraph(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            gr = Graphics.FromImage(bitmap);
            clearSheet();
            blackPen = new Pen(Color.Black);
            blackPen.Width = 2;
            redPen = new Pen(Color.Red);
            redPen.Width = 2;
            DarkColor = new Pen(Color.Black);
            DarkColor.Width = 2;
            fo = new Font("Arial", 15);
            br = Brushes.Black;
        }

        public Bitmap GetBitmap()
        {
            return bitmap;
        }

        public void clearSheet()
        {
            gr.Clear(Color.White);
        }

        
        public void drawVertex(int x, int y, string number)
        {
            gr.FillEllipse(Brushes.SeaShell, (x - R), (y - R), 2 * R, 2 * R);
            gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
            point = new PointF(x - 9, y - 9);
            gr.DrawString(number, fo, br, point);
        }

        public void drawSelectedVertex(int x, int y)
        {
            gr.DrawEllipse(redPen, (x - R), (y - R), 2 * R, 2 * R);
        }

        public void drawEdge(Logic.Graph.Vertex V1, Logic.Graph.Vertex V2, Logic.Graph.Edge E, int numberE)
        {
            gr.DrawLine(DarkColor, V1.X, V1.Y, V2.X, V2.Y);
            point = new PointF((V1.X + V2.X) / 2, (V1.Y + V2.Y) / 2);

            drawVertex(V1.X, V1.Y, (E.V1 + 1).ToString());
            drawVertex(V2.X, V2.Y, (E.V2 + 1).ToString());
        }

        public void drawALLGraph(List<Logic.Graph.Vertex> V, List<Logic.Graph.Edge> E)
        {
            //рисуем ребра
            for (int i = 0; i < E.Count; i++)
            {

                gr.DrawLine(DarkColor, V[E[i].V1].X, V[E[i].V1].Y, V[E[i].V2].X, V[E[i].V2].Y);
                point = new PointF((V[E[i].V1].X + V[E[i].V2].X) / 2, (V[E[i].V1].Y + V[E[i].V2].Y) / 2);

            }
            //рисуем вершины
            for (int i = 0; i < V.Count; i++)
            {
                drawVertex(V[i].X, V[i].Y, (i + 1).ToString());
            }
        }
    }
}
