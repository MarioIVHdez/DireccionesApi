using DireccionesApi.Interfaces;
using DireccionesApi.Models;
using DireccionesApi.Models.VM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DireccionesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DireccionesController : ControllerBase
    {

        private readonly IDirecciones direcciones;

        public DireccionesController(IDirecciones _direcciones)
        {
            this.direcciones = _direcciones;
        }

        // GET: api/<DireccionesController>
        [HttpGet]
        public IActionResult Gets()
        {
            RespuestasModel respuesta = direcciones.Gets();

            if (respuesta.Estado == 1)
            {
                return Ok(respuesta.Contenido);
            }
            else
            {
                return StatusCode(500);
            }
        }

        // GET api/<DireccionesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id > 0)
            {

                RespuestasModel respuesta = direcciones.Get(id);

                if (respuesta.Estado == 1)
                {
                    return Ok(respuesta.Contenido);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            else
            {
                return BadRequest();
            }
        }

        // POST api/<DireccionesController>
        [HttpPost]
        public IActionResult Post([FromBody] Direccione obj)
        {

            if (ModelState.IsValid)
            {

                RespuestasModel respuesta = direcciones.Post(obj);

                if (respuesta.Estado == 1)
                {
                    return Ok(respuesta.Contenido);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            else
            {
                return BadRequest();
            }


        }

        // PUT api/<DireccionesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Direccione obj)
        {
            if (ModelState.IsValid && id>0)
            {

                RespuestasModel respuesta = direcciones.Put(id,obj);

                if (respuesta.Estado == 1)
                {
                    return Ok(respuesta.Contenido);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            else
            {
                return BadRequest();
            }

        }

        // DELETE api/<DireccionesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id > 0)
            {

                RespuestasModel respuesta = direcciones.Delete(id);

                if (respuesta.Estado == 1)
                {
                    return Ok(respuesta.Contenido);
                }
                else
                {
                    return StatusCode(500);
                }
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
