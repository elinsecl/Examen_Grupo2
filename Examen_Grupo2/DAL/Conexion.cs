using BLL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Conexion
    {
        //Objeto para interactuar con el servidor de la Base de Datos
        private string StringConexion;

        //Variable para manejar la referencia para la conexion
        private SqlConnection _connection;

        //Variable para ejecutar transac-sql del lado del servidro de Base de Datos
        private SqlCommand _command;

        //Variable que permite ejecutar transac-sql de consulta
        private SqlDataReader _reader;


        public Conexion(string pStringCnx)
        {
            StringConexion = pStringCnx;
        }

        public void GuardarServicio(Servicios servicio)
        {
            try
            {
                // Se instancia la conexión con la base de datos utilizando la cadena de conexión definida.
                _connection = new SqlConnection(StringConexion);

                // Se abre la conexión a la base de datos.
                _connection.Open();

                // Se instancia el objeto SqlCommand para ejecutar el procedimiento almacenado.
                _command = new SqlCommand();

                // Se asigna la conexión establecida al comando SQL.
                _command.Connection = _connection;

                // Se especifica que el comando es un procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;

                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Ins_Servicio]";

                _command.Parameters.AddWithValue("@NombreServicio", servicio.NombreServicio);
                _command.Parameters.AddWithValue("@Descripcion", servicio.Descripcion);
                _command.Parameters.AddWithValue("@Precio", servicio.Precio);
                _command.Parameters.AddWithValue("@Duracion", servicio.Duracion);
                _command.Parameters.AddWithValue("@Categoria", servicio.Categoria);
                _command.Parameters.AddWithValue("@Estado", servicio.Estado);
                _command.Parameters.AddWithValue("@FechaCreacion", servicio.FechaCreacion);
                _command.Parameters.AddWithValue("@Foto", servicio.Foto);

                _command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarServicio(Servicios servicio)
        {
            try
            {
                // Se instancia la conexión a la base de datos utilizando la cadena de conexión.
                _connection = new SqlConnection(StringConexion);

                // Se abre la conexión a la base de datos.
                _connection.Open();

                // Se instancia el comando SQL que se ejecutará.
                _command = new SqlCommand();

                // Se asigna la conexión al comando.
                _command.Connection = _connection;

                // Se especifica que el comando es de tipo procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;

                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Upd_Servicio]";

                _command.Parameters.AddWithValue("@IdServicio", servicio.IdServicio);
                _command.Parameters.AddWithValue("@NombreServicio", servicio.NombreServicio);
                _command.Parameters.AddWithValue("@Descripcion", servicio.Descripcion);
                _command.Parameters.AddWithValue("@Precio", servicio.Precio);
                _command.Parameters.AddWithValue("@Duracion", servicio.Duracion);
                _command.Parameters.AddWithValue("@Categoria", servicio.Categoria);
                _command.Parameters.AddWithValue("@Estado", servicio.Estado);
                _command.Parameters.AddWithValue("@FechaCreacion", servicio.FechaCreacion);
                _command.Parameters.AddWithValue("@Foto", servicio.Foto);

                _command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarServicio(int idServicio)
        {
            try
            {
                // Se instancia la conexión a la base de datos utilizando la cadena de conexión.
                _connection = new SqlConnection(StringConexion);

                // Se abre la conexión a la base de datos.
                _connection.Open();

                // Se instancia el comando SQL que se ejecutará.
                _command = new SqlCommand();

                // Se asigna la conexión al comando.
                _command.Connection = _connection;

                // Se especifica que el comando es de tipo procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;

                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Del_Servicio]";
                _command.Parameters.AddWithValue("@IdServicio", idServicio); // Se añade el parámetro del procedimiento almacenado con el valor del email.

                // Se ejecuta el comando (en este caso, no se espera ningún valor de retorno, solo se realiza la eliminación).
                _command.ExecuteNonQuery();

                // Se cierra la conexión con la base de datos una vez se ha ejecutado el procedimiento.
                _connection.Close();

                // Se liberan los recursos de la conexión.
                _connection.Dispose();

                // Se liberan los recursos del comando.
                _command.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet BuscarPorNombreServicio(string nombre)
        {
            try
            {
                // Se instancia la conexión a la base de datos utilizando la cadena de conexión.
                _connection = new SqlConnection(StringConexion);

                // Se abre la conexión a la base de datos.
                _connection.Open();

                // Se instancia el comando SQL que se ejecutará.
                _command = new SqlCommand();

                // Se asigna la conexión al comando.
                _command.Connection = _connection;

                // Se especifica que el comando es de tipo procedimiento almacenado.
                _command.CommandType = CommandType.StoredProcedure;

                // Se asigna el nombre del procedimiento almacenado que se ejecutará.
                _command.CommandText = "[Sp_Buscar_Nombre_Servicio]";

                // Se añade el parámetro del procedimiento almacenado con el valor del nombre proporcionado.
                _command.Parameters.AddWithValue("@NombreServicio", nombre);

                // Se instancia un adaptador de datos para llenar el DataSet con los resultados de la consulta.
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet datos = new DataSet(); // Se crea un DataSet para almacenar los datos tabulados.

                // Se asigna el comando SQL al adaptador.
                adapter.SelectCommand = _command;

                // Se llena el DataSet con los datos obtenidos por el adaptador.
                adapter.Fill(datos);

                // Se cierra la conexión con la base de datos.
                _connection.Close();

                // Se liberan los recursos de la conexión.
                _connection.Dispose();

                // Se liberan los recursos del comando.
                _command.Dispose();

                // Se liberan los recursos del adaptador.
                adapter.Dispose();

                // Se retorna el conjunto de datos con los resultados de la búsqueda.
                return datos;
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, se vuelve a lanzar para ser manejada por el llamador.
                throw ex;
            }
        }

        public Servicios BuscarPorIdServicio(int idServicio)
        {
            try
            {
                _connection = new SqlConnection(StringConexion);
                _connection.Open();
                _command = new SqlCommand("[Sp_Buscar_Id_Servicio]", _connection);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("@IdServicio", idServicio);

                _reader = _command.ExecuteReader();
                Servicios temp = null;

                if (_reader.Read())
                {
                    temp = new Servicios()
                    {
                        IdServicio = Convert.ToInt32(_reader["IdServicio"]),
                        NombreServicio = _reader["NombreServicio"].ToString(),
                        Descripcion = _reader["Descripcion"].ToString(),
                        Precio = Convert.ToDecimal(_reader["Precio"]),
                        Duracion = Convert.ToInt32(_reader["Duracion"]),
                        Categoria = _reader["Categoria"].ToString(),
                        Estado = _reader["Estado"].ToString(),
                        FechaCreacion = Convert.ToDateTime(_reader["FechaCreacion"]),
                        Foto = _reader["Foto"].ToString()
                    };
                }

                _connection.Close();
                return temp;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Victor
        }
    }
}
