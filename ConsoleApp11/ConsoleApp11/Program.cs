using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        public class Tel
        {
            public int day;
            public double time;
            public double price;
            public double CalculateSum()
            {
                double totalPrice = time * price;
                return day == 6 || day == 7 ? totalPrice - totalPrice * 0.1 : totalPrice;
            }
        }
        static void Main(string[] args)
        {
            try
            {
            Tel tel = new Tel();
            Console.WriteLine("vvedite day razgovora");
            tel.day = int.Parse(Console.ReadLine());
            Console.WriteLine("vvedite vrema razgovora");
            tel.time = int.Parse(Console.ReadLine()); ;
            Console.WriteLine("vvedite cost razgovora");
            tel.price = int.Parse(Console.ReadLine()); ;
            Console.WriteLine(tel.CalculateSum());

            }
            catch
            {
                Console.WriteLine("error");
            }
            

        }
    }
}
