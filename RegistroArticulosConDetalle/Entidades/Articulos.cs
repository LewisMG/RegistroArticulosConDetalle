using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroArticulosConDetalle.Entidades
{
    public class Articulos
    {
        //Esta es la llave primaria
        [Key]//hay que importar System.ComponentModel.DataAnnotations;
        public int ArticuloId { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public int CantCotizada { get; set; }

        //Crea las propiedades de la forma corta.
        public Articulos()
        {

        }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
