using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;

namespace TallerMecanico
{
    class Cliente
    {
        //Atributos 
        private string _RFC ="";
        private string _nombre = "";
        private string _telefono = "";
        private string _domicilio = "";
        private string _correo = "";

        //Metodo constructor
        
        public override string ToString()
        {
            return "RFC: " + _RFC + "Nombre: " + _nombre + "Telefono: " + _telefono + "Domicilio: " + _domicilio + "Correo: " + _correo; 
        }

        public static int AgregarCliente(string rfc, string nombre, string domicilio, string telefono, string correo)
        {
            int res = 0;
            try
            {
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Cliente (RFC, nombre, domicilio, telefono, correo) values ('{0}','{1}','{2}','{3}','{4}')", rfc, nombre, domicilio, telefono, correo), Conect);
                res = Comando.ExecuteNonQuery();
                Conect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrrio un error en el registro");
            }
            return res;
        }

        public static int EliminarCliente(string rfc)
        {
            int res = 0;
            try
            {
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand Comando = new SqlCommand(string.Format("delete Cliente where RFC = " + rfc), Conect);
                res = Comando.ExecuteNonQuery();
                Conect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrrio un error al eliminar");
            }
            
            return res;
        }


        ConexionBd cn = new ConexionBd();
        public DataTable MostrarClientes()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARCLIENTES",cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        } 
    }
}
