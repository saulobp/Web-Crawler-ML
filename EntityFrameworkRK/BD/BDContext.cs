using EntityFrameworkRK.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkRK.BD
{
    public class BDContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoML> ProdutosML { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CategoriaML> CategoriasMl { get; set; }
        public DbSet<PaginacaoML> PaginacoesML { get; set; }
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
            }

            optionsBuilder.UseSqlServer(@"Server=localhost\express; Database = oberlo; Integrated Security = True");
        }
    }
}
