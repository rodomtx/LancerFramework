using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data.SqlClient;

namespace Templeate_LIN
{
    public class CRUD
    {
        private string sql_connection_string = ConfigurationManager.ConnectionStrings["datastore"].ConnectionString;
        private SqlConnection sql_conexion;
        private SqlDataReader rdr = null;
        private SqlCommand command = null;

        public CRUD()
        {

            sql_conexion = new SqlConnection(sql_connection_string);
            SqlDataReader rdr = null;
        }


        public bool Test()
        {
            /* solo hace una conexion a la base de datos para verificar que este disponible
             * se usa antes de cualquier operacion para asegurarnos este arriba la DB
             */

            bool res;
            try
            {
                this.sql_conexion.Open();
                this.sql_conexion.Close();
                res = true;

            }
            catch (Exception e)
            {
                res = false;
                Console.WriteLine("*** CRUD.Test() - " + e.Message + " ***");
            }

            return res;
        }


        public bool solicitarRetrabajo(string _tipo, string _owner , string _descripcion, string _serieFG, string _lineaSolicita, string _coldplateserie)
        {
            bool ans = true;

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.crearRework", this.sql_conexion);
                this.command.Parameters.Add(new SqlParameter("@tipo", _tipo));
                this.command.Parameters.Add(new SqlParameter("@owner", _owner));
                this.command.Parameters.Add(new SqlParameter("@descripcion", _descripcion));
                this.command.Parameters.Add(new SqlParameter("@serialFG", _serieFG));
                this.command.Parameters.Add(new SqlParameter("@lineaSolicita", _lineaSolicita));
                this.command.Parameters.Add(new SqlParameter("@serialColdplate", _coldplateserie));
                this.command.Parameters.Add(new SqlParameter("@status", 1));
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();
                this.command.ExecuteNonQuery();
                this.sql_conexion.Close();
                ans = true;
            }
            else
            { ans = false; }

            return ans;
            /*
             * ans true todo OK , ans false = hubo mermas
             */
        }



        public List<reworkItem> listaReworkItems()
        {

            List<reworkItem> ans = new List<reworkItem>();

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.readReworkInventory", sql_conexion);
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();
                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans.Add(new reworkItem(this.rdr.GetInt32(0), this.rdr.GetString(1), this.rdr.GetString(2), this.rdr.GetInt32(3), this.rdr.GetDateTime(4), this.rdr.GetInt32(5), this.rdr.GetString(6), this.rdr.GetString(7), this.rdr.GetInt32(8), this.rdr.GetString(9), this.rdr.GetString(10), this.rdr.GetInt32(11), this.rdr.GetString(12), this.rdr.GetString(13), this.rdr.GetInt32(14), this.rdr.GetString(15), this.rdr.GetString(16)) );

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("*** SQL.ListaBuildorder) - " + e.Message + " ***");
                }
                finally
                {
                    this.sql_conexion.Close();
                }
            }

            return ans;
        }


        public bool crearusuario(string _nombre, string _correo, string _hash)
        {
            bool ans = true;

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.crearUsuario", this.sql_conexion);
                this.command.Parameters.Add(new SqlParameter("@friendlyName", _nombre));
                this.command.Parameters.Add(new SqlParameter("@correo", _correo));
                this.command.Parameters.Add(new SqlParameter("@hash", _hash));
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    this.sql_conexion.Open();
                    this.command.ExecuteNonQuery();
                    this.sql_conexion.Close();
                    ans = true;
                }
                catch (Exception e)
                {
                    ans = false;
                }
            }
            else
            { ans = false; }

            return ans;
            /*
             * ans true todo OK , ans false = hubo mermas
             */
        }


        public int validarCredenciales(string _correo,string _hash)
        {

            int ans = -1;

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.readValidarCredenciales", sql_conexion);
                this.command.Parameters.Add(new SqlParameter("@correo", _correo));
                this.command.Parameters.Add(new SqlParameter("@hash", _hash));
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();
                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans = this.rdr.GetInt32(0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("*** SQL.ListaBuildorder) - " + e.Message + " ***");
                }
                finally
                {
                    this.sql_conexion.Close();
                }
            }

            return ans;
        }


        public bool VerificarAcceso(string _correo, int _permiso)
        {

            bool ans = false;

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.readVerificarAcceso", sql_conexion);
                this.command.Parameters.Add(new SqlParameter("@correo", _correo));
                this.command.Parameters.Add(new SqlParameter("@permiso", _permiso));
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();
                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans = this.rdr.GetBoolean(0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("*** SQL.ListaBuildorder) - " + e.Message + " ***");
                }
                finally
                {
                    this.sql_conexion.Close();
                }
            }

            return ans;
        }

        public List<areaItem> listaAreas()
        {

            List<areaItem> ans = new List<areaItem>();

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.readAreas", sql_conexion);
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();
                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans.Add(new areaItem(this.rdr.GetString(0), this.rdr.GetString(1)));

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("*** SQL.ListaBuildorder) - " + e.Message + " ***");
                }
                finally
                {
                    this.sql_conexion.Close();
                }
            }

            return ans;
        }

    }

}