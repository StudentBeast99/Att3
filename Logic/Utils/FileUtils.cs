using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logic.Utils
{
   public class FileUtils
    {
        public string Input_File { get; set; }
        public string[] Text { get; set; }

        public int[,] ReadFrom(string FileName)
        {         
            string[] lines = File.ReadAllLines(FileName);
            int rowCount = lines.Length;
            if (rowCount == 0)
                return null;
            int colCount = lines[0].Split().Length;
            if (colCount == 0)
                return null;
            int[,] array = new int[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                string[] line = lines[i].Split();
                for (int j = 0; j < colCount; j++)
                {
                    array[i, j] = int.Parse(line[j]);
                }
            }
            return array;
        }
    }
}
