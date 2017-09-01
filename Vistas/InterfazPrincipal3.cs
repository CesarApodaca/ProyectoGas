using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGas.Vistas
{
    public partial class InterfazPrincipal3 : Form
    {
        public InterfazPrincipal3()
        {
            InitializeComponent();
            Inicializador();
        }

        public void Inicializador()
        {
            panelChoferes.Height = 47;
        }

        private void downChoferes_Click(object sender, EventArgs e)
        {
            if (panelChoferes.Height == 47)
            {
                panelChoferes.Height = (47 * 2) + 2;
            }
            else
            {
                panelChoferes.Height = 47;
               // btnMenuGroup1.Image = Properties.Resources.down;
            }
        }

        private void btnChoferes_Click(object sender, EventArgs e)
        {
            if (panelChoferes.Height == 47)
            {
                panelChoferes.Height = (47 * 2) + 2;
            }
            else
            {
                panelChoferes.Height = 47;
                // btnMenuGroup1.Image = Properties.Resources.down;
            }
        }
    }
}
