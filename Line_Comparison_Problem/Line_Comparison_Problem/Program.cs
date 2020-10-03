using System;

namespace LCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to LCP");
            Console.WriteLine("Enter the coordiates");

            double x1, y1, x2, y2, length_1;

            Console.WriteLine("enter x1 ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter y1 ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter x2 ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter y2 ");
            y2 = Convert.ToDouble(Console.ReadLine());

            double m1, m2, n1, n2, length_2;

            Console.WriteLine("enter m1 ");
            m1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter n1 ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter m2 ");
            m2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter n2 ");
            n2 = Convert.ToDouble(Console.ReadLine());

            length_1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            //Console.WriteLine("Legth of Line is:" + length1);

            length_2 = Math.Sqrt(((m2 - m1) * (m2 - m1)) + ((n2 - n1) * (n2 - n1)));

            if (length_1 == length_2)
            {
                Console.WriteLine("Lines are of equal length");
            }
        }
    }
}