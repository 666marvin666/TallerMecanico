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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        
        Nuevo_Empleado loggin;
        MenuPrincipal log;
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (Empleado.Autentificar(txtUsuario.Text,txtContrasena.Text)>0)
            {
                log = new MenuPrincipal();
                log.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            loggin = new Nuevo_Empleado();
            loggin.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
