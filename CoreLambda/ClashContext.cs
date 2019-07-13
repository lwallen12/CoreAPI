using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreLambda.Controllers;


namespace Clash
{
    public class ClashContext : DbContext
    {
        public ClashContext(DbContextOptions<ClashContext> options)
            : base(options)
        {
        }
        public DbSet<CoreLambda.Models.CardInfo> CardInfo { get; set; }


    }
}