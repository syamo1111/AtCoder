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
            long X = inputLongArray[1];

            var input = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            var resultArray = input.Where(i => i != X);


            Console.WriteLine(string.Join(" ",resultArray));
            

            Console.Out.Flush();
        }
    }
}
