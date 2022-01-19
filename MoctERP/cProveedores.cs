using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias conexión BD
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MoctERP
{
    class cProveedores
    {

        //Constructor
        public cProveedores()
        {

        }

        //Getters y Setters
        #region
        private int _idproveedor = 0;
        public int Idproveedor
        {
            get
            {
                return _idproveedor;
            }
            set
            {
                _idproveedor = value;
            }
        }

        private string _rfc = "";
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

        private string _nombreProveedor = "";
        public string NombreProveedor
        {
            get
            {
                return _nombreProveedor;
            }
            set
            {
                _nombreProveedor = value;
            }
        }

        private int _cp = 0;
        public int CP
        {
            get
            {
                return _cp;
            }
            set
            {
                _cp = value;
            }
        }

        private int _iDcp = 0;
        public int IdCP
        {
            get
            {
                return _iDcp;
            }
            set
            {
                _iDcp = value;
            }
        }

        private string _calle = "";
        public string Calle
        {
            get
            {
                return _calle;
            }
            set
            {
                _calle = value;
            }
        }

        private string _numeroExt = "";
        public string NumeroExt
        {
            get
            {
                return _numeroExt;
            }
            set
            {
                _numeroExt = value;
            }
        }

        private string _numeroInt = "";
        public string NumeroInt
        {
            get
            {
                return _numeroInt;
            }
            set
            {
                _numeroInt = value;
            }
        }

        private string _conCredito = "";
        public string ConCredito
        {
            get
            {
                return _conCredito;
            }
            set
            {
                _conCredito = value;
            }
        }

        private int _diasCredito = 0;
        public int DiasCredito
        {
            get
            {
                return _diasCredito;
            }
            set
            {
                _diasCredito = value;
            }
        }

        private double _limteCredito = 0;
        public double LimteCredito
        {
            get
            {
                return _limteCredito;
            }
            set
            {
                _limteCredito = value;
            }
        }

        private double _saldo = 0;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }

        private string _email = "";
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        private int _colonia = 0;
        public int Colonia
        {
            get
            {
                return _colonia;
            }
            set
            {
                _colonia = value;
            }
        }

        private int _ciudad = 0;
        public int Ciudad
        {
            get
            {
                return _ciudad;
            }
            set
            {
                _ciudad = value;
            }
        }

        private int _estado = 0;
        public int Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                _estado = value;
            }
        }

        private int _pais = 0;
        public int Pais
        {
            get
            {
                return _pais;
            }
            set
            {
                _pais = value;
            }
        }

        private string _telefono1 = "";
        public string Telefono1
        {
            get
            {
                return _telefono1;
            }
            set
            {
                _telefono1 = value;
            }
        }

        private string _telefono2 = "";
        public string Telefono2
        {
            get
            {
                return _telefono2;
            }
            set
            {
                _telefono2 = value;
            }
        }

        private string _telefono3 = "";
        public string Telefono3
        {
            get
            {
                return _telefono3;
            }
            set
            {
                _telefono3 = value;
            }
        }

        private string _telefono4 = "";
        public string Telefono4
        {
            get
            {
                return _telefono4;
            }
            set
            {
                _telefono4 = value;
            }
        }

        private string _idTelefono = "";
        public string IdTelefono
        {
            get
            {
                return _idTelefono;
            }
            set
            {
                _idTelefono = value;
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

        public int InsertaProveedor()
        {
            try
            {

                GuardaTelefono();
                int actualizados = 0;
                AbreConexion();

                //Obtener último teléfono
                DataSet DS = new DataSet();
                Comando = new SqlCommand("ConsultaUltimoTelefono", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = this.NombreProveedor;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                DataRow DR = DS.Tables[0].Rows[0];
                this._idTelefono = DR["IdTelefono"].ToString();


                Comando = new SqlCommand("RegistraProveedor", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdTelefono", SqlDbType.VarChar).Value = this.IdTelefono;
                Comando.Parameters.Add("@IdCP", SqlDbType.VarChar).Value = cFunciones.IdCP;
                Comando.Parameters.Add("@IdColonia", SqlDbType.VarChar).Value = cFunciones.IdColonia;
                Comando.Parameters.Add("@IdCiudad", SqlDbType.VarChar).Value = cFunciones.IdCiudad;
                Comando.Parameters.Add("@IdEstado", SqlDbType.VarChar).Value = cFunciones.IdEstado;
                Comando.Parameters.Add("@IdPais", SqlDbType.VarChar).Value = cFunciones.IdPais;
                Comando.Parameters.Add("@RFC", SqlDbType.VarChar).Value = this.RFC;
                Comando.Parameters.Add("@NombreProveedor", SqlDbType.VarChar).Value = this.NombreProveedor;
                Comando.Parameters.Add("@Calle", SqlDbType.VarChar).Value = this.Calle;
                Comando.Parameters.Add("@NumeroExt", SqlDbType.VarChar).Value = this.NumeroExt;
                Comando.Parameters.Add("@NumeroInt", SqlDbType.VarChar).Value = this.NumeroInt;
                Comando.Parameters.Add("@ConCredito", SqlDbType.VarChar).Value = this.ConCredito;
                Comando.Parameters.Add("@DiasCredito", SqlDbType.VarChar).Value = this.DiasCredito;
                Comando.Parameters.Add("@LimteCredito", SqlDbType.VarChar).Value = this.LimteCredito;
                Comando.Parameters.Add("@Saldo", SqlDbType.VarChar).Value = this.Saldo;
                Comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = this.Email;
                Comando.Parameters.Add("@Estatus", SqlDbType.VarChar).Value = this.Estatus;

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

        public int ModificaProveedor()
        {
            try
            {

                ModificaTelefono();
                int actualizados = 0;
                AbreConexion();


                Comando = new SqlCommand("ModificaProveedor", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdProveedor", SqlDbType.VarChar).Value = cFunciones.IdProveedor;
                Comando.Parameters.Add("@IdTelefono", SqlDbType.VarChar).Value = cFunciones.IdTelefono;
                Comando.Parameters.Add("@IdCP", SqlDbType.VarChar).Value = cFunciones.IdCP;
                Comando.Parameters.Add("@IdColonia", SqlDbType.VarChar).Value = cFunciones.IdColonia;
                Comando.Parameters.Add("@IdCiudad", SqlDbType.VarChar).Value = cFunciones.IdCiudad;
                Comando.Parameters.Add("@IdEstado", SqlDbType.VarChar).Value = cFunciones.IdEstado;
                Comando.Parameters.Add("@IdPais", SqlDbType.VarChar).Value = cFunciones.IdPais;
                Comando.Parameters.Add("@RFC", SqlDbType.VarChar).Value = this.RFC;
                Comando.Parameters.Add("@Nombreproveedor", SqlDbType.VarChar).Value = this.NombreProveedor;
                Comando.Parameters.Add("@Calle", SqlDbType.VarChar).Value = this.Calle;
                Comando.Parameters.Add("@NumeroExt", SqlDbType.VarChar).Value = this.NumeroExt;
                Comando.Parameters.Add("@NumeroInt", SqlDbType.VarChar).Value = this.NumeroInt;
                Comando.Parameters.Add("@ConCredito", SqlDbType.VarChar).Value = this.ConCredito;
                Comando.Parameters.Add("@DiasCredito", SqlDbType.VarChar).Value = this.DiasCredito;
                Comando.Parameters.Add("@LimteCredito", SqlDbType.VarChar).Value = this.LimteCredito;
                Comando.Parameters.Add("@Saldo", SqlDbType.VarChar).Value = this.Saldo;
                Comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = this.Email;

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

        public DataSet ConsultaProveedores(string Nombre)
        {
            try
            {

                DataSet DS = new DataSet();
                AbreConexion();
                Comando = new SqlCommand("ConsultaTabla", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                if (DS.Tables[0].Rows.Count > 0)
                {
                    return DS;
                }
                else
                    throw new Exception("No existe el proveedor");

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

        public void ConsultaUno(string Valor)
        {
            try
            {
                DataSet DS = new DataSet();


                AbreConexion();
                Comando = new SqlCommand("ConsultaUnaEntidad", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id", SqlDbType.VarChar).Value = cFunciones.IdProveedor;
                Comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = Valor;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                if (DS.Tables[0].Rows.Count == 0)
                    throw new Exception("No existe ese Proveedor");
                DataRow DR = DS.Tables[0].Rows[0];
                this._idproveedor = Convert.ToInt32(DR["IdProveedor"].ToString());
                this._rfc = DR["RFC"].ToString();
                this._nombreProveedor = DR["Nombre"].ToString();
                this._calle = DR["Calle"].ToString();
                this._numeroExt = DR["NumeroExt"].ToString();
                this._numeroInt = DR["NumeroInt"].ToString();
                this._iDcp = Convert.ToInt32(DR["IdCP"].ToString());
                cFunciones.IdCP = Convert.ToInt32(DR["IdCP"].ToString());
                this._conCredito = DR["ConCredito"].ToString();
                this._diasCredito = Convert.ToInt32(DR["DiasCredito"].ToString());
                this._limteCredito = Convert.ToDouble(DR["LimteCredito"].ToString());
                this._saldo = Convert.ToDouble(DR["Saldo"].ToString());
                this._email = DR["Email"].ToString();
                this._estatus = DR["Estatus"].ToString();
                this._idTelefono = DR["IdTelefono"].ToString();

                //Teléfono
                DataSet DST = new DataSet();
                Comando = new SqlCommand("ConsultaTelefono", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdTelefono", SqlDbType.VarChar).Value = this._idTelefono;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DST);

                if (DST.Tables[0].Rows.Count == 0)
                    throw new Exception("No existe ese Telefono");
                DataRow DRT = DST.Tables[0].Rows[0];

                this._telefono1 = DRT["Telefono1"].ToString();
                this._telefono2 = DRT["Telefono2"].ToString();
                this._telefono3 = DRT["Telefono3"].ToString();
                this._telefono4 = DRT["Telefono4"].ToString();

                //Dirección
                DataSet DSD = new DataSet();
                Comando = new SqlCommand("ConsultaDireccion", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdCP", SqlDbType.VarChar).Value = this._iDcp;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DSD);

                if (DSD.Tables[0].Rows.Count == 0)
                    throw new Exception("No existe ese CP");
                DataRow DRD = DSD.Tables[0].Rows[0];

                this._colonia = Convert.ToInt32(DRD["IdColonia"].ToString());
                this._ciudad = Convert.ToInt32(DRD["IdCiudad"].ToString());
                this._estado = Convert.ToInt32(DRD["IdEstado"].ToString());
                this._pais = Convert.ToInt32(DRD["IdPais"].ToString());

                cFunciones.IdColonia = this._colonia;
                cFunciones.IdCiudad = this._ciudad;
                cFunciones.IdEstado = this._estado;
                cFunciones.IdPais = this._pais;
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

        public int EliminaProveedor(string Nombre)
        {
            try
            {
                int Actualizados = 0;

                AbreConexion();
                Comando = new SqlCommand("EliminaRegistroTabla", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
                Comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = this.Idproveedor;

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

        public void GuardaTelefono()
        {


            try
            {

                AbreConexion();
                //Guardar Telefonos
                Comando = new SqlCommand("RegistraTelefono", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Telefono1", SqlDbType.VarChar).Value = this.Telefono1;
                Comando.Parameters.Add("@Telefono2", SqlDbType.VarChar).Value = this.Telefono2;
                Comando.Parameters.Add("@Telefono3", SqlDbType.VarChar).Value = this.Telefono3;
                Comando.Parameters.Add("@Telefono4", SqlDbType.VarChar).Value = this.Telefono4;
                Adaptador = new SqlDataAdapter(Comando);
                Comando.ExecuteNonQuery();
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

        public void ModificaTelefono()
        {

            try
            {

                AbreConexion();
                //Guardar Telefonos
                Comando = new SqlCommand("ModificaTelefono", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdTelefono", SqlDbType.VarChar).Value = cFunciones.IdTelefono;
                Comando.Parameters.Add("@Telefono1", SqlDbType.VarChar).Value = this.Telefono1;
                Comando.Parameters.Add("@Telefono2", SqlDbType.VarChar).Value = this.Telefono2;
                Comando.Parameters.Add("@Telefono3", SqlDbType.VarChar).Value = this.Telefono3;
                Comando.Parameters.Add("@Telefono4", SqlDbType.VarChar).Value = this.Telefono4;
                Adaptador = new SqlDataAdapter(Comando);
                Comando.ExecuteNonQuery();
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
