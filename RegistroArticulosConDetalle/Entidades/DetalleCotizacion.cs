using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RegistroArticulosConDetalle.Entidades
{
    public class DetalleCotizacion
    {
        [Key]
        public int Id { get; set; }
        public int CotizacionId { get; set; }
        public int PersonaId { get; set; }
        public int ArticuloId { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Importe { get; set; }

        [ForeignKey("ArticuloId")]
        public virtual Articulos Articulos { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Personas Personas { get; set; }

        public DetalleCotizacion()
        {
            this.Id = 0;
            this.CotizacionId = 0;
        }

        public DetalleCotizacion(int id, int cotizacioId, int personaId, int articuloId, int cantidad, int precio, int importe)
        {
            Id = id;
            CotizacionId = cotizacioId;
            PersonaId = personaId;
            ArticuloId = articuloId;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
    }
}
