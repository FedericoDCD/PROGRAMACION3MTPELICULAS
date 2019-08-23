namespace ProgrProj
{
    partial class FrmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.BttnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.BCDGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.BttnSalir = new System.Windows.Forms.Button();
            this.TxtBNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BCDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TxtNom);
            this.panel2.Controls.Add(this.BttnGuardar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TxtDir);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtTel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 451);
            this.panel2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(159, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "⟳";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TxtNom
            // 
            this.TxtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.Location = new System.Drawing.Point(130, 137);
            this.TxtNom.MaxLength = 50;
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(109, 20);
            this.TxtNom.TabIndex = 2;
            this.TxtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
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
            this.BttnGuardar.Click += new System.EventHandler(this.BttnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(24, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "DIRECCIÓN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOMBRE:";
            // 
            // TxtDir
            // 
            this.TxtDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDir.Location = new System.Drawing.Point(130, 189);
            this.TxtDir.MaxLength = 500;
            this.TxtDir.Multiline = true;
            this.TxtDir.Name = "TxtDir";
            this.TxtDir.Size = new System.Drawing.Size(109, 58);
            this.TxtDir.TabIndex = 13;
            this.TxtDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDir.TextChanged += new System.EventHandler(this.TxtDir_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(30, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "TELÉFONO:";
            // 
            // TxtTel
            // 
            this.TxtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTel.Location = new System.Drawing.Point(130, 163);
            this.TxtTel.MaxLength = 9;
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(109, 20);
            this.TxtTel.TabIndex = 9;
            this.TxtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTel.TextChanged += new System.EventHandler(this.TxtTel_TextChanged);
            this.TxtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTel_KeyPress);
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
            this.BCDGrid.Location = new System.Drawing.Point(363, 88);
            this.BCDGrid.Name = "BCDGrid";
            this.BCDGrid.ReadOnly = true;
            this.BCDGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BCDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BCDGrid.Size = new System.Drawing.Size(332, 302);
            this.BCDGrid.TabIndex = 18;
            // 
            // BttnSalir
            // 
            this.BttnSalir.FlatAppearance.BorderSize = 0;
            this.BttnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnSalir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnSalir.Location = new System.Drawing.Point(734, 0);
            this.BttnSalir.Name = "BttnSalir";
            this.BttnSalir.Size = new System.Drawing.Size(66, 45);
            this.BttnSalir.TabIndex = 19;
            this.BttnSalir.Text = "X";
            this.BttnSalir.UseVisualStyleBackColor = true;
            this.BttnSalir.Click += new System.EventHandler(this.BttnSalir_Click);
            // 
            // TxtBNom
            // 
            this.TxtBNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBNom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBNom.Location = new System.Drawing.Point(502, 37);
            this.TxtBNom.MaxLength = 50;
            this.TxtBNom.Name = "TxtBNom";
            this.TxtBNom.Size = new System.Drawing.Size(109, 20);
            this.TxtBNom.TabIndex = 21;
            this.TxtBNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBNom.TextChanged += new System.EventHandler(this.TxtBNom_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(424, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nombre:";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblError.Location = new System.Drawing.Point(297, 409);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(71, 19);
            this.LblError.TabIndex = 23;
            this.LblError.Text = "ERROR: ";
            this.LblError.Visible = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.TxtBNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BttnSalir);
            this.Controls.Add(this.BCDGrid);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BCDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Button BttnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid BCDGrid;
        private System.Windows.Forms.Button BttnSalir;
        private System.Windows.Forms.TextBox TxtBNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblError;
    }
}