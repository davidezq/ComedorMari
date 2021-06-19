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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;

namespace ComedorMari.Factory
{
    class Productos : AccionesBD
    {
        //Clase que realiza todas las tareas relacionadas con la base de datos

        //Procedimiento
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
                    string dato="";
                    //buscar producto: if(esta el producto):añadir cantidad else:crearlo
                    using (var comando = new MySqlCommand($"SELECT Cantidad_Producto FROM listado_compras where Codigo_Producto ={int.Parse(Datos[1])} and Codigo_Cliente={int.Parse(Datos[0])}",conexion))
                    using (var lector = comando.ExecuteReader())
                    {
                       while (lector.Read())
                       {
                             dato = lector.GetString(0);
                       }
                    }
                       if (dato != string.Empty)
                       {
                           using (var comando = new MySqlCommand($"UPDATE listado_compras SET Cantidad_Producto = (Cantidad_Producto + {int.Parse(Datos[2])}) WHERE Codigo_Producto = {int.Parse(Datos[1])};",conexion))
                           {
                               comando.ExecuteNonQuery();
                           }
                       }
                    else
                    {
                            using (var comando = new MySqlCommand($"INSERT INTO `listado_compras` VALUES (default,{int.Parse(Datos[0])},{int.Parse(Datos[1])},{int.Parse(Datos[2])})", conexion))
                            {
                                comando.ExecuteNonQuery();
                            }
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
                using (var comando = new MySqlCommand($"SELECT productos.Nombre,productos.Precio,listado_compras.Cantidad_Producto FROM listado_compras INNER JOIN productos ON listado_compras.Codigo_Producto = productos.Codigo_Producto INNER JOIN clientes on listado_compras.Codigo_Cliente = clientes.Codigo_Cliente WHERE clientes.Codigo_Cliente="+Num, conexion))
                {

                    MySqlDataAdapter da = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    grid.DataSource = dt;
                }
                conexion.Close();
            }
        }
        public override void Factura(int idCliente,int total)
        {
            
            //Preparando el documento
            PdfFont fuenteColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fuenteContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            string[] columnas = { "Nombre", "Precio unitario", "Cantidad Total" };
            float[] tamañios = { 4, 3, 3 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamañios));
            tabla.SetWidth(UnitValue.CreatePercentValue(90));
            string nombreCompleto="";
            var consumo = new Paragraph("Consumo:");
            var totalPagar = new Paragraph("El total a pagar es de: $"+total.ToString());
            //Construyendo tabla
            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fuenteColumnas).SetTextAlignment(TextAlignment.CENTER)));
            }
            //obteniendo datos de la base
            using (var conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysql"].ConnectionString))
            {
                conexion.Open();
                //Datos para la tabla
                using (var comando = new MySqlCommand($"SELECT productos.Nombre,productos.Precio,listado_compras.Cantidad_Producto FROM listado_compras INNER JOIN productos ON listado_compras.Codigo_Producto = productos.Codigo_Producto INNER JOIN clientes on listado_compras.Codigo_Cliente = clientes.Codigo_Cliente WHERE clientes.Codigo_Cliente=" + idCliente, conexion))
                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                    {
                        tabla.AddCell(new Cell().Add(new Paragraph(lector[0].ToString()).SetFont(fuenteContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(lector[1].ToString()).SetFont(fuenteContenido)));
                        tabla.AddCell(new Cell().Add(new Paragraph(lector[2].ToString()).SetFont(fuenteContenido)));
                    }
                //Dato del nombre
                using (var comando = new MySqlCommand($"SELECT Nombre,Apellido FROM clientes WHERE Codigo_Cliente={idCliente}", conexion))
                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                    {
                        nombreCompleto = (lector[0].ToString()+" "+lector[1].ToString());
                    }
                //Borrando los pedidos de la bd
                using (var comando = new MySqlCommand($"DELETE FROM listado_compras WHERE Codigo_Cliente={idCliente}", conexion))
                {
                    comando.ExecuteNonQuery();
                }
                    conexion.Close();
            }
            //Creando el archivo pdf
            PdfWriter escritorPdf = new PdfWriter($"Factura-{nombreCompleto}.pdf");
            PdfDocument pdf = new PdfDocument(escritorPdf);
            //Creando hoja de trabajo
            Document documento = new Document(pdf, PageSize.LETTER);
            //Margenes del documento
            documento.SetMargins(25, 30, 25, 30);

            #region Escribiendo los datos al documento
            documento.Add(new Paragraph("Nombre Completo: "+nombreCompleto));
            documento.Add(consumo);
            documento.Add(tabla);
            documento.Add(totalPagar);
            #endregion Escribiendo los datos al documento

            //Cerrando el documento
            documento.Close();
            MessageBox.Show("Factura generada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}

