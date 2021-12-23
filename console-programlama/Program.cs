using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Adinizi Giriniz:");
            string name=Console.ReadLine();
            Console.WriteLine("Soyadinizi Giriniz:");
            string soyad = Console.ReadLine();

            Console.WriteLine("Merhaba "+ name + " " + soyad );

        }
    }
}
