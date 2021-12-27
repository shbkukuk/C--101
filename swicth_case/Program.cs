using System;

namespace swicth_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Kış ayındasınız");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("bahar SEn hoşgeldin");
                    break;
                case 6 :
                case 7 :
                case 8 :
                    Console.WriteLine("YAZIN GÜNEŞİ ALNIMA VURDU");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("SONbahar mısın Yoksa ilk AÇan mı ");
                    break;
                default:
                    break;
            }
        }
    }
}
