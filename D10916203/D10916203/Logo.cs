﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D10916203
{
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            timer1.Stop();
            this.Hide();
        }
    }
}
