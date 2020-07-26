namespace WindowsFormsApp1
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
            this.cena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dystans = new System.Windows.Forms.TextBox();
            this.spalanie = new System.Windows.Forms.TextBox();
            this.oblicz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cena
            // 
            this.cena.Location = new System.Drawing.Point(288, 130);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(100, 20);
            this.cena.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "LICZNIK KOSZTÓW TRASY";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(48, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dystans [km]";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(48, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cena paliwa [zł]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(48, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Spalanie [L/100]";
            // 
            // dystans
            // 
            this.dystans.Location = new System.Drawing.Point(288, 91);
            this.dystans.Multiline = true;
            this.dystans.Name = "dystans";
            this.dystans.Size = new System.Drawing.Size(100, 20);
            this.dystans.TabIndex = 5;
            // 
            // spalanie
            // 
            this.spalanie.Location = new System.Drawing.Point(288, 172);
            this.spalanie.Name = "spalanie";
            this.spalanie.Size = new System.Drawing.Size(100, 20);
            this.spalanie.TabIndex = 6;
            // 
            // oblicz
            // 
            this.oblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.oblicz.Location = new System.Drawing.Point(155, 227);
            this.oblicz.Name = "oblicz";
            this.oblicz.Size = new System.Drawing.Size(122, 32);
            this.oblicz.TabIndex = 7;
            this.oblicz.Text = "OBLICZ";
            this.oblicz.UseVisualStyleBackColor = true;
            this.oblicz.Click += new System.EventHandler(this.oblicz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(48, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Koszt trasy [zł]";
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(288, 285);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(100, 20);
            this.wynik.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 363);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oblicz);
            this.Controls.Add(this.spalanie);
            this.Controls.Add(this.dystans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Licznik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
        #endregion

        public System.Windows.Forms.TextBox cena;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox dystans;
        public System.Windows.Forms.TextBox spalanie;
        public System.Windows.Forms.Button oblicz;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox wynik;
    }
}

