using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrProj.Cls
{
    class ClsVentas
    {
        //ATRIBUTOS
        int ID;
        DateTime Fecha;
        int Monto;
        //Getters y setters
        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public int GetID()
        {
            return ID;
        }
        public void SetFecha(DateTime Fecha)
        {
            this.Fecha = Fecha;
        }
        public DateTime GetFecha()
        {
            return Fecha;
        }
        public void SetMonto(int Monto)
        {
            this.Monto = Monto;
        }
        public int GetMonto()
        {
            return Monto;
        }

    }
}
