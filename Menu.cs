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
using Microsoft.VisualBasic;

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
        private void cbClientesFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDetalleCliente();
        }
        private void MostrarDetalleCliente()
        {
            string Unido;
            char delimitador = '-';
            Unido = cbClientesFacturas.SelectedItem.ToString();
            string[] valores = Unido.Split(delimitador);
            cmda.LlenarDetalle(dgvDetalle, valores[0]);
            lbtotal.Text = "$" + TotalPagar();
            
        }
        private string TotalPagar()
        {
            double SumTotal = 0;
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    SumTotal += (double)row.Cells[1].Value * (int)row.Cells[2].Value;
                }
            }
            return SumTotal.ToString();
        }
        private void Menu_Load(object sender, EventArgs e)
        { 
            cmda.Mostrar(dgvProductosFactura);
            cmda2.LlenarCombo(cbClientesFacturas);
            cbClientesFacturas.SelectedItem=null;
        }
        private void btnIngresarFacturas_Click(object sender, EventArgs e)
        {
            List<String> DatosDetalle= new List<string>();
            string Unido;
            char delimitador = '-';
            Unido = cbClientesFacturas.SelectedItem.ToString();
            string[] valores = Unido.Split(delimitador);
            var cantidad = Interaction.InputBox("Cantidad", dgvProductosFactura.CurrentRow.Cells[1].Value.ToString());
            //agregando datos a la lista
            DatosDetalle.Add(valores[0]);
            DatosDetalle.Add(dgvProductosFactura.CurrentCell.Value.ToString());
            DatosDetalle.Add(cantidad);
            AccionesBD agregar = Fabrica.AccionesTablas(Fabrica.Productos);
            agregar.IngresarCompra(DatosDetalle);
            //Actualiza los DataGridView
            cmda.Mostrar(dgvProductosFactura);
            MostrarDetalleCliente();
        }

        private void btnFacturarFacturas_Click(object sender, EventArgs e)
        {
            AccionesBD agregar = Fabrica.AccionesTablas(Fabrica.Productos);
            string Unido;
            char delimitador = '-';
            Unido = cbClientesFacturas.SelectedItem.ToString();
            string[] valores = Unido.Split(delimitador);
            string dia = DateTime.Now.ToString("dddd");
            if(dia.ToLower()=="sábado" || dia.ToLower() == "saturday")
            {
                agregar.Factura(int.Parse(valores[0]),int.Parse(TotalPagar()));
            }
            else
            {
                MessageBox.Show("Sólo se puede facturar los días sábados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MostrarDetalleCliente();
        }
    }
}
