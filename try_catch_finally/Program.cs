﻿using System;

namespace try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try{
                Console.WriteLine("Bir sayi giriniz : ");
                int a =Convert.ToInt32((Console.ReadLine()));
                Console.ReadLine("Girdiğiniz sayı değeri : %d ",a);
            }
            catch(Exception ex){
                Console.WriteLine("Girdiğiniz sayi değil: " + ex.ToString());
            }
            finally{
                Console.WriteLine("Program sonu");
            }
        }
    }
}
