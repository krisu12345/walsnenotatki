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
        }

        public void wczytanie_danych()
        {
            string wczytywanie = System.IO.File.ReadAllText(@"C:\Users\48510\Desktop\notatka.txt");
            lista_rzeczy.Items.Add(wczytywanie);
        }
        public void odswiezenie()
        {
            string wczytywanie = System.IO.File.ReadAllText(@"C:\Users\48510\Desktop\notatka.txt");
        }
        /// /////////////////TWORZENIE STRUKTURY/////////////////////
        struct Notatnik
        {
            public string nazwa;
            public DateTime data;
            public string priorytet;
            public string roznica;
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

            ///roznica dni i teksty
            /*DateTime teraz = DateTime.Now;
            TimeSpan wynik = (notatka.data - teraz);
            notatka.roznica = wynik.Days.ToString();
            if (notatka.roznica == "0")
            {
                notatka.roznica = "jutro";
            }
            else if (notatka.roznica == "1")
            {
                notatka.roznica = "pojutrze";
            }
            else if (notatka.roznica == "2")
            {
                  notatka.roznica = "3";
            }
            else if (notatka.roznica == "3")
            {
                  notatka.roznica = "4";
            }
            else if (notatka.roznica == "4")
            {
                notatka.roznica = "5";
            }
            else if (notatka.roznica == "5")
            {
                notatka.roznica = "6";
            }
            else if (notatka.roznica == "6")
            {
                notatka.roznica = "tydzień";
            }
            else if (notatka.roznica == "8")
            {
                notatka.roznica = "9";
            }
            else if (notatka.roznica == "9")
            {
                notatka.roznica = "10";
            }
            else if (notatka.roznica == "10")
            {
                notatka.roznica = "11";
            }
            else if (notatka.roznica == "11")
            {
                notatka.roznica = "12";
            }
            else if (notatka.roznica == "12")
            {
                notatka.roznica = "13";
            }
            else if (notatka.roznica == "13")
            {
                notatka.roznica = "dwa tygodnie";
            }
            */


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
            odswiezenie();
        }
       
        private void timer_Tick(object sender, EventArgs e)
        {
        
        }
    }

    }

