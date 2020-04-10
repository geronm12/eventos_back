using Comunidad.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comunidad.Dominio
{
    public class EntidadTesting: IEntityTypeConfiguration<Type>
    {
        public EntidadTesting(Type t)
        {

        }



        public void Configure(EntityTypeBuilder<Type> builder)
        { 

 

        }
    }
}
