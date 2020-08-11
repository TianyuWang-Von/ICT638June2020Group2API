using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ICT638June2020Group2API.Models
{
    public class RegisterContext : DbContext
    {
        public RegisterContext(DbContextOptions<RegisterContext> options)
            : base(options)
        {
        }

        public DbSet<Register> Registers { get; set; }
    }
}
