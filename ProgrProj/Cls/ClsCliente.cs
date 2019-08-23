using System;

namespace ProgrProj.Cls
{
    class ClsCliente
    {
        //ATRIBUTOS
        int ID;
        String Nombre;
        String Telefono;
        String Direccion;
        //CONSTRUCTOR
        public ClsCliente(String Nombre, String Telefono, String Direccion)
        {
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        }
        public ClsCliente()
        {
            
        }
        //GETTERS Y SETTERS
        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public int GetID()
        {
            return ID;
        }
        public void SetNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }
        public String GetNombre()
        {
            return Nombre;
        }
        public void SetTelefono(String Telefono)
        {
            this.Telefono = Telefono;
        }
        public String GetTelefono()
        {
            return Telefono;
        }
        public void SetDireccion(String Direccion)
        {
            this.Direccion = Direccion;
        }
        public String GetDireccion()
        {
            return Direccion;
        }
    }
}
