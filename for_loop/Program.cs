using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrana girilen sayıya kadar olan tek sayıları yazdır.
            Console.WriteLine("Sayi giriniz: ");
            int sayi =int.Parse(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                if(i%2 == 1 )
                    Console.WriteLine($"{i} Tek Sayidir.");
            }
            int tektoplam = 0;
            int cifttoplam = 0;
            for (int i = 0; i < 1000; i++)
            {
                if(i%2==1)
                    tektoplam += i ;//tek sayıların toplamı
                else
                    cifttoplam += i ;//çift sayıların toplamı
            }
            Console.WriteLine($"TEk sayıların Toplamı : {tektoplam} \n Çift sayıların Toplamı: {cifttoplam}");
        }

    }
}
