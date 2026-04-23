using System;
namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH DOI NGAY SANG NAM, TUAN, NGAY");

            Console.Write("Nhap tong so ngay: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());

            int years = totalDays / 365;

            int weeks = (totalDays % 365) / 7;

            int days = (totalDays % 365) % 7;

            Console.WriteLine("\nKetqua: {0} ngay = {1} nam, {2} tuan va {3} ngay", totalDays, years, weeks, days);

            Console.WriteLine("\nNhan Enter de thoat...");
            Console.ReadLine();
        }
    }
}
