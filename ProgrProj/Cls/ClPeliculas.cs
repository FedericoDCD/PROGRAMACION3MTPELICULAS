using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrProj.Cls
{
    class ClsPeliculas
    {
        //ATRIBUTOS
        int ID;
        String Titulo;
        String Genero;
        String Ano;
        String Pais;
        Boolean Baja;
        //Getters y setters
        public void SetID(int ID) {
            this.ID = ID;
        }
        public int GetID() {
            return ID;
        }
        public void SetTitulo(string Titulo)
        {
            this.Titulo = Titulo;
        }
        public string GetTitulo()
        {
            return Titulo;
        }
        public void SetGenero(string Genero)
        {
            this.Genero = Genero;
        }
        public string GetGenero()
        {
            return Genero;
        }
        public void SetAno(string Ano)
        {
            this.Ano = Ano;
        }
        public string GetAno()
        {
            return Ano;
        }
        public void SetPais(string Pais)
        {
            this.Pais = Pais;
        }
        public string GetPais()
        {
            return Pais;
        }
        public void SetBaja(Boolean Baja)
        {
            this.Baja = Baja;
        }
        public Boolean GetBaja()
        {
            return Baja;
        }

    }
}
