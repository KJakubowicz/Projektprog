﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Po naciśnęciu przycisku "Oblicz" wylicza nam wynik ze wzrou.
        /// </summary>
        /// <param name="sender">Parametr,który zawiera odwołanie do obiektu</param>
        /// <param name="e">Paramert przekazuje obiekt specyficzny dla zdarzeni</param>


        public void oblicz_Click(object sender, EventArgs e)

        {


            wynik.Text = (((float.Parse(dystans.Text) / 100) * float.Parse(spalanie.Text)) * float.Parse(cena.Text)).ToString();


        }
        public class Obliczenie
            {

            public object Wyniki(int a, int b)
            {

                if (a > b)
                    return 1;
                else
                    return 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
