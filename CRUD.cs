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

        public string solicitarRetrabajo(
                                            string _tipo,
                                            string _machinePN,
                                            string _machineSN,
                                            string _coldplateSN,
                                            string _owner ,
                                            string _lineaSolicita,
                                            string _motivo
                                                                                        
                                        )
        {
            int ans = 0;

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.rwSolicitarRetrabajo", this.sql_conexion);
                this.command.Parameters.Add(new SqlParameter("@tipo", _tipo));
                this.command.Parameters.Add(new SqlParameter("@machinePN", _machinePN));
                this.command.Parameters.Add(new SqlParameter("@owner", _owner));
                this.command.Parameters.Add(new SqlParameter("@motivo", _motivo));
                this.command.Parameters.Add(new SqlParameter("@machineSN", _machineSN));
                this.command.Parameters.Add(new SqlParameter("@lineaSolicita", _lineaSolicita));
                this.command.Parameters.Add(new SqlParameter("@coldplateSN", _coldplateSN));
                
                
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();
                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans=this.rdr.GetInt32(0);
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
            else
            { ans =0; }

            return ans.ToString();
           
        }

        public List<REWORK> listaReworkTransito()
        {

            List<REWORK> ans = new List<REWORK>();

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.rwInventory", sql_conexion);
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();
                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans.Add(new REWORK(
                                            this.rdr.GetInt32(0),
                                            this.rdr.GetString(1), 
                                            this.rdr.GetString(2),
                                            this.rdr.GetDateTime(3),
                                            
                                            this.rdr.GetString(4),
                                            this.rdr.GetString(5),
                                            this.rdr.GetString(6),

                                            this.rdr.GetInt32(7),
                                            this.rdr.GetString(8),
                                            this.rdr.GetString(9),

                                            this.rdr.GetInt32(10),
                                            this.rdr.GetString(11),
                                            this.rdr.GetString(12),
                                            
                                            this.rdr.GetInt32(13),
                                            this.rdr.GetString(14),
                                            this.rdr.GetString(15),

                                            this.rdr.GetInt32(16),
                                            this.rdr.GetString(17),
                                            this.rdr.GetString(18),

                                            this.rdr.GetInt32(19),
                                            this.rdr.GetString(20),
                                            this.rdr.GetString(21),

                                            this.rdr.GetInt32(22),
                                            this.rdr.GetString(23),
                                            this.rdr.GetString(24),

                                               this.rdr.GetInt32(25),
                                            this.rdr.GetString(26),
                                            this.rdr.GetString(27)


                                            ));

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

        public List<REWORK> listaReworkHospital()
        {

            List<REWORK> ans = new List<REWORK>();

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.rwHospital", sql_conexion);
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();
                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans.Add(new REWORK(
                                            this.rdr.GetInt32(0),
                                            this.rdr.GetString(1),
                                            this.rdr.GetString(2),
                                            this.rdr.GetDateTime(3),

                                            this.rdr.GetString(4),
                                            this.rdr.GetString(5),
                                            this.rdr.GetString(6),

                                            this.rdr.GetInt32(7),
                                            this.rdr.GetString(8),
                                            this.rdr.GetString(9),

                                            this.rdr.GetInt32(10),
                                            this.rdr.GetString(11),
                                            this.rdr.GetString(12),

                                            this.rdr.GetInt32(13),
                                            this.rdr.GetString(14),
                                            this.rdr.GetString(15),

                                            this.rdr.GetInt32(16),
                                            this.rdr.GetString(17),
                                            this.rdr.GetString(18),

                                            this.rdr.GetInt32(19),
                                            this.rdr.GetString(20),
                                            this.rdr.GetString(21),

                                            this.rdr.GetInt32(22),
                                            this.rdr.GetString(23),
                                            this.rdr.GetString(24),

                                               this.rdr.GetInt32(25),
                                            this.rdr.GetString(26),
                                            this.rdr.GetString(27)


                                            ));

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

        public List<REWORK> listaReworkFundidora()
        {

            List<REWORK> ans = new List<REWORK>();

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.rwFundidora", sql_conexion);
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();
                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans.Add(new REWORK(
                                            this.rdr.GetInt32(0),
                                            this.rdr.GetString(1),
                                            this.rdr.GetString(2),
                                            this.rdr.GetDateTime(3),

                                            this.rdr.GetString(4),
                                            this.rdr.GetString(5),
                                            this.rdr.GetString(6),

                                            this.rdr.GetInt32(7),
                                            this.rdr.GetString(8),
                                            this.rdr.GetString(9),

                                            this.rdr.GetInt32(10),
                                            this.rdr.GetString(11),
                                            this.rdr.GetString(12),

                                            this.rdr.GetInt32(13),
                                            this.rdr.GetString(14),
                                            this.rdr.GetString(15),

                                            this.rdr.GetInt32(16),
                                            this.rdr.GetString(17),
                                            this.rdr.GetString(18),

                                            this.rdr.GetInt32(19),
                                            this.rdr.GetString(20),
                                            this.rdr.GetString(21),

                                            this.rdr.GetInt32(22),
                                            this.rdr.GetString(23),
                                            this.rdr.GetString(24),

                                               this.rdr.GetInt32(25),
                                            this.rdr.GetString(26),
                                            this.rdr.GetString(27)


                                            ));

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

        public List<REWORKDETAILS> detallesReworkItemas(int _operacion)
        {
            List<REWORKDETAILS> ans = new List<REWORKDETAILS>();

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.rwDetallesRetrabajo", sql_conexion);
                this.command.CommandType = System.Data.CommandType.StoredProcedure;
                this.command.Parameters.Add(new SqlParameter("@operacion", _operacion));

                this.sql_conexion.Open();
                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans.Add(new REWORKDETAILS(
                                            this.rdr.GetInt32(0),
                                            
                                            this.rdr.GetString(1),
                                            this.rdr.GetString(2),
                                            this.rdr.GetString(3),
                                            this.rdr.GetString(4),
                                            this.rdr.GetString(5),
                                            this.rdr.GetString(6),

                                            this.rdr.GetDateTime(7),
                                            this.rdr.GetDateTime(8),
                                            this.rdr.GetDateTime(9),
                                            this.rdr.GetDateTime(10),
                                            this.rdr.GetDateTime(11),
                                            this.rdr.GetDateTime(12),
                                            this.rdr.GetDateTime(13),
                                            this.rdr.GetDateTime(14)

                                            ));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("*** SQL.detallesReworkItema) - " + e.Message + " ***");
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
                this.command = new SqlCommand("dbo.validarCredenciales", sql_conexion);
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

        public bool verificarAcceso(string _correo, int _permiso)
        {

            bool ans = false;

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.verificarAcceso", sql_conexion);
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

        public List<AREA> listaAreas()
        {

            List<AREA> ans = new List<AREA>();

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.rwListarAreas", sql_conexion);
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();
                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans.Add(new AREA(this.rdr.GetString(0), this.rdr.GetString(1)));

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

        public List<RAZON> listaRazones()
        {

            List<RAZON> ans = new List<RAZON>();

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.rwListarRazones", sql_conexion);
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();
                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans.Add(new RAZON(this.rdr.GetInt32(0), this.rdr.GetString(1)));

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

        public bool actualizarRetrabajo(int _operacionRaiz, string _operacion, string _observacion , string _usuario)
        {
            bool ans = true;

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.rwActualizar", this.sql_conexion);
                this.command.Parameters.Add(new SqlParameter("@operacionRaiz", _operacionRaiz));
                this.command.Parameters.Add(new SqlParameter("@operacion", _operacion));
                this.command.Parameters.Add(new SqlParameter("@observacion", _observacion));
                this.command.Parameters.Add(new SqlParameter("@usuario", _usuario));
                
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

        public List<BUSQUEDARW> listaBusqueda(string _parametro , string _tipo)
        {

            List<BUSQUEDARW> ans = new List<BUSQUEDARW>();

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.rwBusqueda", sql_conexion);
                this.command.Parameters.Add(new SqlParameter("@parametro", _parametro));
                this.command.Parameters.Add(new SqlParameter("@tipo", _tipo));

                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();
                
                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans.Add(new BUSQUEDARW(this.rdr.GetInt32(0), this.rdr.GetString(1), this.rdr.GetDateTime(2), this.rdr.GetString(3), this.rdr.GetString(4), this.rdr.GetString(5), this.rdr.GetString(6)));

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("*** SQL.listaBusqueda) - " + e.Message + " ***");
                }
                finally
                {
                    this.sql_conexion.Close();
                }
            }

            return ans;
        }

        public List<string> listaCorreosPermiso(string _permiso)
        {

            List<string> ans = new List<string>();

            if (this.Test())
            {
                this.command = new SqlCommand("dbo.rwDireccionesPorPermisos", sql_conexion);
                this.command.Parameters.Add(new SqlParameter("@permiso", _permiso));
                
                this.command.CommandType = System.Data.CommandType.StoredProcedure;

                this.sql_conexion.Open();

                this.rdr = this.command.ExecuteReader();

                try
                {
                    while (this.rdr.Read())
                    {
                        ans.Add(this.rdr.GetString(0) );

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("*** SQL.listaBusqueda) - " + e.Message + " ***");
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