using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria_Web.Models
{
    public class Cadete
    {
        //ATRIBUTO/S ---
        private int Id;
        private string? Nombre;
        private string? Domicilio;
        private string? Telefono;

        // CONSTRUCTOR ---
        public Cadete(int _Id, string? _Nombre, string? _Domicilio, string? _Telefono)
        {
            this.Id = _Id;
            this.Nombre = _Nombre;
            this.Domicilio = _Domicilio;
            this.Telefono = _Telefono;
        }

        // GET/S --- 
        public int Get_Id()
        {
            return this.Id;
        }

        public string? Get_Nombre()
        {
            return this.Nombre;
        }

        public string? Get_Domicilio()
        {
            return this.Domicilio;
        }

        public string? Get_Telefono()
        {
            return this.Telefono;
        }
    }
}