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
    public partial class MenuPrincipal : Form
    {
        CatalogoClientes log;
        CatalogoAutos log2;
        CatalogoPiezas log3;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            log = new CatalogoClientes();
            log.Show();
        }

        private void btnAutos_Click(object sender, EventArgs e)
        {
            log2 = new CatalogoAutos();
            log2.Show();
        }

        private void btnPiezas_Click(object sender, EventArgs e)
        {
            log3 = new CatalogoPiezas();
            log3.Show();
        }
    }
}
