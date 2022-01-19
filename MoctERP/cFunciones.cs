using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//Librerias conexión BD
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MoctERP
{
    static class cFunciones
    {

        //Aux Ventas
        public static double subtotalpp = 0;
        public static double subtotal = 0;
        public static double impuesto = 0;
        public static double total = 0;
        public static double descuento = 0;
        public static double pdesc = 0;

        public static double Cantidad = 0;
        public static double Precio = 0;


        //General

        public static int BanderaCliente = 0;
        public static int IdCliente = 0;
        public static int IdProveedor = 0;
        public static int IdCP = 0;
        public static int IdColonia = 0;
        public static int IdCiudad = 0;
        public static int IdEstado = 0;
        public static int IdPais = 0;
        public static int IdTelefono = 0;
        public static int IdLinea = 0;
        public static int IdProducto = 0;


        //Declaraciónd e variables de conexión

        static String cadenaConexion = "Server=UTSIT-RMR11\\SQLEXPRESS;Database=MoctERP;Trusted_Connection=True;";
        public static SqlConnection Conexion = null;
        public static SqlCommand Comando = null;
        public static SqlDataAdapter Adaptador = null;


        //Función encargada de crear la conexión a la BD
        public static void AbreConexion()
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
        public static void CierraConexion()
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

        public static DataSet ConsultaCP()
        {
            try
            {

                DataSet DS = new DataSet();
                AbreConexion();
                Comando = new SqlCommand("ConsultaCP", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdCP", SqlDbType.VarChar).Value = IdCP;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                //DataRow DR1 = DS.Tables[0].Rows[0];
                //cFunciones.IdCP = Convert.ToInt32(DR1["IdCP"].ToString());
                if (DS.Tables[0].Rows.Count > 0)
                {
                    return DS;
                }
                else
                    throw new Exception("No existe ese ID de CP");





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

        public static DataSet CargaLinea()
        {
            try
            {

                DataSet DS = new DataSet();
                AbreConexion();
                Comando = new SqlCommand("ConsultaLinea", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                DataRow DR1 = DS.Tables[0].Rows[0];
                if (DS.Tables[0].Rows.Count > 0)
                {
                    return DS;
                }
                else
                    throw new Exception("No existen datos de Linea");
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

        public static DataSet ConsultaCiudad(int IdCp)
        {
            try
            {

                DataSet DS = new DataSet();
                AbreConexion();
                Comando = new SqlCommand("ConsultaCiudad", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@CP", SqlDbType.VarChar).Value = IdCp;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                DataRow DR = DS.Tables[0].Rows[0];


                if (DS.Tables[0].Rows.Count > 0)
                {
                    return DS;
                }
                else
                    throw new Exception("No existe ese ID de CP");

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

        public static DataSet ConsultaEstado(int IdCp)
        {
            try
            {

                DataSet DS = new DataSet();
                AbreConexion();
                Comando = new SqlCommand("ConsultaEstado", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@CP", SqlDbType.VarChar).Value = IdCp;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                DataRow DR = DS.Tables[0].Rows[0];
                //cFunciones.IdEstado = Convert.ToInt32(DR["IdEstado"].ToString());

                if (DS.Tables[0].Rows.Count > 0)
                {
                    return DS;
                }
                else
                    throw new Exception("No existe ese ID de CP");

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

        public static DataSet ConsultaPais(int IdCp)
        {
            try
            {

                DataSet DS = new DataSet();
                AbreConexion();
                Comando = new SqlCommand("ConsultaPais", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@CP", SqlDbType.VarChar).Value = IdCp;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                DataRow DR = DS.Tables[0].Rows[0];
                //cFunciones.IdPais = Convert.ToInt32(DR["IdPais"].ToString());

                if (DS.Tables[0].Rows.Count > 0)
                {
                    return DS;
                }
                else
                    throw new Exception("No existe ese ID de CP");

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

        public static DataSet ConsultaColonia(int CP)
        {
            try
            {

                DataSet DS = new DataSet();
                AbreConexion();
                Comando = new SqlCommand("ConsultaColonia", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@CP", SqlDbType.VarChar).Value = CP;
                Adaptador = new SqlDataAdapter(Comando);
                Adaptador.Fill(DS);

                DataRow DR1 = DS.Tables[0].Rows[0];
                cFunciones.IdCP = Convert.ToInt32(DR1["IdCP"].ToString());
                if (DS.Tables[0].Rows.Count > 0)
                {
                    return DS;
                }
                else
                    throw new Exception("No existe ese ID de CP");





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

        public static void MessageB(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

    }
}
