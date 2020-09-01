using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspDotNetDoc.Models;

namespace AspDotNetDoc.Data
{
    public class AspDotNetDocContext : DbContext
    {
        public AspDotNetDocContext (DbContextOptions<AspDotNetDocContext> options)
            : base(options)
        {
        }

        public DbSet<AspDotNetDoc.Models.Movie> Movie { get; set; }
    }
}
