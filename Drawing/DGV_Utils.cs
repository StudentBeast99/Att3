using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DGV_Utils
{
    public class DGV_Utils
    {
        public static void MatrixToDgv(int[,] matrix,DataGridView dgv)
        {
            dgv.RowCount = matrix.GetLength(0)+1;
            dgv.ColumnCount = matrix.GetLength(1)+1;

          for(int i=0;i< matrix.GetLength(0);i++)
            {
                dgv[0, i+1].Value = i+1;
                dgv[0, i + 1].Style.BackColor = Color.Aquamarine;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                dgv[i+1, 0].Value = i + 1;
                dgv[i + 1, 0].Style.BackColor = Color.Aquamarine;
            }

            for (int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    dgv[i+1, j+1].Value = matrix[i, j];
                }
            }
            dgv.AutoResizeColumns();

        }
    }
}
