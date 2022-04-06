using System;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drug drug1 = new Drug();
            Console.WriteLine("Zehmet olmasa dermanin adini daxil edin:");
            drug1.Name = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa dermanin sayini daxil edin:");
            drug1.Count = int.Parse(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa dermanin qiymetini daxil edin:");
            drug1.Price = int.Parse(Console.ReadLine());


            Drug drug2 = new Drug();
            Console.WriteLine("Zehmet olmasa dermanin adini daxil edin:");
            drug2.Name = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa dermanin qiymetini daxil edin:");
            drug2.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa dermanin sayini daxil edin: ");
            drug2.Count = int.Parse(Console.ReadLine());

            

        }
    }
}
