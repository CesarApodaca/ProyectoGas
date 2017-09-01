using ProyectoGas.Vistas;
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
    public partial class InterfazPrincipal : Form
    {
        public InterfazPrincipal()
        {
            InitializeComponent();
            Inicializador();
            
        }

        public void Inicializador()
        {
            panelDisp.Height = 47;
        }

        private void InterfazPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes vClientes = new Clientes();
            vClientes.TopLevel = false;
            //vClientes.Parent = panelContenido;
            
            // vClientes.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //panelContenido.Controls.RemoveAt(0);
            
            panelContenido.Controls.Add(vClientes);
            vClientes.Location = new Point(
             panelContenido.ClientSize.Width / 2 - vClientes.Size.Width / 2,
            panelContenido.ClientSize.Height / 2 - vClientes.Size.Height / 2);
            vClientes.Show();
            vClientes.BringToFront();


        }

       

        private void btnEquipos(object sender, EventArgs e)
        {
            Dispositivos vEquipos = new Dispositivos();
            vEquipos.TopLevel = false;
            //vClientes.Parent = panelContenido;

            // vClientes.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //panelContenido.Controls.RemoveAt(0);

            panelContenido.Controls.Add(vEquipos);
            vEquipos.Location = new Point(
            panelContenido.ClientSize.Width / 2 - vEquipos.Size.Width / 2,
            panelContenido.ClientSize.Height / 2 - vEquipos.Size.Height / 2);
            vEquipos.Show();
            vEquipos.BringToFront();
        }

        private void btnTanques_Click(object sender, EventArgs e)
        {
            Tanques vTanques = new Tanques();
            vTanques.TopLevel = false;
            //vClientes.Parent = panelContenido;

            // vClientes.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //panelContenido.Controls.RemoveAt(0);

            panelContenido.Controls.Add(vTanques);
            vTanques.Location = new Point(
            panelContenido.ClientSize.Width / 2 - vTanques.Size.Width / 2,
            panelContenido.ClientSize.Height / 2 - vTanques.Size.Height / 2);
            vTanques.Show();
            vTanques.BringToFront();
        }

        private void btnPipa_Click(object sender, EventArgs e)
        {
            Pipas vPipas = new Pipas();
            vPipas.TopLevel = false;
            panelContenido.Controls.Add(vPipas);
            vPipas.Location = new Point(
            panelContenido.ClientSize.Width / 2 - vPipas.Size.Width / 2,
            panelContenido.ClientSize.Height / 2 - vPipas.Size.Height / 2);
            vPipas.Show();
            vPipas.BringToFront();
        }

        private void btnChoferes_Click(object sender, EventArgs e)
        {
            Chofer vChofer = new Chofer();
            vChofer.TopLevel = false;

            panelContenido.Controls.Add(vChofer);
            vChofer.Location = new Point(
            panelContenido.ClientSize.Width / 2 - vChofer.Size.Width / 2,
            panelContenido.ClientSize.Height / 2 - vChofer.Size.Height / 2);
            vChofer.Show();
            vChofer.BringToFront();
        }

        private void btnAsignarChofer_Click(object sender, EventArgs e)
        {
            AsignarChofer vAsignarChofer = new AsignarChofer();
            vAsignarChofer.TopLevel = false;

            panelContenido.Controls.Add(vAsignarChofer);
            vAsignarChofer.Location = new Point(
            panelContenido.ClientSize.Width / 2 - vAsignarChofer.Size.Width / 2,
            panelContenido.ClientSize.Height / 2 - vAsignarChofer.Size.Height / 2);
            vAsignarChofer.Show();
            vAsignarChofer.BringToFront();
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void asignaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarDispositivo vAsignarDispositivo = new AsignarDispositivo();
            vAsignarDispositivo.TopLevel = false;

            panelContenido.Controls.Add(vAsignarDispositivo);
            vAsignarDispositivo.Location = new Point(
            panelContenido.ClientSize.Width / 2 - vAsignarDispositivo.Size.Width / 2,
            panelContenido.ClientSize.Height / 2 - vAsignarDispositivo.Size.Height / 2);
            vAsignarDispositivo.Show();
            vAsignarDispositivo.BringToFront();
        }

        private void btnDisp_Click(object sender, EventArgs e)
        {
            dropDisp.BackColor = Color.FromArgb(116, 147, 173);
            if (panelDisp.Height == 47)
                panelDisp.Height = (47 * 3) + 2;
            else
                panelDisp.Height = 47;

        }

        private void dropDisp_Click(object sender, EventArgs e)
        {
            if (panelDisp.Height == 47)
                panelDisp.Height = (47 * 3) + 2;
            else
                panelDisp.Height = 47;

        }

        private void btnDisp_MouseEnter(object sender, EventArgs e)
        {
            dropDisp.BackColor = Color.FromArgb(52, 81, 108);
        }

        private void btnDisp_MouseLeave(object sender, EventArgs e)
        {
            dropDisp.BackColor = Color.FromArgb(44, 68, 90);
        }

        private void btnDisp_MouseClick(object sender, MouseEventArgs e)
        {
            dropDisp.BackColor = Color.FromArgb(116, 147, 173);
        }

        private void btnDisp_DragDrop(object sender, DragEventArgs e)
        {
            dropDisp.BackColor = Color.FromArgb(116, 147, 173);
        }

        private void btnDisp_DragEnter(object sender, DragEventArgs e)
        {
            dropDisp.BackColor = Color.FromArgb(116, 147, 173);
        }

        private void btnDisp_MouseDown(object sender, MouseEventArgs e)
        {
            dropDisp.BackColor = Color.FromArgb(116, 147, 173);
        }

        private void btnDisp_MouseUp(object sender, MouseEventArgs e)
        {
            dropDisp.BackColor = Color.FromArgb(52, 81, 108);
        }

        private void btnAltaDisp_Click(object sender, EventArgs e)
        {
            Dispositivos vEquipos = new Dispositivos();
            vEquipos.TopLevel = false;
            //vClientes.Parent = panelContenido;

            // vClientes.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //panelContenido.Controls.RemoveAt(0);

            panelContenido.Controls.Add(vEquipos);
            vEquipos.Location = new Point(
            panelContenido.ClientSize.Width / 2 - vEquipos.Size.Width / 2,
            panelContenido.ClientSize.Height / 2 - vEquipos.Size.Height / 2);
            vEquipos.Show();
            vEquipos.BringToFront();
        }

        private void btnAsigDisp_Click(object sender, EventArgs e) //Asignar Dispositivo a Cliente
        {
            AsignarDispositivo vAsignarDispositivo = new AsignarDispositivo();
            vAsignarDispositivo.TopLevel = false;

            panelContenido.Controls.Add(vAsignarDispositivo);
            vAsignarDispositivo.Location = new Point(
            panelContenido.ClientSize.Width / 2 - vAsignarDispositivo.Size.Width / 2,
            panelContenido.ClientSize.Height / 2 - vAsignarDispositivo.Size.Height / 2);
            vAsignarDispositivo.Show();
            vAsignarDispositivo.BringToFront();
        }

        private void dropDisp_MouseEnter(object sender, EventArgs e)
        {
            dropDisp.BackColor = Color.FromArgb(52, 81, 108);
            btnDisp.BackColor = Color.FromArgb(52, 81, 108);
        }

        private void dropDisp_MouseLeave(object sender, EventArgs e)
        {
            dropDisp.BackColor = Color.FromArgb(44, 68, 90);
            btnDisp.BackColor = Color.FromArgb(44, 68, 90);
        }

        private void btnDesasigDisp_Click(object sender, EventArgs e)
        {
            DesasignarDispositivo vDesasignarDispositivo = new DesasignarDispositivo();
            vDesasignarDispositivo.TopLevel = false;

            panelContenido.Controls.Add(vDesasignarDispositivo);
            vDesasignarDispositivo.Location = new Point(
            panelContenido.ClientSize.Width / 2 - vDesasignarDispositivo.Size.Width / 2,
            panelContenido.ClientSize.Height / 2 - vDesasignarDispositivo.Size.Height / 2);
            vDesasignarDispositivo.Show();
            vDesasignarDispositivo.BringToFront();
        }
    }
}
