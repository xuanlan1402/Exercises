using System;
namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" CHUONG TRINH TINH DIEN TICH HINH VUONG");

            Console.Write("Nhap do dai canh hinh vuong: ");
            double canh = Convert.ToDouble(Console.ReadLine());

            double dienTich = canh * canh;

            Console.WriteLine("\nDien tich hinh vuong co canh {0} la: {1}", canh, dienTich);

            Console.WriteLine("\nNhan Enter de thoat...");
            Console.ReadLine();
        }
    }
}
