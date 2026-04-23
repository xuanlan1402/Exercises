using System;
namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH TINH DIEN TICH HINH TRON");

            Console.Write("Nhap ban kinh hinh tron (r): ");
            double r = Convert.ToDouble(Console.ReadLine());

            double dienTich = Math.PI * r * r;

            Console.WriteLine("\nDien tich hinh tron co ban kinh {0} la: {1:F2}", r, dienTich);

            Console.WriteLine("\nNhan Enter de thoat...");
            Console.ReadLine();
        }
    }
}