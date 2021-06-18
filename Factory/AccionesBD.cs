using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ComedorMari.Factory
{
    public abstract class AccionesBD
    {
        public abstract void Insertar(List<string>Datos);
        public abstract void Mostrar(DataGridView grid);

        public abstract void LlenarCombo(ComboBox cb);

        //
        public abstract void IngresarCompra(List<string> Datos);

        public abstract void LlenarDetalle(DataGridView grid, string Num);

        public abstract void Factura(int id,int total);

    }
}
