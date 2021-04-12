using EvoWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvoWebsite.Data.Configurations
{
    public class ImporteConfiguration : IEntityTypeConfiguration<Importe>
    {
        public void Configure(EntityTypeBuilder<Importe> builder)
        {

            builder.HasData(
                new Importe() { ImporteId = 1, Name = "Subaru WRX",ImgPath = "/img/Importes/SubaruWrx.jpg", Prix = 25},
                new Importe() { ImporteId = 2, Name = "Golf R", ImgPath = "/img/Importes/GolfR.jpg", Prix = 25 },
                new Importe() { ImporteId = 2, Name = "Maserati", ImgPath = "/img/Importes/Maserati.jpg", Prix = 50 },
                new Importe() { ImporteId = 2, Name = "McLaren 720s", ImgPath = "/img/Importes/McLaren720s.jpg", Prix = 50 }
                );
        }
    }
}
