using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico
{
    class Empleado
    {
        public static int CrearCuenta(string usuario, string contrasena)
        {
            int res = 0;
            try
            {
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuarios (Nombre, Contrasena) values ('{0}', PwdEncrypt('{1}'))", usuario, contrasena), Conect);
                res = Comando.ExecuteNonQuery();
                Conect.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Error al registrar nuevo usuario");
            }
            return res;
        }

        public static int Autentificar(string usuario, string contrasena)
        {
            int res = -1;
            SqlConnection Conect = ConexionBd.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("Select * From Usuarios Where Nombre = '{0}' and PwdCompare('{1}', Contrasena) =1", usuario, contrasena), Conect);
            SqlDataReader reader = Comando.ExecuteReader();
            
            while (reader.Read())
            {
                res = 50;
            }
            
            Conect.Close();
            return res;
        }

    }
}
