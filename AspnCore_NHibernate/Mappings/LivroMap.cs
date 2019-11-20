using AspnCore_NHibernate.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnCore_NHibernate.Mappings
{
    public class LivroMap : ClassMap<Livro>
    {
        public LivroMap()
        {
            Id(l => l.LivroId);
            Map(l => l.Titulo);
            Table("Livros");
        }
    }
}
