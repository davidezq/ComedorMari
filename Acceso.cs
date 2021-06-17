using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComedorMari
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txbUsuario.Text;
            string contrasenia = txbContrasenia.Text;
            if (usuario == "mari" && contrasenia == "12345")
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }
    }
}
