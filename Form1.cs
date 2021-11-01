using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace walsnenotatki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// //////////////////////////////////////
        struct Notatnik
        {
            public string nazwa;
            public string data;
            public string priorytet;
        }
        Notatnik notatka = new Notatnik();
        /// //////////////////////////////////////
        private void dodaj_notatke_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
