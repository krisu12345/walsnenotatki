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
            wczytanie_danych();
            wczytanie_ulubionych();
        }
        public void wczytanie_ulubionych()
        {
            string wczytywanie2 = System.IO.File.ReadAllText(@"C:\Users\48510\Desktop\notatka_ulubione.txt");
            ulubione.Items.Add(wczytywanie2);
        }
        public void wczytanie_danych()
        {
            string wczytywanie = System.IO.File.ReadAllText(@"C:\Users\48510\Desktop\notatka.txt");
            lista_rzeczy.Items.Add(wczytywanie);
        }
        public void odswiezenie()
        {
            System.IO.File.ReadAllText(@"C:\Users\48510\Desktop\notatka.txt");
            System.IO.File.ReadAllText(@"C:\Users\48510\Desktop\notatka_ulubione.txt");
        }
        /// /////////////////TWORZENIE STRUKTURY/////////////////////
        struct Notatnik
        {
            public string nazwa;
            public DateTime data;
            public string priorytet;
            //public string roznica;
        }
        Notatnik notatka = new Notatnik();
        /// ////////////////////////////////////////////////////////

        private void dodaj_notatke_Click(object sender, EventArgs e)
        {
            ///utworzenie listy
            List<Notatnik> lista = new List<Notatnik>();

            ///nadawanie wartosci strukturom
            notatka.nazwa = wprowadz_dane.Text;
            notatka.data = data_wykonania.Value;
            foreach (string s in priorytet.CheckedItems) ///zaznaczone na tekst
                notatka.priorytet = s;


            ///dodanie do listy struktury
            lista.Add(notatka);
            
            lista_rzeczy.Items.Add( $"{notatka.nazwa}   {notatka.data.ToString("d.MM")}   {notatka.priorytet}\n");   ///
            //// zapisanie do pliku 
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "notatka.txt")))
            {
                foreach (var line in lista_rzeczy.Items)
                    outputFile.WriteLine(line.ToString());
            }
        }
        


        private void usun_Click(object sender, EventArgs e)
        {
            for (int i = lista_rzeczy.Items.Count - 1; i >= 0; i--)
            {
                if (lista_rzeczy.GetItemChecked(i))
                {
                    lista_rzeczy.Items.Remove(lista_rzeczy.Items[i]);
                }
            }
            for (int i = ulubione.Items.Count - 1; i >= 0; i--)
            {
                if (ulubione.GetItemChecked(i))
                {
                    ulubione.Items.Remove(ulubione.Items[i]);
                }
            }
            odswiezenie();
        }
       
        private void timer_Tick(object sender, EventArgs e)
        {
        
        }

        private void dodaj_fav_Click(object sender, EventArgs e)
        {
            for (int i = lista_rzeczy.Items.Count - 1; i >= 0; i--)
            {
                if (lista_rzeczy.GetItemChecked(i))
                {
                    ulubione.Items.Add(lista_rzeczy.Items[i]);
                    lista_rzeczy.Items.Remove(lista_rzeczy.Items[i]);
                }
            }
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "notatka_ulubione.txt")))
            {
                foreach (var line2 in ulubione.Items)
                    outputFile.WriteLine(line2.ToString());
            }
            odswiezenie();
        }
    }

    }

