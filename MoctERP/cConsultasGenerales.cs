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
    class cConsultasGenerales
    {
        public cConsultasGenerales()
        {

        }

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

        public DataSet ConsultaT(string Nombre, string bsq)
        {
            try
            {

                DataSet DS = new DataSet();
                AbreConexion();
                Comando = new SqlCommand("ConsultaTablaCampo", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
                //Comando.Parameters.Add("@Valor", SqlDbType.VarChar).Value = ID;
                Comando.Parameters.Add("@ValorB", SqlDbType.VarChar).Value = bsq;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                if (DS.Tables[0].Rows.Count > 0)
                {
                    return DS;
                }
                else
                    return DS;
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

        public DataSet ConsultaT2(string Nombre)
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
                    throw new Exception("No se encontro infomración");
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
