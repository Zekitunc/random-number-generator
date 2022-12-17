using System;

namespace randomnumbergenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose RNG engine:");
            Console.WriteLine("LCG");
            Console.WriteLine("Xorshift");

            Console.WriteLine("For LCG:");
            LCG lcg1 = new LCG();
            Helperclass.Calculatepercente(lcg1);
            Console.WriteLine("--------------------");
            Console.WriteLine("For Xorshift:");
            Xorshift xor = new Xorshift();
            Helperclass.Calculatepercente(xor);
        }
    }
}
