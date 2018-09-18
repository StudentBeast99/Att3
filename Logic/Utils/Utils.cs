using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Utils
{
    public class Utils
    {
        public static string[] ListToArr(List<string> list)
        {
            string[] arr = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
                arr[i] = list[i].ToString();
            return arr;
        }
      
    }
}
