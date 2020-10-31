using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SeedDataBase
    {
        public static void SeedProdutos(AppDbContext context)
        {
            if (!context.Produtos.Any())
            {
                var produtos = new List<Produto> 
                { 
                    new Produto {Nome = "Compasso", Preco=8.20M, Estoque=65},
                    new Produto {Nome="Transferidor",Preco=10.00M, Estoque=70}
                };
                context.AddRange(produtos);
                context.SaveChanges();

            }
            
        }
    }
}
