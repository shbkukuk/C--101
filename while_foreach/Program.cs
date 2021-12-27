using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            while (sayac <= 5)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            
            int[] sayiDizisi = {2,4,5,1,2,4};
            int toplam = 0 ;
            
            foreach(int i in SayiDizisi)
            {
                toplam += i ;
            }
        }
    }
}
