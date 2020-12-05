using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRK.Model
{
   public class Categoria
    {
        public Guid Id { get; set; }
        public string CodigoSite { get; set; }
        public string Nome { get; set; }
        public string XPath { get; set; }
        public Boolean IsPai { get; set; }
        public virtual System.Nullable<Guid> CategoriaMLId { get; set; }
        public virtual ICollection<CategoriaML> CategoriaMLs { get; set; }
        public virtual System.Nullable<Guid> CategoriaId { get; set; }
        public virtual ICollection<Categoria> Categorias { get; set; }
    }
}
