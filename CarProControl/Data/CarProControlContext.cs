using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarProControl.Models;

namespace CarProControl.Data
{
    public class CarProControlContext : DbContext
    {
        public CarProControlContext (DbContextOptions<CarProControlContext> options)
            : base(options)
        {
        }

        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<OrdemServico> OrdemServicos { get; set; }
    }
}
