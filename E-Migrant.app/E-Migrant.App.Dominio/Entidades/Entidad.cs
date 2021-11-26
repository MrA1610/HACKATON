using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Migrant.App.Dominio.Entidades
{
    public class Entidad
    {
        [Required(ErrorMessage="El nombre es obligatorio")]
        public String RazonSocial {get; set;}

        [Required(ErrorMessage="El nombre es obligatorio")]
        public String Nit {get; set;}

        [Required(ErrorMessage="El nombre es obligatorio")]
        public String Direccion {get; set;}

        [Required(ErrorMessage="El nombre es obligatorio")]
        public String Ciudad {get; set;}

        [Required(ErrorMessage="El nombre es obligatorio")]
        public string Telefono {get; set;}
    }
}