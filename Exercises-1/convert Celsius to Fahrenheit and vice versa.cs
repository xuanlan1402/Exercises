using System;
namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH DOI NHIET DO");

            Console.Write("Nhap do C: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine("{0} do C = {1:F2} do F", celsius, fahrenheit);

            Console.WriteLine("-------------------");

            Console.Write("Nhap do F: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) / 1.8;
            Console.WriteLine("{0} do F = {1:F2} do C", f, c);

            Console.WriteLine("\nNhan Enter de thoat...");
            Console.ReadLine();
        }
    }
}