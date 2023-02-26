using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp
{
    internal class AngryProfessor
    {
        //Function to Solution for the problem
        public static string RunAngryProfessor(int k, List<int> a)
        {
            int onTime = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] <= 0) onTime++;
            }
            string result = onTime < k ? "YES" : "NO";
            return result;
        }

        //Example data
        public static void Running()
        {
            var data = new List<int>();
            data.Add(-1);
            data.Add(-3);
            data.Add(4);
            data.Add(2);

            int limit = 3;

            string result = RunAngryProfessor(limit, data);
            Console.WriteLine(result);

        }
    }
}
