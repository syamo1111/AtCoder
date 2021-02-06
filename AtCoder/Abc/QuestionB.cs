using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    class QuestionB
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            var N = inputLongArray[0];
            var S = inputLongArray[1];
            var D = inputLongArray[2];

            string result = "No";

            for (int i = 0; i < N; i++)
            {
                long[] spell = Console.ReadLine().Split(' ').Select(j => long.Parse(j)).ToArray();

                if(spell[0] < S && spell[1] > D)
                {
                    result = "Yes";
                    break;
                }
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
