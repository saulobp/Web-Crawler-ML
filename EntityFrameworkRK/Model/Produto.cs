using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRK.Model
{
    public class Produto
    {
        public Guid Id { get; set; }
        public int Ordem { get; set; }
        public string CodigoSite { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Preco { get; set; }

        public string PrecoHistorico { get; set; }

        public string FornecedorNome { get; set; }

        public string FornecedorLink { get; set; }

        public string QtdVisualizacaoShopify { get; set; }

        public string QtdPedido30D { get; set; }

        public string QtdPedido60D { get; set; }

        public string QtdImportacao { get; set; }

        public string Avaliacao { get; set; }

        public virtual Guid CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        public DateTime DataExtracao { get; set; }

        public string Url { get; set; }

        public Boolean IsCompleted { get; set; }
        public Boolean IsAliexpress { get; set; }
    }
}
