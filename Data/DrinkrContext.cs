using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Drinkr.Models;

namespace Drinkr.Models
{
    public class DrinkrContext : DbContext
    {
        public DrinkrContext (DbContextOptions<DrinkrContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Motorista> Motorista { get; set; }
        public DbSet<Corrida> Corrida { get; set; }
        public DbSet<Carro> Carro { get; set; }
        public DbSet<Cartao> Cartao { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

    }
}
