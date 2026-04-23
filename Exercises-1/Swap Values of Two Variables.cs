using System;
namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" CHUONG TRINH HOAN DOI GIA TRI HAI BIEN");

            Console.Write("Nhap gia tri bien a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap gia tri cho bien b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nKet qua ban dau: a = {0}, b = {1}", a, b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Sau khi hoan doi: a = {0}, b = {1}", a, b);

            Console.WriteLine("\nNhan Enter de ket thuc...");
            Console.ReadLine();
        }
    }
}