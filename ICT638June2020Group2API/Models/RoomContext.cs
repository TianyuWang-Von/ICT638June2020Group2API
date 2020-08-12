using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICT638June2020Group2API.Models
{
    public class RoomContext : DbContext
    {
        public RoomContext(DbContextOptions<RoomContext> op) : base(op)
        { }

        public DbSet<RoomInfo> roomInfos;

        public DbSet<ICT638June2020Group2API.Models.RoomInfo> roomInfo { get; set; }
    }
}
