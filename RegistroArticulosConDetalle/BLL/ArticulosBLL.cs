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
    public class ArticulosBLL
    {
        public static bool Guardar(Articulos articulos)
        {
            bool paso = false;
            //Instancia del contexto para poder conectar con la BD
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.articulos.Add(articulos) != null)
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

        public static bool Modificar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulos).State = EntityState.Modified;
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

        public static bool Eliminar(int articuloId)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Articulos Articulo = contexto.articulos.Find(articuloId);

                contexto.articulos.Remove(Articulo);

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

        public static Articulos Buscar(int articuloId)
        {
            Contexto contexto = new Contexto();
            Articulos Articulo = new Articulos();

            try
            {
                Articulo = contexto.articulos.Find(articuloId);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Articulo;
        }

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {
            List<Articulos> Articulo = new List<Articulos>();
            Contexto contexto = new Contexto();
            try
            {
                Articulo = contexto.articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Articulo;
        }
    }
}
