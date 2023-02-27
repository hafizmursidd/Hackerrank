using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp
{
    internal class ElectronicsShop
    {
        public static int GetMoneySpent (int[] keyboards, int[] drives, int b)
        {
            int maxBuying = 0;

            for(int i = 0; i < keyboards.Length; i++)
            {
                int temp = 0;
                for(int j = 0; j<drives.Length; j++)
                {
                    temp= keyboards[i] + drives[j];
                    if(temp<=b && temp > maxBuying)
                    {
                        maxBuying = temp;
                    }
                }
            }
            int result = (maxBuying == 0) ? -1 : maxBuying;

            return result;
        }

        public static void Runnning()
        {
            int max = 10;
            int [] keyboards = { 3, 1 };
            int[] drives = { 5, 2, 8 };

            int result = GetMoneySpent(keyboards,drives,max);

            Console.WriteLine(result);
        }
    }
}
