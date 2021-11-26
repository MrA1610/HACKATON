using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Migrant.App.Dominio.Entidades
{
    public class Usuario{
        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage="El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Por favor indicar un {0} valido de minimo {2} caracteres")]
        [Display(Name = "Nombre", Prompt ="Digite el nombre")]
        public String Nombre {get; set;}

        [Required(ErrorMessage="Los apellidos son obligatorios")]
        public String Apellidos {get; set;}

        [Required(ErrorMessage="El numero de documento es indispensable")]
        public String Documento {get; set;}

        [Required(ErrorMessage="El pais es un campo requerido")]
        public String Pais {get; set;}

        [Required(ErrorMessage="El año de nacimiento es obligatorio")]
        public DateTime BornYear {get; set;}

        public String Email {get; set;}
        public int PhoneContact {get; set;}
        public String Direccion {get; set;}
        public String Ciudad{get; set;}
        public String EstadoLaboral{get; set;}

    }
}