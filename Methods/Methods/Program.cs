using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Read();
            int sonuc=Topla(22, 32);
        }

        public void Met1()
        {
            Console.WriteLine("geri dönüş felan yok");
        }
        public void Met2(bool x,int y, string ce)
        {
            Console.WriteLine("geri dönüş yko ama parametre alır");
        }
        public string Met3()
        {
            return "geri dönüş varrr, parametre almıyoo";
        }
        public double Met4(double x, int y, string ce)
        {
            double aa = 0;
            return aa=(x+y+Convert.ToInt32(ce));//geri dönüş varrr, parametre alıyoo
        }
        #region Kullanımları
        static public int Topla(int say1,int say2)
        {
            double x = bol(42, 3);
            return say1 + say2;
        }
        static public double bol(double say1, double say2)
        {
            return say1 / say2;
        }
        #endregion

    }
}
