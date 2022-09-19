using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasicaArejLista1     {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNovi_Click(object sender, EventArgs e)
        {

        }
    }

    class Automobil {
        private string marka;

        public Automobil(string m) {

            marka = m;  }

        public string DajMarku() {

            return marka;   }   }
}
