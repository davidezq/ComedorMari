using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace ComedorMari.Factory
{
    class Productos : AccionesBD
    {
        public override void Insertar(List<string> Datos)
        {
            using (var conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand($"INSERT INTO `productos`(`Nombre`,`Precio`,`Stock`) VALUES (\'{Datos[0]}\',{double.Parse(Datos[1])},{int.Parse(Datos[2])})", conexion))
                    {
                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Producto agregado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message+" "+Datos[0]+" "+Datos[1]+" "+Datos[2]);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
        public override void Mostrar()
        {
        }
    }
}
