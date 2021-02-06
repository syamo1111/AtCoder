using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc086/tasks/abc086_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            var hantei = inputLongArray[0] * inputLongArray[1];



            string result = "";

            if (hantei % 2 == 0)
            {
                result = "Even";
            }
            else
            {
                result = "Odd";
            }

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
