using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BeerStore.Models
{
    public class conect: DbContext
    {
        public DbSet<cadastro> Cadastro { get; set; }
    }
}