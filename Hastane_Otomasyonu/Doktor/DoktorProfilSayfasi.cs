﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class DoktorProfilSayfasi : Form
    {
        public DoktorProfilSayfasi()
        {
            InitializeComponent();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.Show();
            this.Hide();
        }
    }
}
