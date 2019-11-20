using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnCore_NHibernate.Models
{
    public class Livro
    {
        public virtual int LivroId { get; set; }
        public virtual string Titulo { get; set; }
    }
}
