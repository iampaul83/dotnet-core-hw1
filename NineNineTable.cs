using System;

namespace hw1
{
    class NineNineTable
    {
        public static void V1 ()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    switch (j)
                    {
                        case 0:
                        case 10:
                            Console.WriteLine("+------------+");
                            break;
                        default:
                            Console.WriteLine(String.Format("| {0,-10} |", String.Format("{0} x {1} = {2}", i, j, i * j)));
                            break;
                    }
                }
            }
        }

        public static void V2 ()
        {
            for (int i = 1; i <= 3 ; i++)
            {
                for (int j = 0; j <= 10 ; j++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        switch (j)
                        {
                            case 0:
                            case 10:
                                if (k == 1)
                                {
                                    Console.WriteLine("+------------+ +------------+ +------------+");
                                }
                                break;
                            default:
                                int x = (i - 1) * 3 + k;
                                int y = j;
                                Console.Write(String.Format("| {0,-10} |", String.Format("{0} x {1} = {2}", x, y, String.Format("{0,2}", x * y))));
                                if (k == 3)
                                {
                                    Console.WriteLine();
                                }
                                else {
                                    Console.Write(" ");
                                }
                                break;
                        }
                    }
                }
            }
        }

        public static void V3 ()
        {
            for (int i = 1; i <= 3 ; i++)
            {
                for (int j = 0; j <= 10 ; j++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        switch (j)
                        {
                            case 0:
                            case 10:
                                if (k == 1)
                                {
                                    Console.WriteLine("+------------+ +------------+ +------------+");
                                }
                                break;
                            default:
                                int x = (k * 3) - 2 + (i - 1);
                                int y = j;
                                Console.Write(String.Format("| {0,-10} |", String.Format("{0} x {1} = {2}", x, y, String.Format("{0,2}", x * y))));
                                if (k == 3)
                                {
                                    Console.WriteLine();
                                }
                                else {
                                    Console.Write(" ");
                                }
                                break;
                        }
                    }
                }
            }
        }
    }
}