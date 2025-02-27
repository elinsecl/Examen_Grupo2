using BLL;
using Examen;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;


namespace Examen_Grupo2
{
    public partial class FrmGestionClientes : Form
    {
        private Conexion _conexion;
        //private readonly string ruta;

        public FrmGestionClientes()
        {
            InitializeComponent();
            _conexion = new Conexion(ConfigurationManager.ConnectionStrings["StringConexion"].ConnectionString);


        }

        private void limpiarForm()
        {

            txtIdCliente.Clear();
            txtNombreCompleto.Clear();
            txtCorreoElectronico.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            cmbEstadoCuenta.SelectedIndex = -1;
            dtpFechaRegistro.Value = DateTime.Now;
            pbFoto.Image = null;
        }

        private bool Verificar_Campos()
        {
            List<string> mensajesError = new List<string>();
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text)) mensajesError.Add("El Campo nombre es obligatorio");
            if (string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)) mensajesError.Add("El Campo correo es obligatorio");
            if (string.IsNullOrWhiteSpace(txtTelefono.Text)) mensajesError.Add("El Campo telefono es obligatorio");
            if (string.IsNullOrWhiteSpace(txtDireccion.Text)) mensajesError.Add("El Campo direccion es obligatorio");
            if (string.IsNullOrWhiteSpace(cmbEstadoCuenta.Text)) mensajesError.Add("El Campo Estado de cuenta es obligatorio");
            if (pbFoto.Image == null) mensajesError.Add("Se debe selecionar una imagen");
            if (mensajesError.Count > 0)
            {
                MessageBox.Show("Error de validacion: \n\n" + string.Join("\n", mensajesError, "Error en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Warning));
                return false;
            }
            return true;

        }

        private void Pb_EditarImagen(object sender, EventArgs e)
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

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Verificar_Campos()) return;



                string nombreCompleto = txtNombreCompleto.Text;

                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                string correoElectronico = txtCorreoElectronico.Text;
                string telefono = txtTelefono.Text;
                string direccion = txtDireccion.Text;
                DateTime fechaRegistro = dtpFechaRegistro.Value;
                string estadoCuenta = cmbEstadoCuenta.SelectedItem.ToString();

                Clientes clientes = new Clientes()
                {


                    NombreCompleto = nombreCompleto,
                    FechaNacimiento = fechaNacimiento,
                    CorreoElectronico = correoElectronico,
                    Telefono = telefono,
                    Direccion = direccion,
                    FechaRegistro = fechaRegistro,
                    EstadoCuenta = estadoCuenta,
                    Foto = Guardar_Imagen(pbFoto.Image)

                };
                _conexion.GuardarCliente(clientes);
                MessageBox.Show("Cliente Agregado");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
                {
                    MessageBox.Show("NO Se Ha selecionado un Cliente");
                    return;
                }
                int idCliente = Convert.ToInt32(txtIdCliente.Text);

                string nombreCompleto = txtNombreCompleto.Text;

                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                string correoElectronico = txtCorreoElectronico.Text;
                string telefono = txtTelefono.Text;
                string direccion = txtDireccion.Text;
                DateTime fechaRegistro = dtpFechaRegistro.Value;
                string estadoCuenta = cmbEstadoCuenta.SelectedItem.ToString();

                Clientes clientes = new Clientes()
                {

                    IdCliente = idCliente,
                    NombreCompleto = nombreCompleto,
                    FechaNacimiento = fechaNacimiento,
                    CorreoElectronico = correoElectronico,
                    Telefono = telefono,
                    Direccion = direccion,
                    FechaRegistro = fechaRegistro,
                    EstadoCuenta = estadoCuenta,
                    Foto = Guardar_Imagen(pbFoto.Image)

                };
                _conexion.ModificarCliente(clientes);
                MessageBox.Show("Cliente modificado");
                //CargarLidro();
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

                if (!string.IsNullOrWhiteSpace(txtIdCliente.Text))
                {
                    int idLibro = Convert.ToInt32((txtIdCliente.Text));

                    _conexion.EliminarCliente(idLibro);
                    MessageBox.Show("Cliente Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarForm();
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
