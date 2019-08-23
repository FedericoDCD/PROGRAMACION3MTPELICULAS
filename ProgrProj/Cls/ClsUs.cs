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
        public void AVenta(ClsVentas ObjVent)
        {//Doy de alta la venta
            ClsBDP BD = new ClsBDP();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores de la venta
            DateTime Fecha = ObjVent.GetFecha();
            int Monto = ObjVent.GetMonto();
            using (SqlCommand comand = new SqlCommand("PRAInsertarVenta", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@Fecha", Fecha));
                    comand.Parameters.Add(new SqlParameter("@Monto", Monto));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    MessageBox.Show("¡Venta generada con éxito!");
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al generar venta: " + ex.Message);
                }
            }
        }
        public void ACliente(ClsCliente ObjCliente)
        {//Doy de alta la venta
            ClsBDP BD = new ClsBDP();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores de la venta
            String Nombre = ObjCliente.GetNombre();
            String Telefono = ObjCliente.GetTelefono();
            String Direccion = ObjCliente.GetDireccion();
            using (SqlCommand comand = new SqlCommand("PRAInsertarCliente", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                    comand.Parameters.Add(new SqlParameter("@Telefono", Telefono));
                    comand.Parameters.Add(new SqlParameter("@Direccion", Direccion));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    MessageBox.Show("¡Cliente ingresado con éxito!");
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al generar venta: " + ex.Message);
                }
            }
        }
        public void APeliVenta(ClsPelisVentas ObjPeliVent)
        {//Doy de alta PeliVenta, que se encarga de relacionar las películas con las ventas
            ClsBDP BD = new ClsBDP();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores de la venta
            int IDPelicula= ObjPeliVent.GetIDPelicula();
            int IDVenta = ObjPeliVent.GetIDVenta();
            int IDCliente = ObjPeliVent.GetIDCliente();
            int Precio = ObjPeliVent.GetPrecio();
            using (SqlCommand comand = new SqlCommand("PRAIsertarPelisVentas", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@IDVenta", IDVenta));
                    comand.Parameters.Add(new SqlParameter("@IDPelicula", IDPelicula));
                    comand.Parameters.Add(new SqlParameter("@IDCliente", IDCliente));
                    comand.Parameters.Add(new SqlParameter("@Precio", Precio));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    MessageBox.Show("¡Agregado con éxito!");
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al generar venta: " + ex.Message);
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
        public void MVenta(ClsVentas ObjVenta)
        {//Modifico la venta deseada
            ClsBDP BD = new ClsBDP();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            //Obtengo los valores de la venta
            int ID = ObjVenta.GetID();
            DateTime Fecha = ObjVenta.GetFecha();
            int Monto = ObjVenta.GetMonto();
            using (SqlCommand comand = new SqlCommand("PRAModificarVenta", BD.Conn))//Selecciono el procedimiento almacenado
            {
                try
                {
                    comand.CommandType = System.Data.CommandType.StoredProcedure;
                    //Defino los parámetros a ingresar del procedimiento almacenado y le envío los datos correspondientes
                    comand.Parameters.Add(new SqlParameter("@ID", ID));
                    comand.Parameters.Add(new SqlParameter("@Fecha", Fecha));
                    comand.Parameters.Add(new SqlParameter("@Monto", Monto));
                    System.Data.DataTable DT = new System.Data.DataTable();
                    SqlDataAdapter DA = new SqlDataAdapter(comand);
                    BD.Open();//Abro la conexión
                    DA.Fill(DT);//Doy Fill al dt
                    BD.Close();//Cierro la conexión
                    MessageBox.Show("¡Guardado con éxito!");
                }
                catch (Exception ex)//Muestro una salida en pantalla del error en caso de que lo haya
                {
                    Console.Write("Error al generar venta: " + ex.Message);
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
        public System.Data.DataTable BuscarClientes()
        {
            ClsBDP BD = new ClsBDP();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRABuscarClientes", BD.Conn))//Selecciono el procedimiento almacenado
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
        public System.Data.DataTable BuscarUltVenta()
        {
            ClsBDP BD = new ClsBDP();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRABuscarVenta", BD.Conn))//Selecciono el procedimiento almacenado
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
        public System.Data.DataTable ListarVentas()
        {
            ClsBDP BD = new ClsBDP();//Creo un objeto de la clase de base de datos para utilizarla y realizar la comunicación
            using (SqlCommand comand = new SqlCommand("PRAListarVentas", BD.Conn))//Selecciono el procedimiento almacenado
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
