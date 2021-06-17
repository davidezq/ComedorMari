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
        Productos cmda = new Productos();
        Clientes cmda2 = new Clientes();
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
            txbTelefonoCliente.Clear();
            txbNombreProducto.Clear();
            mtxbPrecioProducto.Clear();
            nudCantidadProducto.Value = 0;
            lbxDetalleFactura.Items.Clear();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            List<String> DatosCliente = new List<string>();
            DatosCliente.Add(txbNombreCliente.Text);
            DatosCliente.Add(txbApellido.Text);
            DatosCliente.Add(txbTelefonoCliente.Text);
            AccionesBD agregar = Fabrica.AccionesTablas(Fabrica.Clientes);
            agregar.Insertar(DatosCliente);


       
            
        }

        private void lbxDetalleFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbClientesFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {

            //cmda2.Mostrar();
        }

        private void dgvProductosFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            cmda.Mostrar(dgvProductosFactura);
        }
    }
}
