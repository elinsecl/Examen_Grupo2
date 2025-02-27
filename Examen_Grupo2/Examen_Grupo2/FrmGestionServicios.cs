using BLL;
using Examen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Grupo2
{
    public partial class FrmGestionServicios : Form
    {
        private Conexion _conexion;

        public FrmGestionServicios()
        {
            InitializeComponent();
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);

            CargarCombo();
        }

        private void CargarCombo()
        {

            cmbCategoria.Items.Add("Salud min: 10,000.45");
            cmbCategoria.Items.Add("Entretenimiento min: 4,000.86");
            cmbCategoria.Items.Add("Estetica  min: 50,000.97");
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");

        }
        private void LimpiarFormulario()
        {

            txtIdServicio.Clear();
            txtNombreServicio.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtDuracion.Clear();
            cmbEstado.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            dtpFechaCreacion.Value = DateTime.Now;
            pbFoto.Image = null;
        }


        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }


        private bool Verificar_Campos()
        {
            List<string> mensajeError = new List<string>();

            if (cmbEstado.SelectedIndex.Equals("Salud min: 10,000.45"))

                if (Convert.ToDouble(txtPrecio) < 10000.45)

                    mensajeError.Add("Error precio inferior al estado");


            if (cmbEstado.SelectedIndex.Equals("Entretenimiento min: 4,000.86"))

                if (Convert.ToDouble(txtPrecio) < 4000.86)

                    mensajeError.Add("Error precio inferior al estado");


            if (cmbEstado.SelectedIndex.Equals("Estetica  min: 50,000.97"))

                if (Convert.ToDouble(txtPrecio) < 50000.97)

                    mensajeError.Add("Error precio inferior al estado");

            if (mensajeError.Count > 0)
            {
                MessageBox.Show("Error de validacion :\n\n" + string.Join("In", mensajeError), "Error en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Verificar_Campos()) return;
                {
                    int idServicio = Convert.ToInt32(txtIdServicio.Text);
                    decimal precio = Convert.ToDecimal(txtPrecio.Text);
                    string categoria = cmbCategoria.SelectedItem.ToString();
                    string estado = cmbEstado.SelectedItem.ToString();
                    DateTime fechaCreacion = dtpFechaCreacion.Value;
                    int duracion = Convert.ToInt32(txtDuracion.Text);
                    string nombreServicio = txtNombreServicio.Text;
                    string descripcion = txtDescripcion.Text;

                    Servicios servicios = new Servicios()
                    {
                        IdServicio = idServicio,
                        NombreServicio = nombreServicio,
                        Descripcion = descripcion,
                        Precio = precio,
                        Duracion = duracion,
                        Categoria = categoria,
                        Estado = estado,
                        FechaCreacion = fechaCreacion,
                        Foto = Guardar_Imagen(pbFoto.Image)


                    };
                    _conexion.GuardarServicio(servicios);
                    LimpiarFormulario();



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar" + ex.Message);
            }
        }

        




        

        private Bitmap Redimencionar_Y_Recortar_Circular(Image image, int ancho, int alto)
        {
            Bitmap bitmapRedimensionado = new Bitmap(ancho, alto);
            using (Graphics g = Graphics.FromImage(bitmapRedimensionado))
            {

                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, ancho, alto);
                    g.SetClip(path);

                    float ratioImage = (float)image.Width / image.Height;
                    float ratioDestino = (float)ancho / alto;

                    RectangleF destino;
                    if (ratioImage > ratioDestino)
                    {
                        float escala = (float)alto / image.Height;
                        float nuevAncho = image.Width * escala;
                        float offsetX = (nuevAncho - ancho) / 2;
                        destino = new RectangleF(-offsetX, 0, nuevAncho, alto);
                    }
                    else
                    {

                        float escala = (float)ancho / image.Width;
                        float nuevAlto = image.Width * escala;
                        float offsetY = (nuevAlto - alto) / 2;
                        destino = new RectangleF(-offsetY, 0, ancho, nuevAlto);
                    }
                    g.DrawImage(image, destino);
                }

            }
            return bitmapRedimensionado;

        }



        private string Guardar_Imagen(Image imagen)
        {

            if (imagen == null)
            {
                return null;
            }

            try
            {
                string carpetaFotos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fotos");

                if (!System.IO.Directory.Exists(carpetaFotos))
                {

                    System.IO.Directory.CreateDirectory(carpetaFotos);
                }
                string ruta = Path.Combine(carpetaFotos, $"{Guid.NewGuid()}.png");

                imagen.Save(ruta, System.Drawing.Imaging.ImageFormat.Png);
                return ruta;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar la imagen" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        

        

        private void pbEditar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagenes|*.png;*jpg;*bmp";
                openFileDialog.Title = "Selecionar Imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image imagenselecionada = Image.FromFile(openFileDialog.FileName);
                        pbFoto.Image = Redimencionar_Y_Recortar_Circular(imagenselecionada, 50, 50);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al cargar la imagen" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarInforme();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


    }


        public void MostrarInforme()
        {
            try
            {
                FrmReporte formulario = new FrmReporte();
                formulario.FormClosed += (s, args) => Buscar("");
                formulario.ShowDialog();
                formulario.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Buscar(string sNombreServicio)
         {
             try
             {
                 this.dtgDatos.DataSource = _conexion.BuscarNombresServicio(sNombreServicio).Tables[0];
                 this.dtgDatos.AutoResizeColumns();
                 this.dtgDatos.ReadOnly = true;
             }
             catch (Exception ex)
             {

                 throw ex;
             }
         }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(txtIdServicio.Text))
                {
                    int idLibro = Convert.ToInt32((txtIdServicio.Text));

                    _conexion.EliminarCliente(idLibro);
                    MessageBox.Show("Cliente Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdServicio.Text))
                {
                    MessageBox.Show("NO Se Ha selecionado un Cliente");
                    return;
                }
                int idServicio = Convert.ToInt32(txtIdServicio.Text);
                Decimal precio = Convert.ToDecimal(txtPrecio.Text);
                string categoria = cmbCategoria.SelectedItem.ToString();
                string estado = cmbEstado.SelectedItem.ToString();
                DateTime fechaCreacion = dtpFechaCreacion.Value;
                int duracion = Convert.ToInt32(txtDuracion.Text);
                string nombreServicio = txtNombreServicio.Text;
                string descripcion = txtDescripcion.Text;

                Servicios servicios = new Servicios()
                {
                    IdServicio = idServicio,
                    NombreServicio = nombreServicio,
                    Descripcion = descripcion,
                    Precio = precio,
                    Duracion = duracion,
                    Categoria = categoria,
                    Estado = estado,
                    FechaCreacion = fechaCreacion,
                    Foto = Guardar_Imagen(pbFoto.Image)


                };
                _conexion.ModificarServicio(servicios);
                LimpiarFormulario();
                MessageBox.Show("Cliente modificado");
                //CargarLidro();
            }

            catch (Exception)
            {

                throw;
            }

        }
    }
}

