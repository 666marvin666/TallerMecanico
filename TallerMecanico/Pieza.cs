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
    class Pieza
    {
        //Atributos
        private string _codigo;
        private string _nombre;
        private double _costoCompra;
        private double _costoVenta;
        private string _proveedor;

        public static int AgregarPieza(string codigo, string nombre, double costoCompra, double costoVenta, string proveedor)
        {
            int res = 0;
            try
            {
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Pieza (Codigo, Nombre, CostoCompra, CostoVenta, Proveedor) values ('{0}','{1}','{2}','{3}','{4}')", codigo, nombre, costoCompra, costoVenta, proveedor), Conect);
                res = Comando.ExecuteNonQuery();
                Conect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrrio un error en el registro");
            }
            return res;
        }

        public static int EliminarPieza(string codigo)
        {
            int res = 0;
            try
            {
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand Comando = new SqlCommand(string.Format("delete Pieza where Codigo = " + codigo), Conect);
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
        public DataTable MostrarPiezas()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MOSTRARPIEZAS", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public override string ToString()
        {
            return "Codigo: " + _codigo + "Nombre: " + _nombre + "Costo Compra: " + _costoCompra + "Costo Venta: " + _costoVenta + "Proveedor: "+_proveedor;
        }
    }
}
