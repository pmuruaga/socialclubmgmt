using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubSocial.Models;
using ClubSocial.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClubSocial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SociosController : ControllerBase
    {
        private readonly SocioService _socioService;
        public SociosController(SocioService socioService)
        {
            _socioService = socioService;
        }

        [HttpGet]
        [Route("obtener")]
        public IActionResult Obtener()
        {
            try
            {
                var listadoSocios = _socioService.Listar();
                //return BadRequest(new Exception("probando error"));
                return Ok(listadoSocios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("buscar/{DNI}")]
        public IActionResult Buscar(string DNI)
        {
            try
            {
                var listadoSocios = _socioService.Buscar(DNI);
                //return BadRequest(new Exception("probando error"));
                return Ok(listadoSocios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //api/socio/agregar
        [HttpPost]
        [Route("agregar")]
        public IActionResult Agregar([FromBody] Socio _socio)
        {
            var resultado = _socioService.AgregarSocio(_socio);
            if (resultado == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        //api/socio/editar
        [HttpPut]
        [Route("editar")]
        public IActionResult Editar([FromBody] Socio _socio)
        {
            var resultado = _socioService.EditarSocio(_socio);
            if (resultado == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        //api/socio/editar
        [HttpDelete]
        [Route("eliminar/{SocioID}")]
        public IActionResult Eliminar(int SocioID)
        {
            var resultado = _socioService.EliminarSocio(SocioID);
            if (resultado == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("listadoTipoSocio")]
        public IActionResult ListadoDeTiposSocio()
        {
            return Ok(_socioService.ListadoDeTiposSocios());
        }        
    }
}
