using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MoctERP
{
    class cUsuario
    {

        public cUsuario()
        {

        }

        private string _usuario = "";
        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

        private string _contrasena = "";
        public string Contrasena
        {
            get
            {
                return _contrasena;
            }
            set
            {
                _contrasena = value;
            }
        }

        //Variables globales (3 variables para cualquier conexión)
        String cadenaConexion = "Server=DEL-SIS-001\\SQLEXPRESS;Database=MoctERP;Trusted_Connection=True;";
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

        //Funcion encargada de lanzar el procedimiento almacenado en la base de datos para validar el usuario
        public bool ValidaUsuario(string Usuario)
        {
            try
            {
               
                DataSet DS = new DataSet();
                AbreConexion();
                Comando = new SqlCommand("ConsultaUsuario", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                if (DS.Tables[0].Rows.Count > 0)
                {

                    DataRow DR = DS.Tables[0].Rows[0];
                    this._usuario = DR["Usuario"].ToString();
                    this._contrasena = DR["Contrasena"].ToString();
                }

                if (DS.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;


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
