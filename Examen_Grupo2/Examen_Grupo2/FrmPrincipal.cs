using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Grupo2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Quieres salir del sistema?", "", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void gestionServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            FrmGestionServicios frmGestionServicios = new FrmGestionServicios();
            frmGestionServicios.Show();
            this.Hide();
            
        }

        private void gestionClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionClientes frmGestionClientes = new FrmGestionClientes();
            frmGestionClientes.Show();
            this.Hide();
        }

        private void gestionEncuestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionEncuestas frmGestionEncuestas = new FrmGestionEncuestas();
            frmGestionEncuestas.Show();
            this.Hide();
        }

        private void dtgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
