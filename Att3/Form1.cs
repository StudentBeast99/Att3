using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Drawing;

namespace Att3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        Logic.Graph.Graph graph=new Logic.Graph.Graph();
        int[,] matr;

        private void InpMatrix_But_Click(object sender, EventArgs e)
        {
            cycle_Box.Clear();
            textBox1.Clear();
            graph.catalogCycles.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Logic.Utils.FileUtils f = new Logic.Utils.FileUtils();
                matr = f.ReadFrom(openFileDialog1.FileName);
                DGV_Utils.DGV_Utils.MatrixToDgv(matr, DGV_Matrix);
            }
            
        }

        private void Draw_Graph_But_Click(object sender, EventArgs e)
        {
            graph.Matrix = matr;

            graph.GetLE();
            graph.GetLV();

            Drawing.DrawGraph drawing = new Drawing.DrawGraph(pictureBox1.Width, pictureBox1.Height);
            drawing.drawALLGraph(graph.ListV, graph.ListE);
            pictureBox1.Image = drawing.GetBitmap();
            cycle_Box.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graph.cyclesSearch();
            cycle_Box.Lines = Logic.Utils.Utils.ListToArr(graph.catalogCycles);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = graph.Search();
        }
    }
}
