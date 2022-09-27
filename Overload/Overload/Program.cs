using System;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik m = new Matematik();
            m.topla();
        }
    }
    class Matematik
    {
        //metd isimleri aynı lmalı
        //parametre sayıları farklı olmalıdır. veya parametre tipleri farklı olmalı veya parametre sıraları farklı olmalıdır.
        public double topla()
        {
            return 99 + 1;
        }
        public double topla(int a, double c)
        {
            return a + c;
        }
        public double topla(int a, double c, double y)
        {
            return a + c+y;
        }
    }
}
