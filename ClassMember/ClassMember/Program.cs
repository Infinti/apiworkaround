using System;

namespace ClassMember
{
    class Program
    {
        static void Main(string[] args)
        {
            okul o = new okul();

            
        }
    }
    class okul
    {
        #region property dersi
        //string cadi;
        //    public string Cadi
        //    {
        //        get
        //        {
        //            return cadi;
        //        }
        //        set
        //        {
        //            cadi = value;
        //        }
        //    }
        //bool bayrak;//CTRL+R+E ya da soldan bul ve seç//java get set metodu

        //public bool Bayrak { get => bayrak; set => bayrak = value; }
        //public string Cadi { get; set; } = "deneme";//ilk oluşturulurken atama yapılabilir.
        #endregion

        #region Constructor dersi
        public int x { get; set; }

        public okul()
        {
            x = 11;
        }

        #endregion
    }
}
