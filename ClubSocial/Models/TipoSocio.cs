using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubSocial.Models
{
    public class TipoSocio
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public class Mapeo {
            public Mapeo(EntityTypeBuilder<TipoSocio> mapeoTipoSocio) {
                mapeoTipoSocio.HasKey(x => x.Id);
            }
        }
    }
}
