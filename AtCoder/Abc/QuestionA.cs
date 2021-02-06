using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc141/tasks/abc141_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            string result = "";

            var A = inputLongArray[0];
            var B = inputLongArray[1];
            var C = inputLongArray[2];


            if (A > B - C)
            {
                result = "Takahashi";
            }
            else
            {
                result = "Aoki";
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
