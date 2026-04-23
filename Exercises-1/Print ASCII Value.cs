using System;
namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH IN MA ASCII");

            Console.Write("Nhap mot ky tu bat ky: ");
            char kyTu = Console.ReadKey().KeyChar;

            Console.WriteLine();

            int maAscii = (int)kyTu;

            Console.WriteLine("Ky tu '{0}' co ma ASCII la: {1}", kyTu, maAscii);

            Console.WriteLine("\nNhan Enter de thoat...");
            Console.ReadLine();
        }

    }
   
}
