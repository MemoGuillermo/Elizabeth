using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Elizabeth.Views
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnComercial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comercial.Main comercial = new Comercial.Main();
            comercial.Show();
        }
    }
}
