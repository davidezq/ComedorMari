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
    class Clientes : AccionesBD
    {
        //inserta Clientes a la base de datos
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
                    MessageBox.Show("Cliente agregado correctamente", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
        //para llenar el combobox del apartado de factura
        public string id_cliente;
        public override void LlenarCombo(ComboBox cb)
        {
            using (var conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (var comando = new MySqlCommand($"SELECT Codigo_cliente, Nombre FROM clientes", conexion))
                    {
                        MySqlDataReader dr;

                        dr = comando.ExecuteReader();
                        
                        while (dr.Read())
                        {
                            cb.Items.Add(dr["Codigo_cliente"].ToString() + " - " + dr["Nombre"].ToString());
                       
                        }
                        dr.Close();

                    }

                  

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("No se lleno el ComboBox: " + Ex.ToString());
                }
                finally
                {
                    conexion.Close();
                }
            }
        }


        public override void IngresarCompra(List<string> Datos) 
        {
        }


        public override void LlenarDetalle(DataGridView grid, string Num)
        {
        }

        public override void Factura(int idCliente)
        {
        }
    }

}

