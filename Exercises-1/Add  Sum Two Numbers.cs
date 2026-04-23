using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("CHUONG TRINH CONG HAI SO");
        Console.Write("nhap so thu nhat: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("nhap so thu hai: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double tong = a + b;

        Console.WriteLine("Ket qua: " + a + " + " + b + " = " + tong);

        Console.WriteLine(" Nhan Enter de thoat...");
        Console.ReadLine();
    }
}