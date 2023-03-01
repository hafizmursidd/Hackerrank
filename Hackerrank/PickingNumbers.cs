using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp
{
    internal class PickingNumbers
    {
        public static int RunPickingNumbers (int[] a)
        {
            var aa= new List<int>();
            aa.Sort();
            Array.Sort(a);

            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int resultTemp = 1;
                for (int j = i; j < a.Length; j++) 
                { 
                    int temp = Math.Abs(a[i] - a[j]);
                    if (i == j) continue;
                    else if (temp == 1 || temp == 0)
                    {
                        resultTemp++;
                    }
                    else continue;
                }
                if (resultTemp > result)
                {
                    result = resultTemp;
                }
            }
            return (result);
            
        }

        public static void Running()
        {
            int[] data = { 1, 2, 2, 3, 1, 2};

            int result = RunPickingNumbers(data);

            Console.WriteLine(result);
        }
    }
}
