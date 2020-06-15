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
    public partial class CatalogoAutos : Form
    {
        ConexionBd bd = new ConexionBd();
        public CatalogoAutos()
        {
            InitializeComponent();
        }
        Auto aut = new Auto();
        private void CatalogoAutos_Load(object sender, EventArgs e)
        {
            dgvDetalles.DataSource = aut.MostrarAutos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Auto.AgregarAuto(txtPlaca.Text, txtModelo.Text, txtMarca.Text, txtColor.Text, txtDueño.Text) > 0)
            {
                MessageBox.Show("Auto agregado :)");
                dgvDetalles.DataSource = aut.MostrarAutos();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el Auto :(");
            }
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtColor.Clear();
            txtDueño.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Auto.EliminarAuto(txtPlaca.Text) > 0)
            {
                MessageBox.Show("Auto eliminado");
                dgvDetalles.DataSource = aut.MostrarAutos();
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtColor.Clear();
            txtDueño.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (txtColor != null)
            {
                string query = "UPDATE Automovil SET Color = @Color where Placa = @Placa";
                SqlConnection Conect = ConexionBd.ObtenerConexion();
                SqlCommand comando = new SqlCommand(query, Conect);
                comando.Parameters.AddWithValue("@Color", txtColor.Text);
                comando.Parameters.AddWithValue("@Placa", txtPlaca.Text);
                comando.ExecuteNonQuery();
                Conect.Close();
            }
           
            dgvDetalles.DataSource = aut.MostrarAutos();
        }
    }
}
