using BLL;
using Examen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Grupo2
{
    public partial class FrmGestionEncuestas : Form
    {
        private Conexion _conexion;

        public FrmGestionEncuestas()
        {
            InitializeComponent();
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);

            CargarCombos();
        }
        private void CargarCombos()
        {
            cmbCalificacionEncuesta.Items.Add("1");
            cmbCalificacionEncuesta.Items.Add("2");
            cmbCalificacionEncuesta.Items.Add("3");
            cmbCalificacionEncuesta.Items.Add("4");
            cmbCalificacionEncuesta.Items.Add("5");

            cmbTipoEncuesta.Items.Add("Satisfacción");
            cmbTipoEncuesta.Items.Add("Recomendación");
            cmbTipoEncuesta.Items.Add("Opinión");

            cmbEstadoEncuesta.Items.Add("Completada");
            cmbEstadoEncuesta.Items.Add("Pendiente");
        }

        private void LimpiarFormulario()
        {
            txtIdEncuesta.Clear();
            txtIdCliente.Clear();
            txtServicio.Clear();
            txtComentarios.Clear();
            dtpFechaEncuesta.Value = DateTime.Now;
            cmbCalificacionEncuesta.SelectedIndex = -1;
            cmbTipoEncuesta.SelectedIndex = -1;
            cmbEstadoEncuesta.SelectedIndex = -1;
        }

        private bool Verificar_Campos()
        {
            List<string> mensajesError = new List<string>();

            if (cmbCalificacionEncuesta.SelectedIndex == -1)
                mensajesError.Add("El campo 'Calificación Encuesta' debe ser seleccionado.");

            if (cmbTipoEncuesta.SelectedIndex == -1)
                mensajesError.Add("El campo 'Tipo Encuesta' debe ser seleccionado.");

            if (cmbEstadoEncuesta.SelectedIndex == -1)
                mensajesError.Add("El campo 'Estado Encuesta' debe ser seleccionado.");

            if (mensajesError.Count > 0)
            {
                MessageBox.Show("Error de validación : \n\n" + string.Join("In", mensajesError), "Error en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Verificar_Campos()) return;

                int idCliente = Convert.ToInt32(txtIdCliente.Text);
                int idServicio = Convert.ToInt32(txtServicio.Text);
                string comentarios = txtComentarios.Text;
                DateTime fechaEncuesta = dtpFechaEncuesta.Value;
                string calificacionEncuesta = cmbCalificacionEncuesta.SelectedItem.ToString();
                string tipoEncuesta = cmbTipoEncuesta.SelectedItem.ToString();
                string estadoEncuesta = cmbEstadoEncuesta.SelectedItem.ToString();

                Encuestas encuestas = new Encuestas()
                {
                    IdCliente = idCliente,
                    IdServicio = idServicio,
                    Comentarios = comentarios,
                    FechaEncuesta = fechaEncuesta,
                    CalificacionEncuesta = calificacionEncuesta,
                    TipoEncuesta = tipoEncuesta,
                    EstadoEncuesta = estadoEncuesta
                };

                _conexion.GuardarEncuestas(encuestas);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la encuesta: " + ex.Message);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtIdEncuesta.Text))
                {
                    MessageBox.Show("NO Se Ha selecionado una Encuesta.");
                    return;
                }
                Encuestas encuestas = new Encuestas()
                {
                    IdCliente = Convert.ToInt32(txtIdCliente.Text),
                    IdServicio = Convert.ToInt32(txtServicio.Text),
                    Comentarios = txtComentarios.Text,
                    FechaEncuesta = Convert.ToDateTime(dtpFechaEncuesta.Text),
                    CalificacionEncuesta = cmbCalificacionEncuesta.Text,
                    TipoEncuesta = cmbTipoEncuesta.Text,
                    EstadoEncuesta = cmbEstadoEncuesta.Text
                };

                _conexion.ModificarEncuestas(encuestas);
                MessageBox.Show("Encuesta modificado");
            }

            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(txtIdEncuesta.Text))
                {
                    int idEncuesta = Convert.ToInt32((txtIdEncuesta.Text));

                    _conexion.EliminarEncuesta(idEncuesta);
                    MessageBox.Show("Encuesta Eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Debe ingresar un ID Valido");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Errror al eliminar" + ex.Message);
            }
        }
    }
}
