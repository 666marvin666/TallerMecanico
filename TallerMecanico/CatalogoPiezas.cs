using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TallerMecanico
{
    public partial class CatalogoPiezas : Form
    {
        public CatalogoPiezas()
        {
            InitializeComponent();
        }
        ConexionBd bd = new ConexionBd();
        Pieza pz = new Pieza();
        private void CatalogoPiezas_Load(object sender, EventArgs e)
        {
            dgvDetalles.DataSource = pz.MostrarPiezas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (Pieza.AgregarPieza(txtCodigo.Text, txtNombre.Text, Convert.ToDouble(txtCostoC.Text), Convert.ToDouble(txtCostoV.Text), txtProveedor.Text) > 0)
            {
                MessageBox.Show("Pieza agregada :)");
                dgvDetalles.DataSource = pz.MostrarPiezas();
            }
            else
            {
                MessageBox.Show("No se pudo agregar la pieza :(");
            }
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCostoC.Clear();
            txtCostoV.Clear();
            txtProveedor.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Pieza.EliminarPieza(txtCodigo.Text) > 0)
            {
                MessageBox.Show("Pieza eliminada");
                dgvDetalles.DataSource = pz.MostrarPiezas();
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCostoC.Clear();
            txtCostoV.Clear();
            txtProveedor.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            if (txtNombre != null)
            {
                string query = "UPDATE Pieza SET Nombre = @Nombre where Codigo = @Codigo";
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand comando = new SqlCommand(query, Conect);
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                comando.ExecuteNonQuery();
                Conect.Close();
            }
          

            if (txtCostoC != null)
            {
                string query = "UPDATE Pieza SET CostoCompra = @CostoCompra where Codigo = @Codigo";
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand comando = new SqlCommand(query, Conect);
                comando.Parameters.AddWithValue("@CostoCompra", txtCostoC.Text);
                comando.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                comando.ExecuteNonQuery();
                Conect.Close();
            }
           

            if (txtCostoV != null)
            {
                string query = "UPDATE Pieza SET CostoVenta = @CostoVenta where Codigo = @Codigo";
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand comando = new SqlCommand(query, Conect);
                comando.Parameters.AddWithValue("@CostoVenta",txtCostoV.Text);
                comando.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                comando.ExecuteNonQuery();
                Conect.Close();
            }
           

            if (txtProveedor != null)
            {
                string query = "UPDATE Pieza SET Proveedor = @Proveedor where Codigo = @Codigo";
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand comando = new SqlCommand(query, Conect);
                comando.Parameters.AddWithValue("@Proveedor", txtProveedor.Text);
                comando.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                comando.ExecuteNonQuery();
                Conect.Close();
            }

            dgvDetalles.DataSource = pz.MostrarPiezas();

        }
    
    }
}
