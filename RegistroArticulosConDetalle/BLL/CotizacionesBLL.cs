using RegistroArticulosConDetalle.DAL;
using RegistroArticulosConDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RegistroArticulosConDetalle.BLL
{
    public class CotizacionesBLL
    {

        public static bool Guardar(Cotizaciones cotizacion)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.cotizaciones.Add(cotizacion) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Cotizaciones cotizacion)
        {

            bool paso = false;

            Contexto contexto = new Contexto();

            try
            {
                //buscar las entidades que no estan para removerlas

                //recorrer el detalle
                foreach (var item in cotizacion.Detalle)
                {
                    //Muy importante indicar que pasara con la entidad del detalle
                    var estado = item.Id > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;
                }

                //Idicar que se esta modificando el encabezado
                contexto.Entry(cotizacion).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Cotizaciones cotizacion = contexto.cotizaciones.Find(id);
                contexto.cotizaciones.Remove(cotizacion);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static Cotizaciones Buscar(int id)
        {
            Cotizaciones cotizacion = new Cotizaciones();
            Contexto contexto = new Contexto();

            try
            {
                cotizacion = contexto.cotizaciones.Find(id);
                //Cargar la lista en este punto porque
                //luego de hacer Dispose() el Contexto 
                //no sera posible leer la lista
                cotizacion.Detalle.Count();

                //Cargar los nombres de las personas y articulos
                foreach (var item in cotizacion.Detalle)
                {
                    //forzando la persona y el articulo a cargarse
                    string s = item.Articulos.Descripcion;
                    string r = item.Personas.Nombres;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return cotizacion;
        }

        public static List<Cotizaciones> GetList(Expression<Func<Cotizaciones, bool>> expression)
        {
            List<Cotizaciones> Cotizaciones = new List<Cotizaciones>();
            Contexto contexto = new Contexto();

            try
            {
                Cotizaciones = contexto.cotizaciones.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Cotizaciones;
        }
    }
}
