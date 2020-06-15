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
    public partial class CatalogoClientes : Form
    {
        ConexionBd bd = new ConexionBd();
        public CatalogoClientes()
        {
            InitializeComponent();
        }
        Cliente cli = new Cliente();
        private void CatalogoClientes_Load(object sender, EventArgs e)
        {
            dgvDetalles.DataSource = cli.MostrarClientes();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cliente.AgregarCliente(txtRFC.Text, txtNombre.Text, txtDomicilio.Text, txtTelefono.Text, txtCorreo.Text) > 0)
            {
                MessageBox.Show("Cliente agregado :)");
                dgvDetalles.DataSource = cli.MostrarClientes();
            }
            else
            {
                MessageBox.Show("No se pudo agregar al cliente :(");
            }
            txtRFC.Clear();
            txtNombre.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Cliente.EliminarCliente(txtRFC.Text)>0)
            {
                MessageBox.Show("Cliente eliminado");
                dgvDetalles.DataSource = cli.MostrarClientes();
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
            txtRFC.Clear();
            txtNombre.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == null)
            {
                
            }
            else
            {
                string query = "UPDATE Cliente SET nombre = @nombre where RFC = @RFC";
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand comando = new SqlCommand(query, Conect);
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@RFC", txtRFC.Text);
                comando.ExecuteNonQuery();
                Conect.Close();
            }
            

            if (txtDomicilio.Text == null)
            {
                
            }
            else
            {
                string query = "UPDATE Cliente SET domicilio = @domicilio where RFC = @RFC";
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand comando = new SqlCommand(query, Conect);
                comando.Parameters.AddWithValue("@domicilio", txtDomicilio.Text);
                comando.Parameters.AddWithValue("@RFC", txtRFC.Text);
                comando.ExecuteNonQuery();
                Conect.Close();
            }
            

            if (txtTelefono.Text == null)
            {
               
            }
            else
            {
                string query = "UPDATE Cliente SET telefono = @telefono where RFC = @RFC";
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand comando = new SqlCommand(query, Conect);
                comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                comando.Parameters.AddWithValue("@RFC", txtRFC.Text);
                comando.ExecuteNonQuery();
                Conect.Close();
            }
            

            if (txtCorreo.Text == null)
            {
                
            }
            else
            {
                string query = "UPDATE Cliente SET correo = @correo where RFC = @RFC";
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand comando = new SqlCommand(query, Conect);
                comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                comando.Parameters.AddWithValue("@RFC", txtRFC.Text);
                comando.ExecuteNonQuery();
                Conect.Close();
            }
         

            dgvDetalles.DataSource = cli.MostrarClientes();

        }
    }
}
