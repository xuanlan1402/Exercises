using System;
namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH DOI TU FEET SANG MET");

            Console.Write("Nhap sia tri Feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());

            double meter = feet * 0.3048;

            Console.WriteLine("\nKet qua: {0} feet = {1} meters", feet, meter.ToString("F4"));

            Console.WriteLine("\nNhan Enter de thoat...");
            Console.ReadLine();
        }
    }
}
