using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRK.Model
{
    public class ProdutoML
    {
        public Guid Id { get; set; }
        public String Url { get; set; }
        public String TotalVendas { get; set; }
        public String NomeProdutos { get; set; }
        public String Preco { get; set; }
        public String Descricao { get; set; }
        public String TotalVendasUltimos4 { get; set; }
        public String Caracteristicas { get; set; }
        public DateTime DataExtracao { get; set; }

        public Boolean IsCompleted { get; set; }
        public System.Nullable<Guid> CategoriaId { get; set; }
        public virtual CategoriaML Categoria { get; set; }
    }
}
