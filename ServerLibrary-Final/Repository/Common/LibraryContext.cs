using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repository
{
	internal class LibraryContext : DbContext
	{
		private LibraryContext() : base("Library")
		{
			
		}
		private static LibraryContext context;
		private static object obj = new object();
		public static LibraryContext gI()
		{
			if(context == null)
			{
				lock (obj)
				{
					if(context == null)
						context = new LibraryContext();
				}
			}
			return context;
		}
		public DbSet<User> Users { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<Rate> Rates { get; set; }
		public DbSet<ReadingStatus> ReadingStatus { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<BookTag> BookTags { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().ToTable("User");
			modelBuilder.Entity<Book>().ToTable("Book");
			modelBuilder.Entity<Rate>().ToTable("Rate");
			modelBuilder.Entity<ReadingStatus>().ToTable("ReadingStatus");
			modelBuilder.Entity<Tag>().ToTable("Tag");
			modelBuilder.Entity<BookTag>().ToTable("BookTag");
		}
	}
}
