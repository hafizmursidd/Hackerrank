using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp
{
    internal class PickingNumbers
    {
        public static int RunPickingNumbers (int[] data)
        {
            int result = 0;
            for (int i = 0; i < data.Length; i++)
            {
                int resultTemp = 0;
                for (int j = 0; j < data.Length; j++) 
                { 
                    int temp = Math.Abs(data[i] - data[j]);
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
            int[] data = { 1, 1, 2, 2, 4, 4, 5, 5, 5};

            int result = RunPickingNumbers(data);

            Console.WriteLine(result);
        }
    }
}
