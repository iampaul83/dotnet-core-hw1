using System;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            var isFirst = true;
            while (true)
            {
                if (!isFirst)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
                isFirst = false;

                Console.Write("請輸入題號(1-3), 或者(q)結束程式: ");
                var input = Console.ReadLine();
                var exit = false;
                switch (input)
                {
                    case "1":
                        subject1();
                        break;
                    case "2":
                        subject2();
                        break;
                    case "3":
                        subject3();
                        break;
                    case "q":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("未知參數");
                        break;
                }
                if (exit)
                {
                    break;
                }
            }
        }

        private static void subject1 ()
        {
            while (true)
            {
                Console.Write("1) 計算 1 + 2 + ... + n 的合, n = ");
                var input = Console.ReadLine();
                int inputNumber;
                try
                {
                    inputNumber = Int32.Parse(input);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("請入數正整數");
                    continue;
                }
                
                Console.WriteLine(MathUtil.AddFromOneTo(inputNumber));

                Console.WriteLine();
                Console.WriteLine("輸入 (r) 繼續這一題，任意鍵回到主選單...");
                var key = Console.ReadKey(true);
                if (key.KeyChar.Equals('r') == false)
                {
                    break;
                }
            }
        }

        private static void subject2 ()
        {
            while (true)
            {
                Console.Write("2) 判斷 n 是否為質數, n = ");
                var input = Console.ReadLine();
                int n;
                try
                {
                    n = Int32.Parse(input);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("請入數正整數");
                    continue;
                }

                Console.WriteLine(MathUtil.IsPrime(n) ? "是" : "不是");

                Console.WriteLine();
                Console.WriteLine("輸入 (r) 繼續這一題，任意鍵回到主選單...");
                var key = Console.ReadKey(true);
                if (key.KeyChar.Equals('r') == false)
                {
                    break;
                }
            }
        }

        private static void subject3 ()
        {
            while (true)
            {
                Console.Write("3) 印出99乘法表, 請輸入格式(1-3), 或者(q)回到主選單: ");
                var input = Console.ReadLine();
                var exit = false;
                switch (input)
                {
                    case "1":
                        NineNineTable.V1();
                        break;
                    case "2":
                        NineNineTable.V2();
                        break;
                    case "3":
                        NineNineTable.V3();
                        break;
                    case "q":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("未知參數");
                        break;
                }
                if (exit)
                {
                    break;
                }
            }
        }

    }
}
