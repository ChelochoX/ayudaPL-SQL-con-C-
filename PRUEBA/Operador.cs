using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PRUEBA
{
    public partial class Operador : Form
    {
        public Operador()
        {
            InitializeComponent();
        }

        //string conn = ConfigurationManager.ConnectionStrings["CONECTAR"].ConnectionString;
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CONECTAR"].ConnectionString);
        //SqlConnection conn = new SqlConnection("Server=DESKTOP-6MM02FV;Data Source=BB DE PRUEBA;User ID=clezano;Password=Cesar1983");
       
        Conexion objConexion = new Conexion();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter daDpto = new SqlDataAdapter();


        private void Operador_Load(object sender, EventArgs e)
        {
            try
            {
                string qry = "SELECT * FROM P_DEPARTAMENTO";
                cmd.Connection = objConexion.ObtenerConexion();
                cmd.CommandText = qry;
                daDpto.SelectCommand = cmd;
                DataTable dtDpto = new DataTable("P_DEPARTAMENTO");
                daDpto.Fill(dtDpto);
                //CARGAMOS EL COMBO BOX
                this.cbDepartamento.DataSource = dtDpto;
                this.cbDepartamento.DisplayMember = "NOMBRE";

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objConexion.DescargarConexion();
            }
        }
    }
}