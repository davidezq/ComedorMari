using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ComedorMari.Factory
{
    //Clase abstract para implementar Factory method
    //En esta clase estan las diferentes funciones que heredaran la clase clientes y la clase productos
    public abstract class AccionesBD
    {
        //pensada para insertar datos a la base de datos
        public abstract void Insertar(List<string>Datos);
        //pensada para mostrar datos en un datagridview
        public abstract void Mostrar(DataGridView grid);
        //pensada para llenar un combobox
        public abstract void LlenarCombo(ComboBox cb);

        //Pensada para ingresar las compras
        public abstract void IngresarCompra(List<string> Datos);
        //Pensada para llenar detalle de los clientes
        public abstract void LlenarDetalle(DataGridView grid, string Num);
        //Pensada para imprimir facturas o reportes
        public abstract void Factura(int id);

    }
}
