﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Izlaz : Form
    {
        public Izlaz()
        {
            InitializeComponent();
        }



        private void Izlaz_Load(object sender, EventArgs e)
        {

        }

        private void buttonUlazPotvrdi_Click(object sender, EventArgs e)
        {

        }

        private void buttonUlazNazad_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Meni();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }
    }
}
