using System;
using System.Collections.Generic;
using System.Text;

namespace randomnumbergenerator
{
    class Helperclass
    {
        public static void Calculatepercente(LCG lcg1)
        {
            double count0 = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0, count7 = 0, count8 = 0, count9 = 0;
            for (int i =0; i<100000;i++)
            {
                double number = lcg1.Next(0, 10);
                switch (number)
                {
                    case 0:
                        count0 += 1;
                        break;
                    case 1:
                        count1 += 1;
                        break;
                    case 2:
                        count2 += 1;
                        break;
                    case 3:
                        count3 += 1;
                        break;
                    case 4:
                        count4 += 1;
                        break;
                    case 5:
                        count5 += 1;
                        break;
                    case 6:
                        count6+= 1;
                        break;
                    case 7:
                        count7 += 1;
                        break;
                    case 8:
                        count8 += 1;
                        break;
                    case 9:
                        count9 += 1;
                        break;
                }
            }
            Console.Write("0:############## ");
            Console.WriteLine(percantage10k(count0)+"%");
            Console.Write("1:############## ");
            Console.WriteLine(percantage10k(count1) + "%");
            Console.Write("2:############## ");
            Console.WriteLine(percantage10k(count2) + "%");
            Console.Write("3:############## ");
            Console.WriteLine(percantage10k(count3) + "%");
            Console.Write("4:############## ");
            Console.WriteLine(percantage10k(count4) + "%");
            Console.Write("5:############## ");
            Console.WriteLine(percantage10k(count5) + "%");
            Console.Write("6:############## ");
            Console.WriteLine(percantage10k(count6) + "%");
            Console.Write("7:############## ");
            Console.WriteLine(percantage10k(count7) + "%");
            Console.Write("8:############## ");
            Console.WriteLine(percantage10k(count8) + "%");
            Console.Write("9:############## ");
            Console.WriteLine(percantage10k(count9) + "%");
        }
        public static void Calculatepercente(Xorshift xor1)
        {
            long count0 = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0, count7 = 0, count8 = 0, count9 = 0;
            for (int i = 0; i < 100000; i++)
            {
                long number = xor1.Next(0, 10);
                switch (number)
                {
                    case 0:
                        count0 += 1;
                        break;
                    case 1:
                        count1 += 1;
                        break;
                    case 2:
                        count2 += 1;
                        break;
                    case 3:
                        count3 += 1;
                        break;
                    case 4:
                        count4 += 1;
                        break;
                    case 5:
                        count5 += 1;
                        break;
                    case 6:
                        count6 += 1;
                        break;
                    case 7:
                        count7 += 1;
                        break;
                    case 8:
                        count8 += 1;
                        break;
                    case 9:
                        count9 += 1;
                        break;
                }
            }
            Console.Write("0:############## ");
            Console.WriteLine(percantage10k(count0) + "%");
            Console.Write("1:############## ");
            Console.WriteLine(percantage10k(count1) + "%");
            Console.Write("2:############## ");
            Console.WriteLine(percantage10k(count2) + "%");
            Console.Write("3:############## ");
            Console.WriteLine(percantage10k(count3) + "%");
            Console.Write("4:############## ");
            Console.WriteLine(percantage10k(count4) + "%");
            Console.Write("5:############## ");
            Console.WriteLine(percantage10k(count5) + "%");
            Console.Write("6:############## ");
            Console.WriteLine(percantage10k(count6) + "%");
            Console.Write("7:############## ");
            Console.WriteLine(percantage10k(count7) + "%");
            Console.Write("8:############## ");
            Console.WriteLine(percantage10k(count8) + "%");
            Console.Write("9:############## ");
            Console.WriteLine(percantage10k(count9) + "%");
        }
        public static double percantage10k(double number)
        {
            double percent = number * 100 / 100000;
            return percent;

        }
    }
}
