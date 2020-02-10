using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRUEBA
{
     static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        //public static string CONECTAR;
        //public SqlConnection SQLConexion = new SqlConnection("SERVER=DESKTOP-6MM02FV;DATABASE=BB DE PRUEBA;Uid=clezcano;Pwd=Cesar1983");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Operador());                                
        }
    }
    
   
    }

