using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;


namespace ComedorMari.Factory
{
    class Clientes:AccionesBD
    {

        Menu nuevo = new Menu();

        public override void Insertar(List<string> Datos)
        {
            using (var conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand($"INSERT INTO `Clientes`(`Nombre`,`Apellido`,`Telefono`) VALUES (\'{Datos[0]}\',\'{Datos[1]}\',{int.Parse(Datos[2])})", conexion))
                    {
                        comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Producto agregado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message + " " + Datos[0] + " " + Datos[1] + " " + Datos[2]);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }

        public override void Mostrar(DataGridView grid)
        {

            using (var conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString))
            {
                
                    conexion.Open();
                    using (var comando = new MySqlCommand($"SELECT Nombre FROM Cliente", conexion))
                    {
                        //comando.ExecuteNonQuery();
                        MySqlDataAdapter da = new MySqlDataAdapter(comando);
                        DataTable dt = new DataTable();

                        da.Fill(dt);
                        conexion.Close();

                    }
                   
                

            }
        }

    }
}
