using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PRUEBA
{
     public class Conexion
        {
            public SqlConnection conexion = new SqlConnection();

            public SqlConnection ObtenerConexion()
            {
             conexion = new SqlConnection("Password=Cesar1983;Persist Security Info=True;User ID=clezcano;Initial Catalog=BB DE PRUEBA;Data Source=DESKTOP-6MM02FV");
                try
                {
                    conexion.Open();
                    return conexion;
                    
                }
                    
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public bool DescargarConexion()
            {
                conexion.Dispose();
                return true;
            }
        }
    }
