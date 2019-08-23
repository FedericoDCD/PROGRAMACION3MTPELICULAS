namespace ProgrProj
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.BttnGuardar = new System.Windows.Forms.Button();
            this.BttnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BttnModificar = new System.Windows.Forms.Button();
            this.BttnBaja = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BCDGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.BAnoCom = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.LblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BCDGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTitulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(130, 137);
            this.TxtTitulo.MaxLength = 50;
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(109, 20);
            this.TxtTitulo.TabIndex = 2;
            this.TxtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTitulo.TextChanged += new System.EventHandler(this.TxtTitulo_TextChanged);
            // 
            // BttnGuardar
            // 
            this.BttnGuardar.BackColor = System.Drawing.Color.White;
            this.BttnGuardar.FlatAppearance.BorderSize = 0;
            this.BttnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnGuardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnGuardar.ForeColor = System.Drawing.Color.DarkRed;
            this.BttnGuardar.Location = new System.Drawing.Point(130, 253);
            this.BttnGuardar.Name = "BttnGuardar";
            this.BttnGuardar.Size = new System.Drawing.Size(109, 30);
            this.BttnGuardar.TabIndex = 3;
            this.BttnGuardar.Text = "GUARDAR";
            this.BttnGuardar.UseVisualStyleBackColor = false;
            this.BttnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BttnSalir
            // 
            this.BttnSalir.FlatAppearance.BorderSize = 0;
            this.BttnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnSalir.Location = new System.Drawing.Point(825, -2);
            this.BttnSalir.Name = "BttnSalir";
            this.BttnSalir.Size = new System.Drawing.Size(66, 45);
            this.BttnSalir.TabIndex = 4;
            this.BttnSalir.Text = "X";
            this.BttnSalir.UseVisualStyleBackColor = true;
            this.BttnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(52, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "TÍTULO:";
            // 
            // BttnModificar
            // 
            this.BttnModificar.BackColor = System.Drawing.Color.White;
            this.BttnModificar.Enabled = false;
            this.BttnModificar.FlatAppearance.BorderSize = 0;
            this.BttnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnModificar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnModificar.ForeColor = System.Drawing.Color.DarkRed;
            this.BttnModificar.Location = new System.Drawing.Point(130, 289);
            this.BttnModificar.Name = "BttnModificar";
            this.BttnModificar.Size = new System.Drawing.Size(109, 30);
            this.BttnModificar.TabIndex = 6;
            this.BttnModificar.Text = "MODIFICAR";
            this.BttnModificar.UseVisualStyleBackColor = false;
            this.BttnModificar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BttnBaja
            // 
            this.BttnBaja.BackColor = System.Drawing.Color.White;
            this.BttnBaja.Enabled = false;
            this.BttnBaja.FlatAppearance.BorderSize = 0;
            this.BttnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnBaja.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnBaja.ForeColor = System.Drawing.Color.DarkRed;
            this.BttnBaja.Location = new System.Drawing.Point(130, 325);
            this.BttnBaja.Name = "BttnBaja";
            this.BttnBaja.Size = new System.Drawing.Size(109, 30);
            this.BttnBaja.TabIndex = 7;
            this.BttnBaja.Text = "BAJA";
            this.BttnBaja.UseVisualStyleBackColor = false;
            this.BttnBaja.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BCDGrid);
            this.panel1.Location = new System.Drawing.Point(303, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 254);
            this.panel1.TabIndex = 8;
            // 
            // BCDGrid
            // 
            this.BCDGrid.AllowUserToAddRows = false;
            this.BCDGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BCDGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BCDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BCDGrid.BackgroundColor = System.Drawing.Color.White;
            this.BCDGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BCDGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BCDGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BCDGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BCDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BCDGrid.DoubleBuffered = true;
            this.BCDGrid.EnableHeadersVisualStyles = false;
            this.BCDGrid.HeaderBgColor = System.Drawing.Color.DarkRed;
            this.BCDGrid.HeaderForeColor = System.Drawing.Color.White;
            this.BCDGrid.Location = new System.Drawing.Point(0, 0);
            this.BCDGrid.Name = "BCDGrid";
            this.BCDGrid.ReadOnly = true;
            this.BCDGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BCDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BCDGrid.Size = new System.Drawing.Size(545, 251);
            this.BCDGrid.TabIndex = 0;
            this.BCDGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BCDGrid_CellClick);
            this.BCDGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BCDGrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(47, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "GÉNERO:";
            // 
            // TxtGenero
            // 
            this.TxtGenero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtGenero.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGenero.Location = new System.Drawing.Point(130, 163);
            this.TxtGenero.MaxLength = 50;
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(109, 20);
            this.TxtGenero.TabIndex = 9;
            this.TxtGenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtGenero.TextChanged += new System.EventHandler(this.TxtGenero_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(75, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "AÑO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(75, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "PAÍS:";
            // 
            // TxtPais
            // 
            this.TxtPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPais.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPais.Location = new System.Drawing.Point(130, 218);
            this.TxtPais.MaxLength = 50;
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(109, 20);
            this.TxtPais.TabIndex = 13;
            this.TxtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPais.TextChanged += new System.EventHandler(this.TxtPais_TextChanged);
            // 
            // BAnoCom
            // 
            this.BAnoCom.BackColor = System.Drawing.Color.Transparent;
            this.BAnoCom.BorderRadius = 3;
            this.BAnoCom.ForeColor = System.Drawing.Color.Gray;
            this.BAnoCom.Items = new string[0];
            this.BAnoCom.Location = new System.Drawing.Point(130, 189);
            this.BAnoCom.Name = "BAnoCom";
            this.BAnoCom.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(150)))));
            this.BAnoCom.onHoverColor = System.Drawing.Color.White;
            this.BAnoCom.selectedIndex = -1;
            this.BAnoCom.Size = new System.Drawing.Size(109, 23);
            this.BAnoCom.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TxtID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TxtTitulo);
            this.panel2.Controls.Add(this.BAnoCom);
            this.panel2.Controls.Add(this.BttnGuardar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TxtPais);
            this.panel2.Controls.Add(this.BttnModificar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BttnBaja);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtGenero);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 451);
            this.panel2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(157, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "⟳";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TxtID
            // 
            this.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtID.Enabled = false;
            this.TxtID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(130, 91);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(109, 20);
            this.TxtID.TabIndex = 16;
            this.TxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(92, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(303, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 56);
            this.button2.TabIndex = 19;
            this.button2.Text = "AGREGAR VENTA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_2);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(575, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 56);
            this.button3.TabIndex = 20;
            this.button3.Text = "AGREGAR CLIENTES";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblError.Location = new System.Drawing.Point(299, 394);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(51, 19);
            this.LblError.TabIndex = 19;
            this.LblError.Text = "Error:";
            this.LblError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BttnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BCDGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Button BttnGuardar;
        private System.Windows.Forms.Button BttnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BttnModificar;
        private System.Windows.Forms.Button BttnBaja;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPais;
        private Bunifu.Framework.UI.BunifuDropdown BAnoCom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid BCDGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LblError;
    }
}

