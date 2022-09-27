using System;

namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try//runtime hataları yazılır
            {
                Console.WriteLine("Sayı giriniz...");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi+"girildi....---");
            }
            catch //hata durumunda çalışır..
            {
                Console.WriteLine("yanlış veri girişi!!!");
                
            }
            ///birden fazla catch yapılabilir.
            Console.Read();
        }
    }
}
