﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senha_user
{
    public partial class Hometest : Form
    {
        
        

        public Hometest()
        {
            InitializeComponent();
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cadastrafuncionariotest cadastrafuncionariotest = new cadastrafuncionariotest();
            this.Hide();
            cadastrafuncionariotest.Show();
        }
    }
}
