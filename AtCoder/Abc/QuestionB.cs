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

            // 文字列配列の入力
            string[] inputStrArray = Console.ReadLine().Split(' ');


            string result = "";

            var hantei = Math.Sqrt(int.Parse(inputStrArray[0] + inputStrArray[1]));

            if (hantei == (int)hantei)
            {
                result = "Yes";
            }
            else
            {
                result = "No";
            }
            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
