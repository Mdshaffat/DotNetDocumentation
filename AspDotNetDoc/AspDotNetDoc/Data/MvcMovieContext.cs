using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspDotNetDoc.Models;
namespace AspDotNetDoc.Data
{
	public class MvcMovieContext : DbContext
	{
		public MvcMovieContext(DbContextOptions<MvcMovieContext> option)
			: base(option)
		{

		}
		public DbSet<Movie> Movie { get; set; }


	}
}
