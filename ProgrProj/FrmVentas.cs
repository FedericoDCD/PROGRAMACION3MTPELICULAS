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
    public partial class FrmVentas : Form
    {
        private DataView DVVenta;
        DataTable DTPel;//Creo un datatable para organizar los resultados de la búsqueda de las películas
        DataTable DTClientes;//Creo otro DataTable pero lo uso con el fin de almacenar los clientes ingresados
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void BttnSalir_Click(object sender, EventArgs e)
        {
            Close();//Cierro el programa si se desea
        }

        private void BttnGuardar_Click(object sender, EventArgs e)
        {
            Cls.ClsUs ObjUs = new Cls.ClsUs();
            Cls.ClsVentas ObjVent = new Cls.ClsVentas();
            if (BttnGenerarVenta.Text == "GENERAR VENTA")
            {//Si se desea generar una nueva venta trabajo con los datos correspondientes y habilito tanto como muestro los datos correspondientes

                DataRow Row;
                DateTime DTime;//Fecha de la venta
                string ID;
                DTime = DTPFecha.Value;//La asigo su valor correspondiente
                ObjVent.SetFecha(DTime);//Ingreso los datos en el objeto ObjVent para a posterior insertar la venta
                ObjUs.AVenta(ObjVent);//Ingreso la venta
                Row = ObjUs.BuscarUltVenta().Rows[0];
                ID = Row[0].ToString();
                DTPFecha.Enabled = false;
                BttnGenerarVenta.Text = "Finalizar venta";
                TxtID.Text = ID;
                LblID.Visible = true;
                TxtID.Visible = true;
                this.Size = new Size(800, this.Size.Height);//Modifico el tamaño del formulario para mostrar la opción de ventas
                this.CenterToScreen();//Centro el formulario
                BttnSalir.Location = new Point(732, 0);//Modifico la posición del botón de cierre del formulario
                PnlVenta.Visible = true;
                PnlVent.Visible = false; 
                CmbClientes.Enabled = false;//Desactivo el cambio de cliente
                LblCliente.Text += " " + CmbClientes.selectedValue;
                BttnGenerarVenta.Enabled = false;//Desactivo el botón con el fin de que no se agreguen ventas vacías
                BttnVer.Enabled = false; //Deshabilito el ver las ventas
            } else {//Actualizo la venta con su nuevo monto
                int ID;//Datos de la venta
                DateTime Fecha;
                int Monto;
                ID = int.Parse(TxtID.Text);//Le agisno los valores correspondientes
                Fecha = DTPFecha.Value;
                Monto = int.Parse(LblPrecio.Text);
                ObjVent.SetID(ID);//Coloco los datos ya extraídos directamente en el objeto ObjVent
                ObjVent.SetFecha(Fecha);
                ObjVent.SetMonto(Monto);
                ObjUs.MVenta(ObjVent);//Lo envío a modo de actualizar los datos de la venta
                BttnVer.Enabled = true;//Habilito el ver ventas mediante su botón
                Close(); //Cierro el formulario

            }
            

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BAnoCom_onItemSelected(object sender, EventArgs e)
        {

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            Cls.ClsUs ObjUS = new Cls.ClsUs();//Referencio al usuario
            DTPel = ObjUS.BuscarPeliculas();//Le guardo las películas 
            DTClientes = ObjUS.BuscarClientes();
            for (int i = 0; i < DTPel.Rows.Count; i++) {//Inserto tantas películas como haya disponibles para insertar
                CmbPelicula.AddItem(DTPel.Rows[i][1].ToString());//Inserto específicamente los nombres en el combobox
            }
            for (int i = 0; i < DTClientes.Rows.Count; i++)
            {//Inserto tantas películas como haya disponibles para insertar
                CmbClientes.AddItem(DTClientes.Rows[i][1].ToString());//Inserto específicamente los nombres en el combobox
            }

        }

        private void TxtPrec_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrec.Text == "")//Si no hay ningún precio colocado inhabilito el botón de agregar
            {
                BttnAgregar.Enabled = false;
            }else{
                BttnAgregar.Enabled = true;
            }
        }

        private void TxtPrec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back) {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cls.ClsUs ObjUs = new Cls.ClsUs();
            Cls.ClsPelisVentas ObjPeliVentas = new Cls.ClsPelisVentas();
            int IDPelicula;
            int IDVenta;
            int IDCliente;
            int Ind; //Ubicación del item del combobox seleccionado
            int IndCliente; //Ubicación del cliente seleccionado en el comboBox
            int Precio;//Precio del producto
            Ind = CmbPelicula.selectedIndex;//Le asigno el index
            IndCliente = CmbClientes.selectedIndex;
            IDPelicula = int.Parse(DTPel.Rows[Ind][0].ToString());//Según la ubicación del item seleccionado busco en el datatable que almacena los datos de las películas
            IDCliente = int.Parse(DTClientes.Rows[IndCliente][0].ToString());//Obtengo la ID Del cliente seleccionado
            Precio = int.Parse(TxtPrec.Text); //Guardo el precio
            IDVenta = int.Parse(TxtID.Text);
            ObjPeliVentas.SetIDPelicula(IDPelicula);//Asigno los valores correspondientes al objeto de ClsPelisVentas
            ObjPeliVentas.SetIDVenta(IDVenta);
            ObjPeliVentas.SetIDCliente(IDCliente);
            ObjPeliVentas.SetPrecio(Precio);
            int RowCorrecta = BCDGrid.Rows.Count; 
            ObjUs.APeliVenta(ObjPeliVentas);//Agrego la película a la venta(Inserto PelisVentas)
            BCDGrid.Rows.Add(1);//Agrego una nueva fila al datagridview
            BCDGrid.Rows[RowCorrecta].Cells[1].Value = "$" + TxtPrec.Text;//Guardo el precio en el datagridview
            BCDGrid.Rows[RowCorrecta].Cells[0].Value = CmbPelicula.selectedValue;//Guardo la película en el datagridview
            if (!BttnGenerarVenta.Enabled) {//Si el botón está bloqueado lo habilito
            BttnGenerarVenta.Enabled = true;
            }
            if (LblPrecio.Text == "?")//Si hay un precio ingresado lo sumo, sino le doy el precio ingresado
            {
                LblPrecio.Text = TxtPrec.Text;
            }else {
                LblPrecio.Text = (int.Parse(LblPrecio.Text) + int.Parse(TxtPrec.Text)).ToString();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void BttnVer_Click(object sender, EventArgs e)
        {
            Cls.ClsUs ObjUs = new Cls.ClsUs();
            this.Size = new Size(800, this.Size.Height);//Modifico el tamaño del formulario para mostrar la opción de ventas
            this.CenterToScreen();//Centro el formulario
            BttnSalir.Location = new Point(732, 0);//Modifico la posición del botón de cierre del formulario
            PnlVent.Visible = true;//Hago visible el pannel
            PnlVenta.Visible = false;
            BGVVentas.DataSource = ObjUs.ListarVentas();
            DVVenta = new DataView((DataTable)BGVVentas.DataSource);//Lleno el DVCliente para luego buscar
        }

        private void PnlVenta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CmbClientes_onItemSelected(object sender, EventArgs e)
        {
            BttnGenerarVenta.Enabled = true;//Si hay un item en el combobox selecionado habilito el crear la venta
            if (PnlVent.Visible) {
                DVVenta.RowFilter = String.Format("CLIENTE LIKE '{0}'", CmbClientes.selectedValue);
                BGVVentas.DataSource = DVVenta;
            }
        }

        private void BGVVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DTPFecha_ValueChanged(object sender, EventArgs e)
        {
            if (PnlVent.Visible)
            {//Si se está utilizando el panel de ver ventas y se modificó la fecha busco las ventas de esa fecha
                DateTime Fecha;
                String Nombre;
                Fecha = DTPFecha.Value;
                if (CmbClientes.selectedIndex == -1)//Si hay un cliente seleccionado busco por fecha y cliente del combobox
                {
                    DVVenta.RowFilter = String.Format("FECHA = #{0}# ", Fecha.Date);
                }
                else {
                    Nombre = CmbClientes.selectedValue;
                    DVVenta.RowFilter = String.Format("FECHA = #{0}# AND CLIENTE LIKE '{1}'", Fecha.Date, Nombre);
                }
                BGVVentas.DataSource = DVVenta;
            }
        }

        private void BttnNormalizar_Click(object sender, EventArgs e)
        {//Reseteo el contenigo de la grilla cargada 
            Cls.ClsUs ObjUs = new Cls.ClsUs();
            BGVVentas.DataSource = ObjUs.ListarVentas();
            DVVenta = new DataView((DataTable)BGVVentas.DataSource);//Lleno el DVCliente para luego buscar
        }
    }
}
