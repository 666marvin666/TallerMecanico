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
    class Auto
    {
        //Atributos
        private string _placa;
        private string _marca;
        private string _modelo;
        private string _color;

        //Metodo constructor
        public static int AgregarAuto(string placa, string marca, string modelo, string color, string rfc)
        {
            int res = 0;
            try
            {
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Automovil (Placa, Marca, Modelo, Color, RFC_Cliente) values ('{0}','{1}','{2}','{3}','{4}')", placa, marca, modelo, color, rfc), Conect);
                res = Comando.ExecuteNonQuery();
                Conect.Close();
                
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrrio un error en el registro");
            }
            return res;
        }

        public static int EliminarAuto(string placa)
        {
            int res = 0;
            try
            {
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand Comando = new SqlCommand(string.Format("delete Automovil where Placa = " + placa), Conect);
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
        public DataTable MostrarAutos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARAUTOS ", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public override string ToString()
        {
            return "Placa: " + _placa + "Marca: " + _marca + "Modelo: " + _modelo + "Color: " + _color;
        }
    }
}
