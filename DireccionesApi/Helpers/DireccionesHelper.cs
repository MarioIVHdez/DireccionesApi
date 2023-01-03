using DireccionesApi.Interfaces;
using DireccionesApi.Models;
using DireccionesApi.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DireccionesApi.Helpers
{
    public class DireccionesHelper :IDirecciones
    {
        public RespuestasModel Gets()
        {
            RespuestasModel res = new RespuestasModel();
            List<Direccione> obj = new List<Direccione>();
            try
            {
             
                using (var context = new db_a928b2_mivContext())
                {
                     obj = (from d in context.Direcciones select d).ToList();
                }

                res.Contenido = obj;
                res.Estado = 1;

            }
            catch (Exception e)
            {
                res.Contenido = e;
                res.Estado = 0;
            }

            return res;
        }

        public RespuestasModel Get(int id)
        {
            RespuestasModel res = new RespuestasModel();
            try
            {
                Direccione obj = new Direccione();
                using (var context = new db_a928b2_mivContext())
                {
                     obj = (from d in context.Direcciones where d.DireccionesId == id select d).FirstOrDefault();
                }

                res.Contenido = obj;
                res.Estado = 1;

            }
            catch (Exception e)
            {
                res.Contenido = e;
                res.Estado = 0;
            }
            return res;
        }

        public RespuestasModel Post(Direccione obj)
        {
            RespuestasModel res = new RespuestasModel();
            try
            {
               
                using (var context = new db_a928b2_mivContext())
                {
                     obj.FechaCreacion = DateTime.Now;
                     context.Direcciones.Add(obj);
                     context.SaveChanges();
                }

                res.Contenido = " ";
                res.Estado = 1;

            }
            catch (Exception e)
            {
                res.Contenido = e;
                res.Estado = 0;
            }
            return res;
        }


        public RespuestasModel Put(int DireccionId, Direccione obj)
        {
            RespuestasModel res = new RespuestasModel();
            try
            {
                Direccione objFind = new Direccione();
                using (var context = new db_a928b2_mivContext())
                {
                    objFind = (from d in context.Direcciones where d.DireccionesId == DireccionId select d).FirstOrDefault();
                    objFind.AliasDireccion = obj.AliasDireccion;
                    objFind.NombrePersona = obj.NombrePersona;
                    objFind.Telefono = obj.Telefono;
                    objFind.Correo = obj.Correo;
                    objFind.Pais = obj.Pais;
                    objFind.CodigoPostal = obj.CodigoPostal;
                    objFind.Ciudad = obj.Ciudad;
                    objFind.Estado = obj.Estado;
                    objFind.CalleNumero = obj.CalleNumero;
                    objFind.Colonia = obj.Colonia;
                    objFind.Referencia = obj.Referencia;
                    objFind.FechaEdicion =DateTime.Now;
                    objFind.Eliminacion = false;
                    context.SaveChanges();
                }

                res.Contenido = " ";
                res.Estado = 1;

            }
            catch (Exception e)
            {
                res.Contenido = e;
                res.Estado = 0;
            }
            return res;
        }


        public RespuestasModel Delete(int DireccionId)
        {
            RespuestasModel res = new RespuestasModel();
            try
            {
                Direccione objFind = new Direccione();
                using (var context = new db_a928b2_mivContext())
                {
                    objFind = (from d in context.Direcciones where d.DireccionesId == DireccionId select d).FirstOrDefault();
                    
                    context.Direcciones.Remove(objFind);
                    context.SaveChanges();
                }

                res.Contenido = " ";
                res.Estado = 1;
            }
            catch (Exception e)
            {
                res.Contenido = e;
                res.Estado = 0;
            }
            return res;
        }

    }
}
