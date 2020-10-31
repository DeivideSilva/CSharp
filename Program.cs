using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ConsoleApp1
{
    //Entidade
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }

    //Classe de contexto
    public class AppDbContext : DbContext {
        //mapeamento da entidade para a tabela
        public DbSet <Produto> Produtos { get; set; }
        //provedor e a string de conexão
         protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-FA2LSQI\\SQLEXPRESS;" + "Initial Catalog=Aula1DB;Integrated Security=true");
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(new Produto 
            { 
                ProdutoId = 6,
                Nome = "Etiquetas",
                Preco = 11.30M,
                Estoque = 13
            });

        }
    }

    class Program
    {
        public static void Main(string[] args)
        {

            using (var db = new AppDbContext())
            {
                //popular com dados dos produtos
                SeedDataBase.SeedProdutos(db);

                //exibir produtos
                var produtos = db.Produtos.ToList();

                 foreach(var p  in produtos)
                {
                    Console.WriteLine(p.Nome + "\t" + p.Preco.ToString("c"));
                }
            }
            Console.ReadLine();
        }
    }
}
