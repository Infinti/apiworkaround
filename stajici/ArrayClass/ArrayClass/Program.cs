using System;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Sayilar = new int[5];
            Sayilar[0] = 21;
            Sayilar[1] = 23;
            Sayilar[2] = 25;
            Sayilar[3] = 26;
            Sayilar[4] = 41;
            #region Özellikler
            //Console.WriteLine(Sayilar.Length);
            //Console.WriteLine(Sayilar.Rank);
            //Console.WriteLine(Sayilar.IsReadOnly);
            //Console.WriteLine(Sayilar.IsFixedSize);
            #endregion

            #region Metodlar
            //foreach (int i in Sayilar) Console.WriteLine(i);
            //Console.WriteLine("----------------");
            //Array.Clear(Sayilar, 0, Sayilar.Length);
            //foreach (int i in Sayilar) Console.WriteLine(i);

            //int[] sayilar2 = new int[3];
            //Array.Copy(Sayilar, sayilar2, 3);

            //////index of arama yapar bulamazsa -1 geri döndürür.
            //Console.WriteLine(Array.IndexOf(Sayilar,25));

            //reverse dizii ters çevirir
            //Array.Reverse(Sayilar);

            /////sort dizi elemanlarını sıralar
            //Array.Sort(Sayilar);
            #endregion



            Console.ReadKey();

        }
    }
}
