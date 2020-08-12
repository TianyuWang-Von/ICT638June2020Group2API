using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICT638June2020Group2API.Models
{
    public class AgentContext : DbContext
    {
        public AgentContext(DbContextOptions<AgentContext> options)
            : base(options)
        {
        }

        public DbSet<Agent> Agents { get; set; }
    }
}
