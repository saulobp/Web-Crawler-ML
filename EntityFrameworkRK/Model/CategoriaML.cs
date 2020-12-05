using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRK.Model
{
    public class CategoriaML
    {
        public Guid Id { get; set; }
        public string CodigoSite { get; set; }
        public string Nome { get; set; }
        public string XPath { get; set; }
        public Boolean IsPai { get; set; }

        public string Url { get; set; }

        public string TotalProdutos { get; set; }
        
        public virtual ICollection<PaginacaoML> Paginacoes { get; set; }

    }
}
