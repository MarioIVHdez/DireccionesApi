
using DireccionesApi.Models;
using DireccionesApi.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DireccionesApi.Interfaces
{
    public interface IDirecciones
    {
        public RespuestasModel Gets();
        public RespuestasModel Get(int id);
        public RespuestasModel Post(Direccione obj);
        public RespuestasModel Put(int id, Direccione obj);
        public RespuestasModel Delete(int id);
    }
}
