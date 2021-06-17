using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComedorMari.Factory;

namespace ComedorMari
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresarProducto_Click(object sender, EventArgs e)
        {
            List<string> Datos = new List<string>();
            Datos.Add(txbNombreProducto.Text);
            Datos.Add(mtxbPrecioProducto.Text);
            Datos.Add(nudCantidadProducto.Value.ToString());
            AccionesBD agregar = Fabrica.AccionesTablas(Fabrica.Productos);
            agregar.Insertar(Datos);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            BorrarCampos();
        }
        private void BorrarCampos()
        {
            txbNombreCliente.Clear();
            txbApellido.Clear();
            mtxbTelefonoCliente.Clear();
            txbNombreProducto.Clear();
            mtxbPrecioProducto.Clear();
            nudCantidadProducto.Value = 0;
            lbxDetalleFactura.Items.Clear();
        }
    }
}
