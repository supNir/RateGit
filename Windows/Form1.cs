﻿using Rate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal S = Rates.SumRate(Convert.ToDecimal(txtBt.Text), Convert.ToDecimal(txtBV.Text),
            Convert.ToDecimal(txtBx.Text));
            lblS.Text = S.ToString();

        }
    }
}
