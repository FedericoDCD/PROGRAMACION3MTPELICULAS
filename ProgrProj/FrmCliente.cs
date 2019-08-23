using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrProj
{
    public partial class FrmCliente : Form
    {
        private DataView DVCliente;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Cls.ClsUs ObjUsuario = new Cls.ClsUs();
            BCDGrid.DataSource = ObjUsuario.BuscarClientes();
            DVCliente = new DataView((DataTable)BCDGrid.DataSource);//Lleno el DVCliente para luego buscar
        }

        private void BttnSalir_Click(object sender, EventArgs e)
        {
            Close();//cierro el formulario

        }

        private void BttnGuardar_Click(object sender, EventArgs e)
        {
            Cls.ClsUs ObjUs = new Cls.ClsUs();//Preparo los objetos para poder utilizarlos
            Cls.ClsCliente ObjCliente;
            String Nombre, Telefono, Direccion;
            if (TxtNom.Text != "" & TxtTel.Text != "" & TxtDir.Text != "")//compruebo si se han rellenado los campos del cliente
            {
                Nombre = TxtNom.Text;//Obtengo los datos del cliente para a posterior guardarlos
                Telefono = TxtTel.Text;
                Direccion = TxtDir.Text;
                ObjCliente = new Cls.ClsCliente(Nombre, Telefono, Direccion);//Creo el objeto mediante su constructor
                ObjUs.ACliente(ObjCliente);//Guardo el cliente
                BCDGrid.DataSource = ObjUs.BuscarClientes();//Actualizo la grilla con los clientes almacenados
                DVCliente = new DataView((DataTable)BCDGrid.DataSource);//LLeno el DVCLiente para buscar los usuarios
                LimpiarFormulario();//Limpio el formulario
            }
            else {//Si no se han ingresado todos los valores lo digo
                LblError.Visible = true;
                LblError.Text = "ERROR: No deben de haber campos sin ingresar";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();//Limpio el formulario al hacerle click al botón
        }
        private void LimpiarFormulario() {//Limpio los textbox del formulario
            TxtNom.Text = "";
            TxtTel.Text = "";
            TxtDir.Text = "";
        }

        private void TxtBID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtBNom_TextChanged(object sender, EventArgs e)
        {//Busco los clientes en tiempo real
            DVCliente.RowFilter = String.Format("Nombre LIKE '%{0}%'", TxtBNom.Text);
            BCDGrid.DataSource = DVCliente;
        }

        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)//Corroboro que inserten sólo números
            {
                e.Handled = true;
            }
        }
        private void ComprobarError() {//Compruebo si debo de ocultar el LblError
            if (LblError.Visible) {
            LblError.Visible = false;
            }
        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {
            ComprobarError();//Oculto el Label del error
        }

        private void TxtTel_TextChanged(object sender, EventArgs e)
        {
            ComprobarError();//Oculto el Label del error
        }

        private void TxtDir_TextChanged(object sender, EventArgs e)
        {
            ComprobarError();//Oculto el Label de error
        }
    }
}
