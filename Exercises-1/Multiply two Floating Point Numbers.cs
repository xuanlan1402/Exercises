using System;
namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" CHUONG TRINH NHAN HAI SO THUC");

            Console.Write("Nhap so thu nhat (vi du 5,5): ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap so thu hai (vi dụ 2,0): ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 * num2;

            Console.WriteLine("\nKet qua: {0} x {1} = {2}", num1, num2, result.ToString("F2"));

            Console.WriteLine("\nNhan Enter de thoat...");
            Console.ReadLine();
        }
    }
}