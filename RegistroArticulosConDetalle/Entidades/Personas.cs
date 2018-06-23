using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroArticulosConDetalle.Entidades
{
    public class Personas
    {
        //Esta es la llave primaria
        [Key]//hay que importar System.ComponentModel.DataAnnotations;
        public int PersonaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }


        //Crea las propiedades de la forma corta.
        public Personas()
        {

        }

        public override string ToString()
        {
            return this.Nombres;
        }

    }
}
