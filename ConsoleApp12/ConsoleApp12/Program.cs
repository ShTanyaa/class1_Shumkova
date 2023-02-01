using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        public class cycle
        {
            public void ckl()
            {
                int square = 0;
                for (int i = 1; i <= 10; i++)
                {
                    square = i * i;
                    Console.WriteLine(i);
                    print pr = new print();
                    pr.printt(square);
                }
            }
        }

        public class print
        {
            public void printt(int arg)
            {
                if (arg > 25)
                    Console.WriteLine("Квадрат числа больше 25!");
            }
        }
        static void Main(string[] args)
        {
            cycle zic = new cycle();
            zic.ckl();
            Console.Read();
        }
    }
}
