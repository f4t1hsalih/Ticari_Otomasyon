﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmInvoiceEditing : Form
    {
        public FrmInvoiceEditing()
        {
            InitializeComponent();
        }

        public string prodId;

        void Clean()
        {
            txtProdName.Clear();
            txtAmount.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
        }

        private void FrmInvoiceEditing_Load(object sender, EventArgs e)
        {
            txtInvoiceInfoID.Text = prodId;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}