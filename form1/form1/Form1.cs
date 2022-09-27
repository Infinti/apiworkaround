using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Matematik matematik = new Matematik();
            int sonuctop = matematik.Topla(7 , 5);
            MessageBox.Show(sonuctop.ToString());//mbox+tab*2
            //null olarak referanslabilir nesneler, ama işlem yapılamaz, aynı zamanda var olan metodlarda görülünebilir
        }
    }
}
