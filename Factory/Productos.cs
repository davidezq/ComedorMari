using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

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
                    using (var comando = new MySqlCommand($"INSERT INTO `productos`(`Nombre`,`Precio`) VALUES (\'{Datos[0]}\',{double.Parse(Datos[1])})", conexion))
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
        public override void Mostrar(DataGridView grid)
        {
            
            using (var conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString))
            {
                    conexion.Open();
                    using (var comando = new MySqlCommand($"SELECT * FROM productos", conexion))
                    {
                      
                        MySqlDataAdapter da = new MySqlDataAdapter(comando);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        conexion.Close();

                    }
            }
               
        }

        public override void LlenarCombo(ComboBox cb)
        {
            throw new NotImplementedException();
        }

        public override void IngresarCompra(List<string> Datos) 
        {
            using (var conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand($"INSERT INTO `listado_compras` VALUES (default,{int.Parse(Datos[0])},{int.Parse(Datos[1])})", conexion))
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

        public override void LlenarDetalle(DataGridView grid, string Num)
        {
            using (var conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString))
            {
                conexion.Open();
                using (var comando = new MySqlCommand($"SELECT productos.Nombre,productos.Precio FROM listado_compras INNER JOIN productos ON listado_compras.Codigo_Producto = productos.Codigo_Producto INNER JOIN clientes on listado_compras.Codigo_Cliente = clientes.Codigo_Cliente WHERE clientes.Codigo_Cliente="+Num, conexion))
                {

                    MySqlDataAdapter da = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    grid.DataSource = dt;

                    conexion.Close();

                }
            }

        }


    }
}

