using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time>=6 && time<11)
                Console.WriteLine("Günaydın Saat :"+Convert.ToString(time));
            else if(time<18)
                Console.WriteLine("İyi Günler Saat " + Convert.ToString(time));
            else
                Console.WriteLine("İyi Akşamlar Saat " +Convert.ToString(time));

            string sonuc = time<18 ? "İyi günler" : "İyi Akşamlar"; // ? ifadesi öncesi koşul eğer doğru ise "?" yanındaki ilk argüman çalışır.
            //Yanlış ise ":" ifadesinin sağ tarafındaki argüman çalışır.  (Ternary If)
            string mod = time>=6 && time<11 ? "Günaydın" : time<18 ? " İyi günler" : "iyi akşamlar";
            Console.WriteLine(sonuc);
            Console.WriteLine(mod);

        }
    }
}
