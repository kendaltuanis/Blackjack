﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack.Vistas
{
    public partial class MDIParent1 : Form
    {
        public MDIParent1()
        {
            InitializeComponent();
        }
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Connecting to facebook.....");
            Form1 frmLogin = new Form1();
            frmLogin.MdiParent = this;
            frmLogin.Show();

        }
    }
}