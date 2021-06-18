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
            cmda.Mostrar(dgvProductosFactura);
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
          
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            List<String> DatosCliente = new List<string>();
            DatosCliente.Add(txbNombreCliente.Text);
            DatosCliente.Add(txbApellido.Text);
            DatosCliente.Add(txbTelefonoCliente.Text);
            AccionesBD agregar = Fabrica.AccionesTablas(Fabrica.Clientes);
            agregar.Insertar(DatosCliente);
            cbClientesFacturas.Items.Clear();
            cmda2.LlenarCombo(cbClientesFacturas);







        }

        private void lbxDetalleFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbClientesFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Unido;
            char delimitador = '-';

            Unido = cbClientesFacturas.SelectedItem.ToString();

            string[] valores = Unido.Split(delimitador);

           cmda.LlenarDetalle(dgvDetalle, valores[0]);

            double SumTotal = 0;
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    SumTotal += (double)row.Cells[1].Value;
                }

                

            }

            lbtotal.Text = "$" + SumTotal.ToString();




        }

        private void dgvProductosFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

           



            cmda.Mostrar(dgvProductosFactura);
         
            cmda2.LlenarCombo(cbClientesFacturas);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresarFacturas_Click(object sender, EventArgs e)
        {
            List<String> DatosDetalle= new List<string>();

            string Unido;
            char delimitador = '-';
            
            Unido = cbClientesFacturas.SelectedItem.ToString();

            string[] valores = Unido.Split(delimitador);

            DatosDetalle.Add(valores[0]);

            DatosDetalle.Add(dgvProductosFactura.CurrentCell.Value.ToString());

            AccionesBD agregar = Fabrica.AccionesTablas(Fabrica.Productos);

            agregar.IngresarCompra(DatosDetalle);




        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void lblDetalleFactura_Click(object sender, EventArgs e)
        {

        }
    }
}
