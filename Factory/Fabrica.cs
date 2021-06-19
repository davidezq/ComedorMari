using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComedorMari.Factory
{
    //la clase fábrica que nos ayudará a crear las clases Clientes y Productos
    public class Fabrica
    {
        public const int Clientes = 1;
        public const int Productos = 2;
        public const int Facturas = 3;
        
        public static AccionesBD AccionesTablas(int tipo)
        {
            switch (tipo)
            {
                case Clientes:
                    return new Clientes();
                case Productos:
                    return new Productos();
                default:
                    return null;
            }
        }
    }
}
