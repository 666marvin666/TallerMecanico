using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Configuration;

namespace TallerMecanico
{
    public class ConexionBd
    {
        private string connection = string.Empty;
        private SqlConnection connect;
        private SqlCommand command;
        private SqlDataAdapter da;
        private DataTable dt;
        private DataSet ds;
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conect = new SqlConnection("Data Source=DESKTOP-805C1FV\\SQLEXPRESS;Initial Catalog=TallerMecanico; Integrated Security=True");
            Conect.Open();
            return Conect;
        }

       public SqlConnection LeerCadena()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unuica"].ConnectionString);
            if(cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            else
            {
                cn.Open();
            }
            return cn;
        }

    }
}
