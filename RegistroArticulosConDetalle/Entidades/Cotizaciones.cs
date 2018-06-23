using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroArticulosConDetalle.Entidades
{
    public class Cotizaciones
    {
        //llave primaria
        [Key]//se necesita System.ComponentModel.DataAnnotations
        public int CotizacionId { get; set; }
        public DateTime Fecha { get; set; }
        [StringLength(100)]
        public string Comentario { get; set; }
        public int Monto { get; set; }

        public virtual ICollection<DetalleCotizacion> Detalle { get; set; }

        public Cotizaciones()
        {
            //Es obligatorio inicializar la lista
            this.Detalle = new List<DetalleCotizacion>();
        }

        public void AgregarDetalle(int id, int CotizacionId, int PersonaId, int ArticuloId, int Cantidad, int Precio, int Importe)
        {
            this.Detalle.Add(new DetalleCotizacion(id, CotizacionId, PersonaId, ArticuloId, Cantidad, Precio, Importe));
        }
    }
}
