using BookStore.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.AppDbContext
{
	public class Context:IdentityDbContext
	{
        public Context(DbContextOptions<Context> contextOptions):base(contextOptions)
        {
                
        }
        public DbSet<Book> Books{ get; set; }
		public DbSet<Author> Authors { get; set; }
		

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			base.OnModelCreating(modelBuilder);
		}
		
	}
}
