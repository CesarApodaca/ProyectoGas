using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGas
{
    public partial class Login : Form
    {
        InterfazPrincipal interfaz;
        public Login()
        {
            InitializeComponent();
         
        }

 

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "Usuario";
            txtClave.Text = "asd8yhdo392n";
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
               // txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "asd8yhdo392n")
            {
                txtClave.Text = "";
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "asd8yhdo392n";
                // txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            interfaz = new InterfazPrincipal();
            interfaz.Show();
        }
    }
}
