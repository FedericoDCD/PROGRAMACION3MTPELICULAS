namespace ProgrProj
{
    partial class FrmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BttnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblCliente = new System.Windows.Forms.Label();
            this.CmbClientes = new Bunifu.Framework.UI.BunifuDropdown();
            this.BttnVer = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.BttnGenerarVenta = new System.Windows.Forms.Button();
            this.BCDGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Película = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbPelicula = new Bunifu.Framework.UI.BunifuDropdown();
            this.LblPel = new System.Windows.Forms.Label();
            this.BttnAgregar = new System.Windows.Forms.Button();
            this.TxtPrec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.PnlVenta = new System.Windows.Forms.Panel();
            this.PnlVent = new System.Windows.Forms.Panel();
            this.BttnNormalizar = new System.Windows.Forms.Button();
            this.BGVVentas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BCDGrid)).BeginInit();
            this.PnlVenta.SuspendLayout();
            this.PnlVent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BGVVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // BttnSalir
            // 
            this.BttnSalir.FlatAppearance.BorderSize = 0;
            this.BttnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnSalir.Location = new System.Drawing.Point(213, 1);
            this.BttnSalir.Name = "BttnSalir";
            this.BttnSalir.Size = new System.Drawing.Size(66, 45);
            this.BttnSalir.TabIndex = 5;
            this.BttnSalir.Text = "X";
            this.BttnSalir.UseVisualStyleBackColor = true;
            this.BttnSalir.Click += new System.EventHandler(this.BttnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.LblCliente);
            this.panel2.Controls.Add(this.CmbClientes);
            this.panel2.Controls.Add(this.BttnVer);
            this.panel2.Controls.Add(this.TxtID);
            this.panel2.Controls.Add(this.LblID);
            this.panel2.Controls.Add(this.DTPFecha);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.BttnGenerarVenta);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 451);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.LblCliente.Location = new System.Drawing.Point(108, 83);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(63, 19);
            this.LblCliente.TabIndex = 30;
            this.LblCliente.Text = "Cliente:";
            // 
            // CmbClientes
            // 
            this.CmbClientes.BackColor = System.Drawing.Color.Transparent;
            this.CmbClientes.BorderRadius = 3;
            this.CmbClientes.ForeColor = System.Drawing.Color.Gray;
            this.CmbClientes.Items = new string[0];
            this.CmbClientes.Location = new System.Drawing.Point(44, 105);
            this.CmbClientes.Name = "CmbClientes";
            this.CmbClientes.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(150)))));
            this.CmbClientes.onHoverColor = System.Drawing.Color.White;
            this.CmbClientes.selectedIndex = -1;
            this.CmbClientes.Size = new System.Drawing.Size(187, 23);
            this.CmbClientes.TabIndex = 29;
            this.CmbClientes.onItemSelected += new System.EventHandler(this.CmbClientes_onItemSelected);
            // 
            // BttnVer
            // 
            this.BttnVer.BackColor = System.Drawing.Color.White;
            this.BttnVer.FlatAppearance.BorderSize = 0;
            this.BttnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnVer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnVer.ForeColor = System.Drawing.Color.DarkRed;
            this.BttnVer.Location = new System.Drawing.Point(41, 254);
            this.BttnVer.Name = "BttnVer";
            this.BttnVer.Size = new System.Drawing.Size(187, 30);
            this.BttnVer.TabIndex = 22;
            this.BttnVer.Text = "VER VENTAS";
            this.BttnVer.UseVisualStyleBackColor = false;
            this.BttnVer.Click += new System.EventHandler(this.BttnVer_Click);
            // 
            // TxtID
            // 
            this.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtID.Enabled = false;
            this.TxtID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(101, 60);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(109, 20);
            this.TxtID.TabIndex = 20;
            this.TxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtID.Visible = false;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.SystemColors.Control;
            this.LblID.Location = new System.Drawing.Point(63, 61);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(32, 19);
            this.LblID.TabIndex = 21;
            this.LblID.Text = "ID:";
            this.LblID.Visible = false;
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(32, 151);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(206, 20);
            this.DTPFecha.TabIndex = 19;
            this.DTPFecha.ValueChanged += new System.EventHandler(this.DTPFecha_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(108, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha:";
            // 
            // BttnGenerarVenta
            // 
            this.BttnGenerarVenta.BackColor = System.Drawing.Color.White;
            this.BttnGenerarVenta.Enabled = false;
            this.BttnGenerarVenta.FlatAppearance.BorderSize = 0;
            this.BttnGenerarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnGenerarVenta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnGenerarVenta.ForeColor = System.Drawing.Color.DarkRed;
            this.BttnGenerarVenta.Location = new System.Drawing.Point(41, 209);
            this.BttnGenerarVenta.Name = "BttnGenerarVenta";
            this.BttnGenerarVenta.Size = new System.Drawing.Size(187, 30);
            this.BttnGenerarVenta.TabIndex = 3;
            this.BttnGenerarVenta.Text = "GENERAR VENTA";
            this.BttnGenerarVenta.UseVisualStyleBackColor = false;
            this.BttnGenerarVenta.Click += new System.EventHandler(this.BttnGuardar_Click);
            // 
            // BCDGrid
            // 
            this.BCDGrid.AllowUserToAddRows = false;
            this.BCDGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BCDGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.BCDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BCDGrid.BackgroundColor = System.Drawing.Color.White;
            this.BCDGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BCDGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BCDGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BCDGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.BCDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BCDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Película,
            this.Precio});
            this.BCDGrid.DoubleBuffered = true;
            this.BCDGrid.EnableHeadersVisualStyles = false;
            this.BCDGrid.HeaderBgColor = System.Drawing.Color.DarkRed;
            this.BCDGrid.HeaderForeColor = System.Drawing.Color.White;
            this.BCDGrid.Location = new System.Drawing.Point(218, 50);
            this.BCDGrid.Name = "BCDGrid";
            this.BCDGrid.ReadOnly = true;
            this.BCDGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BCDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BCDGrid.Size = new System.Drawing.Size(246, 262);
            this.BCDGrid.TabIndex = 22;
            // 
            // Película
            // 
            this.Película.HeaderText = "Película";
            this.Película.Name = "Película";
            this.Película.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // CmbPelicula
            // 
            this.CmbPelicula.BackColor = System.Drawing.Color.Transparent;
            this.CmbPelicula.BorderRadius = 3;
            this.CmbPelicula.ForeColor = System.Drawing.Color.Gray;
            this.CmbPelicula.Items = new string[0];
            this.CmbPelicula.Location = new System.Drawing.Point(16, 123);
            this.CmbPelicula.Name = "CmbPelicula";
            this.CmbPelicula.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(150)))));
            this.CmbPelicula.onHoverColor = System.Drawing.Color.White;
            this.CmbPelicula.selectedIndex = -1;
            this.CmbPelicula.Size = new System.Drawing.Size(187, 23);
            this.CmbPelicula.TabIndex = 24;
            this.CmbPelicula.onItemSelected += new System.EventHandler(this.BAnoCom_onItemSelected);
            // 
            // LblPel
            // 
            this.LblPel.AutoSize = true;
            this.LblPel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPel.ForeColor = System.Drawing.SystemColors.Control;
            this.LblPel.Location = new System.Drawing.Point(70, 94);
            this.LblPel.Name = "LblPel";
            this.LblPel.Size = new System.Drawing.Size(87, 19);
            this.LblPel.TabIndex = 23;
            this.LblPel.Text = "PELÍCULA:";
            // 
            // BttnAgregar
            // 
            this.BttnAgregar.BackColor = System.Drawing.Color.White;
            this.BttnAgregar.Enabled = false;
            this.BttnAgregar.FlatAppearance.BorderSize = 0;
            this.BttnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnAgregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnAgregar.ForeColor = System.Drawing.Color.DarkRed;
            this.BttnAgregar.Location = new System.Drawing.Point(16, 184);
            this.BttnAgregar.Name = "BttnAgregar";
            this.BttnAgregar.Size = new System.Drawing.Size(187, 30);
            this.BttnAgregar.TabIndex = 22;
            this.BttnAgregar.Text = "AGREGAR";
            this.BttnAgregar.UseVisualStyleBackColor = false;
            this.BttnAgregar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TxtPrec
            // 
            this.TxtPrec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrec.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrec.Location = new System.Drawing.Point(94, 158);
            this.TxtPrec.MaxLength = 8;
            this.TxtPrec.Name = "TxtPrec";
            this.TxtPrec.Size = new System.Drawing.Size(109, 20);
            this.TxtPrec.TabIndex = 25;
            this.TxtPrec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPrec.TextChanged += new System.EventHandler(this.TxtPrec_TextChanged);
            this.TxtPrec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrec_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "PRECIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(214, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "PRECIO TOTAL:";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.LblPrecio.Location = new System.Drawing.Point(362, 10);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(17, 19);
            this.LblPrecio.TabIndex = 28;
            this.LblPrecio.Text = "?";
            // 
            // PnlVenta
            // 
            this.PnlVenta.Controls.Add(this.BCDGrid);
            this.PnlVenta.Controls.Add(this.LblPrecio);
            this.PnlVenta.Controls.Add(this.LblPel);
            this.PnlVenta.Controls.Add(this.label2);
            this.PnlVenta.Controls.Add(this.CmbPelicula);
            this.PnlVenta.Controls.Add(this.TxtPrec);
            this.PnlVenta.Controls.Add(this.BttnAgregar);
            this.PnlVenta.Controls.Add(this.label1);
            this.PnlVenta.Location = new System.Drawing.Point(296, 62);
            this.PnlVenta.Name = "PnlVenta";
            this.PnlVenta.Size = new System.Drawing.Size(479, 356);
            this.PnlVenta.TabIndex = 29;
            this.PnlVenta.Visible = false;
            this.PnlVenta.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlVenta_Paint);
            // 
            // PnlVent
            // 
            this.PnlVent.Controls.Add(this.BttnNormalizar);
            this.PnlVent.Controls.Add(this.BGVVentas);
            this.PnlVent.Location = new System.Drawing.Point(296, 1);
            this.PnlVent.Name = "PnlVent";
            this.PnlVent.Size = new System.Drawing.Size(509, 445);
            this.PnlVent.TabIndex = 23;
            this.PnlVent.Visible = false;
            // 
            // BttnNormalizar
            // 
            this.BttnNormalizar.BackColor = System.Drawing.Color.White;
            this.BttnNormalizar.FlatAppearance.BorderSize = 0;
            this.BttnNormalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnNormalizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnNormalizar.ForeColor = System.Drawing.Color.DarkRed;
            this.BttnNormalizar.Location = new System.Drawing.Point(126, 54);
            this.BttnNormalizar.Name = "BttnNormalizar";
            this.BttnNormalizar.Size = new System.Drawing.Size(187, 30);
            this.BttnNormalizar.TabIndex = 31;
            this.BttnNormalizar.Text = "NORMALIZAR VENTAS";
            this.BttnNormalizar.UseVisualStyleBackColor = false;
            this.BttnNormalizar.Click += new System.EventHandler(this.BttnNormalizar_Click);
            // 
            // BGVVentas
            // 
            this.BGVVentas.AllowUserToAddRows = false;
            this.BGVVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BGVVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.BGVVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BGVVentas.BackgroundColor = System.Drawing.Color.White;
            this.BGVVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BGVVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BGVVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BGVVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.BGVVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BGVVentas.DoubleBuffered = true;
            this.BGVVentas.EnableHeadersVisualStyles = false;
            this.BGVVentas.HeaderBgColor = System.Drawing.Color.DarkRed;
            this.BGVVentas.HeaderForeColor = System.Drawing.Color.White;
            this.BGVVentas.Location = new System.Drawing.Point(21, 90);
            this.BGVVentas.Name = "BGVVentas";
            this.BGVVentas.ReadOnly = true;
            this.BGVVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BGVVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BGVVentas.Size = new System.Drawing.Size(383, 262);
            this.BGVVentas.TabIndex = 29;
            this.BGVVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BGVVentas_CellContentClick);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(280, 450);
            this.Controls.Add(this.PnlVenta);
            this.Controls.Add(this.BttnSalir);
            this.Controls.Add(this.PnlVent);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BCDGrid)).EndInit();
            this.PnlVenta.ResumeLayout(false);
            this.PnlVenta.PerformLayout();
            this.PnlVent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BGVVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BttnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BttnGenerarVenta;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblID;
        private Bunifu.Framework.UI.BunifuCustomDataGrid BCDGrid;
        private Bunifu.Framework.UI.BunifuDropdown CmbPelicula;
        private System.Windows.Forms.Label LblPel;
        private System.Windows.Forms.Button BttnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Película;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.TextBox TxtPrec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Panel PnlVenta;
        private System.Windows.Forms.Button BttnVer;
        private System.Windows.Forms.Panel PnlVent;
        private Bunifu.Framework.UI.BunifuCustomDataGrid BGVVentas;
        private System.Windows.Forms.Label LblCliente;
        private Bunifu.Framework.UI.BunifuDropdown CmbClientes;
        private System.Windows.Forms.Button BttnNormalizar;
    }
}