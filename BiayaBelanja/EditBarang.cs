﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BelanjaLibrary;

namespace BiayaBelanja
{
    
    public partial class FrmEditBarang : Form
    {
        BarangDAO dao = new BarangDAO(Setting.GetConnectionString());
        public FrmEditBarang()
        {
            InitializeComponent();
        }

        private void FrmEditBarang_Load(object sender, EventArgs e)
        {
            
        }
    }
}