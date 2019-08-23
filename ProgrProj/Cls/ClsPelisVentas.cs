using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrProj.Cls
{
    class ClsPelisVentas
    {
        //ATRIBUTOS
        int ID;
        int IDPelicula;
        int IDVenta;
        int IDCliente;
        int Precio;
        //Getters y setters
        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public int GetID()
        {
            return ID;
        }
        public void SetIDPelicula(int IDPelicula)
        {
            this.IDPelicula = IDPelicula;
        }
        public int GetIDPelicula()
        {
            return IDPelicula;
        }
        public void SetIDVenta(int IDVenta)
        {
            this.IDVenta = IDVenta;
        }
        public int GetIDVenta()
        {
            return IDVenta;
        }
        public void SetIDCliente(int IDCliente)
        {
            this.IDCliente = IDCliente;
        }
        public int GetIDCliente()
        {
            return IDCliente;
        }
        public void SetPrecio(int Precio)
        {
            this.Precio = Precio;
        }
        public int GetPrecio()
        {
            return Precio;
        }
    }
}
