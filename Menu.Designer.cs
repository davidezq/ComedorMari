namespace ComedorMari
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.mtxbTelefonoCliente = new System.Windows.Forms.MaskedTextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbNombreCliente = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre_Cliente = new System.Windows.Forms.Label();
            this.lblAgregarCliente = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mtxbPrecioProducto = new System.Windows.Forms.MaskedTextBox();
            this.btnIngresarProducto = new System.Windows.Forms.Button();
            this.nudCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.txbNombreProducto = new System.Windows.Forms.TextBox();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblAgregarProducto = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbxDetalleFactura = new System.Windows.Forms.ListBox();
            this.btnIngresarFacturas = new System.Windows.Forms.Button();
            this.btnFacturarFacturas = new System.Windows.Forms.Button();
            this.dgvProductosFactura = new System.Windows.Forms.DataGridView();
            this.cbxClientesFacturas = new System.Windows.Forms.ComboBox();
            this.lblClienteFactura = new System.Windows.Forms.Label();
            this.lblDetalleFactura = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProducto)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(441, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.btnAgregarCliente);
            this.tabPage1.Controls.Add(this.mtxbTelefonoCliente);
            this.tabPage1.Controls.Add(this.txbApellido);
            this.tabPage1.Controls.Add(this.txbNombreCliente);
            this.tabPage1.Controls.Add(this.lblTelefono);
            this.tabPage1.Controls.Add(this.lblApellido);
            this.tabPage1.Controls.Add(this.lblNombre_Cliente);
            this.tabPage1.Controls.Add(this.lblAgregarCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarCliente.Location = new System.Drawing.Point(279, 245);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(124, 32);
            this.btnAgregarCliente.TabIndex = 16;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            // 
            // mtxbTelefonoCliente
            // 
            this.mtxbTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbTelefonoCliente.Location = new System.Drawing.Point(129, 135);
            this.mtxbTelefonoCliente.Mask = "99999999";
            this.mtxbTelefonoCliente.Name = "mtxbTelefonoCliente";
            this.mtxbTelefonoCliente.Size = new System.Drawing.Size(85, 27);
            this.mtxbTelefonoCliente.TabIndex = 15;
            this.mtxbTelefonoCliente.Text = "25252525";
            this.mtxbTelefonoCliente.ValidatingType = typeof(int);
            // 
            // txbApellido
            // 
            this.txbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellido.Location = new System.Drawing.Point(114, 99);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(100, 27);
            this.txbApellido.TabIndex = 14;
            // 
            // txbNombreCliente
            // 
            this.txbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreCliente.Location = new System.Drawing.Point(114, 66);
            this.txbNombreCliente.Name = "txbNombreCliente";
            this.txbNombreCliente.Size = new System.Drawing.Size(100, 27);
            this.txbNombreCliente.TabIndex = 13;
            this.txbNombreCliente.Text = "Juan Carlos";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.lblTelefono.Location = new System.Drawing.Point(21, 135);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(102, 25);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.lblApellido.Location = new System.Drawing.Point(21, 102);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(95, 25);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre_Cliente
            // 
            this.lblNombre_Cliente.AutoSize = true;
            this.lblNombre_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.lblNombre_Cliente.Location = new System.Drawing.Point(21, 68);
            this.lblNombre_Cliente.Name = "lblNombre_Cliente";
            this.lblNombre_Cliente.Size = new System.Drawing.Size(87, 25);
            this.lblNombre_Cliente.TabIndex = 10;
            this.lblNombre_Cliente.Text = "Nombre:";
            // 
            // lblAgregarCliente
            // 
            this.lblAgregarCliente.AutoSize = true;
            this.lblAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.lblAgregarCliente.Location = new System.Drawing.Point(19, 15);
            this.lblAgregarCliente.Name = "lblAgregarCliente";
            this.lblAgregarCliente.Size = new System.Drawing.Size(272, 39);
            this.lblAgregarCliente.TabIndex = 9;
            this.lblAgregarCliente.Text = "Agregar Cliente";
            this.lblAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.mtxbPrecioProducto);
            this.tabPage2.Controls.Add(this.btnIngresarProducto);
            this.tabPage2.Controls.Add(this.nudCantidadProducto);
            this.tabPage2.Controls.Add(this.txbNombreProducto);
            this.tabPage2.Controls.Add(this.lblCantidadProducto);
            this.tabPage2.Controls.Add(this.lblPrecioProducto);
            this.tabPage2.Controls.Add(this.lblNombreProducto);
            this.tabPage2.Controls.Add(this.lblAgregarProducto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(433, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos";
            // 
            // mtxbPrecioProducto
            // 
            this.mtxbPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbPrecioProducto.Location = new System.Drawing.Point(100, 101);
            this.mtxbPrecioProducto.Mask = "90.00";
            this.mtxbPrecioProducto.Name = "mtxbPrecioProducto";
            this.mtxbPrecioProducto.Size = new System.Drawing.Size(100, 30);
            this.mtxbPrecioProducto.TabIndex = 18;
            // 
            // btnIngresarProducto
            // 
            this.btnIngresarProducto.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIngresarProducto.FlatAppearance.BorderSize = 0;
            this.btnIngresarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarProducto.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIngresarProducto.Location = new System.Drawing.Point(287, 199);
            this.btnIngresarProducto.Name = "btnIngresarProducto";
            this.btnIngresarProducto.Size = new System.Drawing.Size(124, 32);
            this.btnIngresarProducto.TabIndex = 17;
            this.btnIngresarProducto.Text = "Ingresar";
            this.btnIngresarProducto.UseVisualStyleBackColor = false;
            // 
            // nudCantidadProducto
            // 
            this.nudCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadProducto.Location = new System.Drawing.Point(120, 137);
            this.nudCantidadProducto.Name = "nudCantidadProducto";
            this.nudCantidadProducto.Size = new System.Drawing.Size(47, 30);
            this.nudCantidadProducto.TabIndex = 6;
            // 
            // txbNombreProducto
            // 
            this.txbNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreProducto.Location = new System.Drawing.Point(114, 65);
            this.txbNombreProducto.Name = "txbNombreProducto";
            this.txbNombreProducto.Size = new System.Drawing.Size(100, 30);
            this.txbNombreProducto.TabIndex = 4;
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.Location = new System.Drawing.Point(21, 139);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(97, 25);
            this.lblCantidadProducto.TabIndex = 3;
            this.lblCantidadProducto.Text = "Cantidad:";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProducto.Location = new System.Drawing.Point(21, 104);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(73, 25);
            this.lblPrecioProducto.TabIndex = 2;
            this.lblPrecioProducto.Text = "Precio:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(21, 68);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(87, 25);
            this.lblNombreProducto.TabIndex = 1;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // lblAgregarProducto
            // 
            this.lblAgregarProducto.AutoSize = true;
            this.lblAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProducto.Location = new System.Drawing.Point(19, 15);
            this.lblAgregarProducto.Name = "lblAgregarProducto";
            this.lblAgregarProducto.Size = new System.Drawing.Size(304, 39);
            this.lblAgregarProducto.TabIndex = 0;
            this.lblAgregarProducto.Text = "Agregar Producto";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.lbxDetalleFactura);
            this.tabPage3.Controls.Add(this.btnIngresarFacturas);
            this.tabPage3.Controls.Add(this.btnFacturarFacturas);
            this.tabPage3.Controls.Add(this.dgvProductosFactura);
            this.tabPage3.Controls.Add(this.cbxClientesFacturas);
            this.tabPage3.Controls.Add(this.lblClienteFactura);
            this.tabPage3.Controls.Add(this.lblDetalleFactura);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(433, 381);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Facturas";
            // 
            // lbxDetalleFactura
            // 
            this.lbxDetalleFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDetalleFactura.FormattingEnabled = true;
            this.lbxDetalleFactura.ItemHeight = 25;
            this.lbxDetalleFactura.Items.AddRange(new object[] {
            "Sopa",
            "Carne"});
            this.lbxDetalleFactura.Location = new System.Drawing.Point(264, 39);
            this.lbxDetalleFactura.Name = "lbxDetalleFactura";
            this.lbxDetalleFactura.Size = new System.Drawing.Size(161, 79);
            this.lbxDetalleFactura.TabIndex = 20;
            // 
            // btnIngresarFacturas
            // 
            this.btnIngresarFacturas.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIngresarFacturas.FlatAppearance.BorderSize = 0;
            this.btnIngresarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarFacturas.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarFacturas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIngresarFacturas.Location = new System.Drawing.Point(11, 89);
            this.btnIngresarFacturas.Name = "btnIngresarFacturas";
            this.btnIngresarFacturas.Size = new System.Drawing.Size(124, 32);
            this.btnIngresarFacturas.TabIndex = 19;
            this.btnIngresarFacturas.Text = "Ingresar";
            this.btnIngresarFacturas.UseVisualStyleBackColor = false;
            // 
            // btnFacturarFacturas
            // 
            this.btnFacturarFacturas.BackColor = System.Drawing.Color.Red;
            this.btnFacturarFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturarFacturas.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturarFacturas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFacturarFacturas.Location = new System.Drawing.Point(301, 331);
            this.btnFacturarFacturas.Name = "btnFacturarFacturas";
            this.btnFacturarFacturas.Size = new System.Drawing.Size(124, 32);
            this.btnFacturarFacturas.TabIndex = 18;
            this.btnFacturarFacturas.Text = "Facturar";
            this.btnFacturarFacturas.UseVisualStyleBackColor = false;
            // 
            // dgvProductosFactura
            // 
            this.dgvProductosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosFactura.Location = new System.Drawing.Point(8, 127);
            this.dgvProductosFactura.Name = "dgvProductosFactura";
            this.dgvProductosFactura.Size = new System.Drawing.Size(417, 188);
            this.dgvProductosFactura.TabIndex = 3;
            // 
            // cbxClientesFacturas
            // 
            this.cbxClientesFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClientesFacturas.FormattingEnabled = true;
            this.cbxClientesFacturas.Location = new System.Drawing.Point(11, 39);
            this.cbxClientesFacturas.Name = "cbxClientesFacturas";
            this.cbxClientesFacturas.Size = new System.Drawing.Size(155, 33);
            this.cbxClientesFacturas.TabIndex = 2;
            // 
            // lblClienteFactura
            // 
            this.lblClienteFactura.AutoSize = true;
            this.lblClienteFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteFactura.Location = new System.Drawing.Point(8, 11);
            this.lblClienteFactura.Name = "lblClienteFactura";
            this.lblClienteFactura.Size = new System.Drawing.Size(79, 25);
            this.lblClienteFactura.TabIndex = 1;
            this.lblClienteFactura.Text = "Cliente:";
            // 
            // lblDetalleFactura
            // 
            this.lblDetalleFactura.AutoSize = true;
            this.lblDetalleFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleFactura.Location = new System.Drawing.Point(259, 11);
            this.lblDetalleFactura.Name = "lblDetalleFactura";
            this.lblDetalleFactura.Size = new System.Drawing.Size(82, 25);
            this.lblDetalleFactura.TabIndex = 0;
            this.lblDetalleFactura.Text = "Detalles";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 407);
            this.Controls.Add(this.tabControl1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProducto)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.MaskedTextBox mtxbTelefonoCliente;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbNombreCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre_Cliente;
        private System.Windows.Forms.Label lblAgregarCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnIngresarProducto;
        private System.Windows.Forms.NumericUpDown nudCantidadProducto;
        private System.Windows.Forms.TextBox txbNombreProducto;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblAgregarProducto;
        private System.Windows.Forms.Button btnFacturarFacturas;
        private System.Windows.Forms.DataGridView dgvProductosFactura;
        private System.Windows.Forms.ComboBox cbxClientesFacturas;
        private System.Windows.Forms.Label lblClienteFactura;
        private System.Windows.Forms.Label lblDetalleFactura;
        private System.Windows.Forms.MaskedTextBox mtxbPrecioProducto;
        private System.Windows.Forms.Button btnIngresarFacturas;
        private System.Windows.Forms.ListBox lbxDetalleFactura;
    }
}