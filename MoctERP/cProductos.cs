using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias conexión BD
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace MoctERP
{
    class cProductos
    {

        //Constructor
        public cProductos()
        {

        }

        //Getters y Setters
        #region
        private int _idproducto = 0;
        public int IdProducto
        {
            get
            {
                return _idproducto;
            }
            set
            {
                _idproducto = value;
            }
        }

        private int _idLinea = 0;
        public int _IdLinea
        {
            get
            {
                return _idLinea;
            }
            set
            {
                _idLinea = value;
            }
        }

        private string _descripcion = "";
        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }

        private float _costo = 0;
        public float   Costo
        {
            get
            {
                return _costo;
            }
            set
            {
                _costo = value;
            }
        }

        private float _precio = 0;
        public float Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

        private string _unidadMedida = "";
        public string UnidadMedida
        {
            get
            {
                return _unidadMedida;
            }
            set
            {
                _unidadMedida = value;
            }
        }

        private byte[] _fotografia;
        public byte[] Fotografia
        {
            get
            {
                return _fotografia;
            }
            set
            {
                _fotografia = value;
            }
        }

        private float _existencia = 0;
        public float Existencia
        {
            get
            {
                return _existencia;
            }
            set
            {
                _existencia = value;
            }
        }

        private string _tipo = "";
        public string Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }

                private string _estatus = "";
        public string Estatus
        {
            get
            {
                return _estatus;
            }
            set
            {
                _estatus = value;
            }
        }

        #endregion

        //Declaraciónd e variables de conexión
        String cadenaConexion = "Server=UTSIT-RMR11\\SQLEXPRESS;Database=MoctERP;Trusted_Connection=True;";
        SqlConnection Conexion = null;
        SqlCommand Comando = null;
        SqlDataAdapter Adaptador = null;

        //Función encargada de crear la conexión a la BD
        private void AbreConexion()
        {
            try
            {
                if (Conexion == null)
                    Conexion = new SqlConnection(cadenaConexion);
                Conexion.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Función encargada de cerrar la conexión a la BD
        private void CierraConexion()
        {
            try
            {
                if (Conexion != null)
                    if (Conexion.State == ConnectionState.Closed)
                        Conexion.Close();
                //Destruye el contenido de la variable
                Conexion.Dispose();
                Conexion = null;
            }
            catch //(Exception)
            {

                //throw;
            }
        }

        public void ConsultaUno(string Valor)
        {
            try
            {
                DataSet DS = new DataSet();


                AbreConexion();
                Comando = new SqlCommand("ConsultaUnaEntidad", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id", SqlDbType.VarChar).Value = cFunciones.IdProducto;
                Comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                if (DS.Tables[0].Rows.Count == 0)
                    throw new Exception("No existe ese Producto");
                DataRow DR = DS.Tables[0].Rows[0];
                this._idproducto = Convert.ToInt32(DR["Idproducto"].ToString());
                this._descripcion = DR["Descripcion"].ToString();
                this._costo = float.Parse(DR["Costo"].ToString());
                this._precio = float.Parse(DR["Precio"].ToString());
                this._unidadMedida = DR["UnidadMedida"].ToString();
                this._fotografia = (byte[])DR["Foto"];
                this._existencia = float.Parse(DR["Existencia"].ToString());
                this._idLinea = Convert.ToInt32(DR["IdLinea"].ToString());
                this._tipo = DR["Tipo"].ToString();
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                CierraConexion();
            }
        }

        public int InsertaProducto(PictureBox pbImagen)
        {
            try
            {

                int actualizados = 0;
                AbreConexion();
                Comando = new SqlCommand("RegistraProducto", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdLinea", SqlDbType.VarChar).Value = cFunciones.IdLinea;
                Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = this.Descripcion;
                Comando.Parameters.Add("@Costo", SqlDbType.VarChar).Value = this.Costo;
                Comando.Parameters.Add("@Precio", SqlDbType.VarChar).Value = this.Precio;
                Comando.Parameters.Add("@UnidadMedida", SqlDbType.VarChar).Value = this.UnidadMedida;
                Comando.Parameters.Add("@Existencia", SqlDbType.VarChar).Value = 0;
                Comando.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = this.Tipo;

                Comando.Parameters.Add("@Foto", SqlDbType.Image);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Comando.Parameters["@Foto"].Value = ms.GetBuffer();


                Adaptador = new SqlDataAdapter(Comando);


                actualizados = Comando.ExecuteNonQuery();
                return actualizados;

            }
            catch (Exception ex)
            {

                throw (ex);
            }
            finally
            {
                CierraConexion();
            }
        }

        public int ModificaProducto(PictureBox pbImagen)
        {
            try
            {

                int actualizados = 0;
                AbreConexion();


                Comando = new SqlCommand("ModificaProducto", Conexion);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdProducto", SqlDbType.VarChar).Value = cFunciones.IdProducto;
                Comando.Parameters.Add("@IdLinea", SqlDbType.VarChar).Value = cFunciones.IdLinea;
                Comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = this.Descripcion;
                Comando.Parameters.Add("@Costo", SqlDbType.VarChar).Value = this.Costo;
                Comando.Parameters.Add("@Precio", SqlDbType.VarChar).Value = this.Precio;
                Comando.Parameters.Add("@UnidadMedida", SqlDbType.VarChar).Value = this.UnidadMedida;
                Comando.Parameters.Add("@Existencia", SqlDbType.VarChar).Value = 0;
                Comando.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = this.Tipo;

                Comando.Parameters.Add("@Foto", SqlDbType.Image);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Comando.Parameters["@Foto"].Value = ms.GetBuffer();

                Adaptador = new SqlDataAdapter(Comando);


                actualizados = Comando.ExecuteNonQuery();
                return actualizados;

            }
            catch (Exception ex)
            {

                throw (ex);
            }
            finally
            {
                CierraConexion();
            }
        }

        public int EliminaProducto(string Nombre)
        {
            try
            {
                int Actualizados = 0;

                AbreConexion();
                Comando = new SqlCommand("EliminaRegistroTabla", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
                Comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = this.IdProducto;

                Adaptador = new SqlDataAdapter(Comando);

                Actualizados = Comando.ExecuteNonQuery();
                return Actualizados;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                CierraConexion();
            }
        }

    }
}
