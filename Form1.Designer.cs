
namespace walsnenotatki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tytul = new System.Windows.Forms.Label();
            this.dane = new System.Windows.Forms.Label();
            this.wprowadz_dane = new System.Windows.Forms.TextBox();
            this.dodaj_notatke = new System.Windows.Forms.Button();
            this.data_wykonania = new System.Windows.Forms.DateTimePicker();
            this.priorytet = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytul.Location = new System.Drawing.Point(490, 84);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(132, 13);
            this.tytul.TabIndex = 0;
            this.tytul.Text = "NOTATNIK KRZYCHA";
            // 
            // dane
            // 
            this.dane.AutoSize = true;
            this.dane.Location = new System.Drawing.Point(537, 139);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(31, 13);
            this.dane.TabIndex = 1;
            this.dane.Text = "dane";
            // 
            // wprowadz_dane
            // 
            this.wprowadz_dane.Location = new System.Drawing.Point(50, 84);
            this.wprowadz_dane.Name = "wprowadz_dane";
            this.wprowadz_dane.Size = new System.Drawing.Size(240, 20);
            this.wprowadz_dane.TabIndex = 2;
            // 
            // dodaj_notatke
            // 
            this.dodaj_notatke.Location = new System.Drawing.Point(50, 151);
            this.dodaj_notatke.Name = "dodaj_notatke";
            this.dodaj_notatke.Size = new System.Drawing.Size(75, 23);
            this.dodaj_notatke.TabIndex = 3;
            this.dodaj_notatke.Text = "Dodaj";
            this.dodaj_notatke.UseVisualStyleBackColor = true;
            this.dodaj_notatke.Click += new System.EventHandler(this.dodaj_notatke_Click);
            // 
            // data_wykonania
            // 
            this.data_wykonania.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_wykonania.Location = new System.Drawing.Point(50, 110);
            this.data_wykonania.Name = "data_wykonania";
            this.data_wykonania.Size = new System.Drawing.Size(96, 20);
            this.data_wykonania.TabIndex = 4;
            // 
            // priorytet
            // 
            this.priorytet.FormattingEnabled = true;
            this.priorytet.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.priorytet.Location = new System.Drawing.Point(152, 110);
            this.priorytet.Name = "priorytet";
            this.priorytet.Size = new System.Drawing.Size(36, 64);
            this.priorytet.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 617);
            this.Controls.Add(this.priorytet);
            this.Controls.Add(this.data_wykonania);
            this.Controls.Add(this.dodaj_notatke);
            this.Controls.Add(this.wprowadz_dane);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.tytul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.Label dane;
        private System.Windows.Forms.TextBox wprowadz_dane;
        private System.Windows.Forms.Button dodaj_notatke;
        private System.Windows.Forms.DateTimePicker data_wykonania;
        private System.Windows.Forms.CheckedListBox priorytet;
    }
}

