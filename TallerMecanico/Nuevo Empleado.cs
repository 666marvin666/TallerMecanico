using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class Nuevo_Empleado : Form
    {
        public Nuevo_Empleado()
        {
            InitializeComponent();
        }

        private void Nuevo_Empleado_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtContraAdd.Text == txtConfirmar.Text)
            {
                if (Empleado.CrearCuenta(txtUsuarioAdd.Text, txtContraAdd.Text)>0)
                {
                    MessageBox.Show("Cuenta creada :)");
                }
                else
                {
                    MessageBox.Show("No se pudo crear la cuenta :(");
                }
            }
        }
    }
}
