using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ProgrProj.Cls
{
    class ClsUs
    {
        public void APelicula(ClsPeliculas ObjPelicula) {//Doy de alta a la película
            ClsBDP BD = new ClsBDP();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores de la película
            string Titulo= ObjPelicula.GetTitulo();
            string Genero = ObjPelicula.GetGenero();
            string Ano = ObjPelicula.GetAno();
            string Pais = ObjPelicula.GetPais();
            using (SqlCommand comand = new SqlCommand("PRAInsertarPelicula", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@Titulo", Titulo));
                    comand.Parameters.Add(new SqlParameter("@Genero", Genero));
                    comand.Parameters.Add(new SqlParameter("@Ano", Ano));
                    comand.Parameters.Add(new SqlParameter("Pais", Pais));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    MessageBox.Show("¡" + Titulo + " insertado con éxito!");
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al guardar: " + ex.Message);
                }
            }
        }
        
        public void MPelicula(ClsPeliculas ObjPelicula) {//Modifico la película mediante un procedimiento almacenado
            ClsBDP BD = new ClsBDP();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores de la película utilizando los valores del objeto
            int ID = ObjPelicula.GetID();
            string Titulo = ObjPelicula.GetTitulo();
            string Genero = ObjPelicula.GetGenero();
            string Ano = ObjPelicula.GetAno();
            string Pais = ObjPelicula.GetPais();
            using (SqlCommand comand = new SqlCommand("PRAModificarPelicula", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@ID", ID));
                    comand.Parameters.Add(new SqlParameter("@Titulo", Titulo));
                    comand.Parameters.Add(new SqlParameter("@Genero", Genero));
                    comand.Parameters.Add(new SqlParameter("@Ano", Ano));
                    comand.Parameters.Add(new SqlParameter("Pais", Pais));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    MessageBox.Show("¡" + Titulo + " Modificado con éxito!");
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al guardar: " + ex.Message);
                }
            }
        }
        public void BPelicula(ClsPeliculas ObjPelicula) {
            ClsBDP BD = new ClsBDP();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            int ID = ObjPelicula.GetID();
            using (SqlCommand comand = new SqlCommand("PRABaja", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@ID", ID));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al guardar: " + ex.Message);
                }
            }
        }
        public System.Data.DataTable BuscarPeliculas() {
            ClsBDP BD = new ClsBDP();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRABuscarPeliculas", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    return DT;//Retorno el dataset

                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("No se pudo buscar lo deseado: " + ex.Message);
                    return null;//No retorno nada en el caso de que haya un fallo
                }
            }
        }
    }
}
