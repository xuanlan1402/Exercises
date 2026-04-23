using System;
using Microsoft.Win32.SafeHandles;
namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CHUONG TRINH KIEM TRA KICH THUOC KIEU DU LIEU");
            Console.WriteLine("{0,-15} {1,-10}", "kieu du lieu", "Kich thuoc (Bytes)");
            Console.WriteLine("-----------------");

            Console.WriteLine("{0,-15} {1,-10}", "int", sizeof(int));
            Console.WriteLine("{0,-15} {1,-10}", "float", sizeof(float));
            Console.WriteLine("{0,-15} {1,-10}", "double", sizeof(double));
            Console.WriteLine("{0,-15} {1,-10}", "char", sizeof(char));
            Console.WriteLine("{0,-15} {1,-10}", "bool", sizeof(bool));
            Console.WriteLine("{0,-15} {1,-10}", "long", sizeof(long));

            Console.WriteLine("\nNhan Enter de thoat...");
            Console.ReadLine();
        }
    }
}
