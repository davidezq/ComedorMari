using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComedorMari.Factory
{
    public abstract class AccionesBD
    {
        public abstract void Insertar(List<string>Datos);
        public abstract void Mostrar();
    }
}
