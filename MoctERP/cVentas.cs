using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerias conexión BD
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MoctERP
{
    class cVentas
    {
        public cVentas()
        {

        }

        //Getters y Setters
        #region

        private int _idcliente;
        public int IdCliente
        {
            get
            {
                return _idcliente;
            }
            set
            {
                _idcliente = value;
            }
        }

        private string _rfc;
        public string RFC
        {
            get
            {
                return _rfc;
            }
            set
            {
                _rfc = value;
            }
        }

        private string _nombreCliente;
        public string NombreCliente
        {
            get
            {
                return _nombreCliente;
            }
            set
            {
                _nombreCliente = value;
            }
        }
        private DateTime _fechaVenta;
        public DateTime FechaVenta
        {
            get
            {
                return _fechaVenta;
            }
            set
            {
                _fechaVenta = value;
            }
        }

        private double _subtotal = 0.00;
        public double Subtotal
        {
            get
            {
                return _subtotal;
            }
            set
            {
                _subtotal = value;
            }
        }

        private double _descuento = 0.00;
        public double Descuento
        {
            get
            {
                return _descuento;
            }
            set
            {
                _descuento = value;
            }
        }

        private double _impuesto = 0.00;
        public double Impuesto
        {
            get
            {
                return _impuesto;
            }
            set
            {
                _impuesto = value;
            }
        }

        private double _total = 0.00;
        public double Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
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

        private int _idProducto = 0;
        public int IdProducto
        {
            get
            {
                return _idProducto;
            }
            set
            {
                _idProducto = value;
            }
        }

        private double _cantidad = 0.00;
        public double Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }

        private double _precio = 0.00;
        public double Precio
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

        private int _idventa = 0;
        public int IdVenta
        {
            get
            {
                return _idventa;
            }
            set
            {
                _idventa = value;
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
                Comando.Parameters.Add("@Id", SqlDbType.VarChar).Value = cFunciones.IdCliente;
                Comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                if (DS.Tables[0].Rows.Count == 0)
                    throw new Exception("No existe ese RFC");
                DataRow DR = DS.Tables[0].Rows[0];
                this._idcliente = Convert.ToInt32(DR["IdCliente"].ToString());
                this._rfc = DR["RFC"].ToString();
                this._nombreCliente = DR["Nombre"].ToString();
                
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

        public int InsertaDetalleVenta()
        {
            try
            {
                int actualizados = 0;
                int a = ActualizaExistenciaP();

                if (a > 0)
                {
                    

                    AbreConexion();

                    DataSet DS = new DataSet();
                    Comando = new SqlCommand("ConsultaUltimaventa", Conexion);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Adaptador = new SqlDataAdapter(Comando);
                    Adaptador.Fill(DS);

                    DataRow DR = DS.Tables[0].Rows[0];
                    this._idventa = Convert.ToInt32(DR["IdVenta"].ToString());

                    //Guardar detalle venta
                    Comando = new SqlCommand("DetalleVentas", Conexion);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@IdVenta", SqlDbType.VarChar).Value = this.IdVenta;
                    Comando.Parameters.Add("@IdProducto", SqlDbType.VarChar).Value = this.IdProducto;
                    Comando.Parameters.Add("@Cantidad", SqlDbType.VarChar).Value = this.Cantidad;
                    Comando.Parameters.Add("@Precio", SqlDbType.VarChar).Value = this.Precio;

                    Adaptador = new SqlDataAdapter(Comando);

                    actualizados = Comando.ExecuteNonQuery();

                    
                }
                else
                {
                    actualizados = 0;
                }
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

        public int GuardaVenta()
        {

            try
            {
                int a = 0;
                AbreConexion();
                //Guardar ventas
                Comando = new SqlCommand("RegistraVenta", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = cFunciones.IdCliente;
                Comando.Parameters.Add("@FechaVenta", SqlDbType.DateTime).Value = this.FechaVenta;
                Comando.Parameters.Add("@Subtotal", SqlDbType.VarChar).Value = this.Subtotal;
                Comando.Parameters.Add("@Descuento", SqlDbType.VarChar).Value = this.Descuento;
                Comando.Parameters.Add("@Impuesto", SqlDbType.VarChar).Value = this.Impuesto;
                Comando.Parameters.Add("@Total", SqlDbType.VarChar).Value = this.Total;
                Adaptador = new SqlDataAdapter(Comando);
                a = Comando.ExecuteNonQuery();
                return a;
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

        public int ActualizaExistenciaP()
        {
            try
            {
                int a = 0;
                AbreConexion();
                Comando = new SqlCommand("ActualizaExistencias", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdProducto", SqlDbType.VarChar).Value = this.IdProducto;
                Comando.Parameters.Add("@Cantidad", SqlDbType.VarChar).Value = this.Cantidad;
                Adaptador = new SqlDataAdapter(Comando);
                a = Comando.ExecuteNonQuery();
                return a;
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


    }
}
