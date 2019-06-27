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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Cls.ClsUs ObjUsuario = new Cls.ClsUs();
            //Genero al iniciar el formulario el listado de fechas para el combobox BAnoCom
            for (int i = 2019; i >= 1895; i--)
            {
                BAnoCom.AddItem(i.ToString());
            }
            BCDGrid.DataSource = ObjUsuario.BuscarPeliculas();//Realizo la búsqueda de las películas y lo cargo en la grilla con lo buscado
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            //Si el valor que posee el textbox es diferente a nada permito habilito los botones de modificación y baja
            if (TxtID.Text != "")
            {
                BttnModificar.Enabled = true;
                BttnBaja.Enabled = true;
            }
            else {
                BttnModificar.Enabled = false;
                BttnBaja.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cls.ClsUs Objus = new Cls.ClsUs();
            //Declaro un objeto de la clase ClsPeliculas y le asigno una película
            Cls.ClsPeliculas ObjP = new Cls.ClsPeliculas();
            String Titulo, Genero, Ano, Pais;
            Titulo = TxtTitulo.Text;
            Genero = TxtGenero.Text;
            Ano = BAnoCom.selectedValue;
            Pais = TxtPais.Text;
            ObjP.SetTitulo(Titulo);
            ObjP.SetGenero(Genero);
            ObjP.SetAno(Ano);
            ObjP.SetPais(Pais);
            Objus.APelicula(ObjP);//Inserto la película
            BCDGrid.DataSource = Objus.BuscarPeliculas(); //Realizo otra búsqueda de las películas y con ella actualizo la grilla con los resultados
            LimpiarFormulario();//Limpio el formulario de lo ingresado
        }
        private void LimpiarFormulario() {//Limpio el formulario
            TxtID.Text = "";
            TxtTitulo.Text = "";
            TxtGenero.Text = "";
            BAnoCom.selectedIndex = 0;
            TxtPais.Text = "";
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            Cls.ClsUs Objus = new Cls.ClsUs();
            //Declaro un objeto de la clase ClsPeliculas y le asigno una película
            Cls.ClsPeliculas ObjP = new Cls.ClsPeliculas();
            int ID;
            String Titulo, Genero, Ano, Pais;
            ID = int.Parse(TxtID.Text);
            Titulo = TxtTitulo.Text;
            Genero = TxtGenero.Text;
            Ano = BAnoCom.selectedValue;
            Pais = TxtPais.Text;
            ObjP.SetID(ID);
            ObjP.SetTitulo(Titulo);
            ObjP.SetGenero(Genero);
            ObjP.SetAno(Ano);
            ObjP.SetPais(Pais);
            Objus.MPelicula(ObjP);//Modifico la película
            BCDGrid.DataSource = Objus.BuscarPeliculas(); //Realizo otra búsqueda de las películas y con ella actualizo la grilla con los resultados
            LimpiarFormulario();//Limpio el formulario de lo ingresado
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cls.ClsUs Objus = new Cls.ClsUs();
            //Declaro un objeto de la clase ClsPeliculas y le asigno una película
            Cls.ClsPeliculas ObjP = new Cls.ClsPeliculas();
            int ID;
            ID = int.Parse(TxtID.Text);
            ObjP.SetID(ID);
            Objus.BPelicula(ObjP);//Doy de baja la película
            BCDGrid.DataSource = Objus.BuscarPeliculas(); //Realizo otra búsqueda de las películas y con ella actualizo la grilla con los resultados
            LimpiarFormulario();//Limpio el formulario de lo ingresado
        }

        private void BCDGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cargo con los datos ingresados los elementos del formulario
            int ID;
            String Titulo, Genero, Ano, Pais;
            //Obtengo los valores insertados en la grilla según su dato correspondiente ingresado
            ID= int.Parse(BCDGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            Titulo = BCDGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            Genero = BCDGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            Ano = BCDGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            Pais = BCDGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtID.Text = ID.ToString();
            TxtTitulo.Text = Titulo;
            TxtGenero.Text = Genero;
            BAnoCom.selectedIndex= 2019 -(int.Parse(Ano));//Calculo cual debería de ser el index del año ingresado
            TxtPais.Text = Pais;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {//Reseteo el formulario
            LimpiarFormulario();
        }
    }
}
