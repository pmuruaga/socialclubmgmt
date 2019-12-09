using ClubSocial.Data;
using ClubSocial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubSocial.Services
{
    public class SocioService
    {
        private readonly ClubDBContext _clubDbContext;

        public SocioService(ClubDBContext dbContext)
        {
            _clubDbContext = dbContext;
        }

        public List<Socio> Listar() {
            var resultado = _clubDbContext.Socio.Include(x => x.TipoSocio).ToList();
            return resultado;
        }

        public List<Socio> Buscar(string DNI)
        {
            //Busco que contenga el dni, es para usar en un buscador dinamico, cuando el usuario ingrese algunos numeros vaya filtrando.
            var resultado = _clubDbContext.Socio.Where(x => x.DNI.Contains(DNI)).Include(x => x.TipoSocio).ToList();
            return resultado;
        }


        //Defino metodos para trabajar con los datos
        public bool AgregarSocio(Socio _socio)
        {
            try
            {
                //Para agregar por ejemplo la siguiente linea.
                _clubDbContext.Socio.Add(_socio);
                _clubDbContext.SaveChanges();
            }
            catch (Exception error)
            {
                return false;
            }
            return true;
        }

        public bool EditarSocio(Socio _socio)
        {
            try
            {
                var socioEnDB = _clubDbContext.Socio.Where(x => x.Id == _socio.Id).FirstOrDefault();
                socioEnDB.Nombre = _socio.Nombre;
                socioEnDB.Apellido = _socio.Apellido;
                socioEnDB.DNI = _socio.DNI;
                socioEnDB.FechaNacimiento = _socio.FechaNacimiento;
                socioEnDB.TipoSocioId = _socio.TipoSocioId;
                socioEnDB.IsActivo = _socio.IsActivo;
                socioEnDB.Telefono = _socio.Telefono;
                socioEnDB.TelefonoUrgencias = _socio.TelefonoUrgencias;
                socioEnDB.UrlFotoPerfil = _socio.UrlFotoPerfil;

                _clubDbContext.SaveChanges();
            }
            catch (Exception error)
            {
                return false;
            }
            return true;
        }


        public bool EliminarSocio(int SocioId)
        {
            try
            {
                var socioEnDB = _clubDbContext.Socio.Where(x => x.Id == SocioId).FirstOrDefault();
                _clubDbContext.Socio.Remove(socioEnDB);
                _clubDbContext.SaveChanges();
            }
            catch (Exception error)
            {
                return false;
            }
            return true;
        }

        public List<TipoSocio> ListadoDeTiposSocios()
        {
            try
            {
                var tipoSocio = _clubDbContext.TipoSocio.ToList();
                return tipoSocio;
            }
            catch (Exception error)
            {
                return new List<TipoSocio>();
            }
        }
    }
}
