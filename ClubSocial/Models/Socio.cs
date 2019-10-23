using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubSocial.Models
{
    public class Socio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool IsActivo { get; set; }
        public string TelefonoUrgencias { get; set; }
        public string UrlFotoPerfil { get; set; }

        //Creo una clase de mapeo, en el constructor incluyo un EntityTypeBuilder, tengo que importar el namespace
        //using Microsoft.EntityFrameworkCore.Metadata.Builders;
        //Luego en el constructor mapeo las propiedades con las columnas de la tabla.
        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<Socio> mapeoSocio)
            {
                mapeoSocio.HasKey(x => x.Id);
                //Si las columnas se llaman igual en la clase que en la bd no hace falta lo siguiente.
                //El HasColumnName debo importarlo en el using Microsoft.EntityFrameworkCore
                //mapeoAutor.Property(x => x.Nombre).HasColumnName("Nombre");

                //Si la tabla tiene un nombre diferente al de la clase que estoy definiendo como entidad
                //Debo especificarla de la siguiente forma, si se llaman igual no hace falta.
                //mapeoAutor.ToTable("Autor");
            }
        }
    }
}
