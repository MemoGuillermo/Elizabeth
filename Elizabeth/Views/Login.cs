using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Elizabeth.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "admin" && txtContrasena.Text.Trim() == "admin"){
                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }
    }
}
