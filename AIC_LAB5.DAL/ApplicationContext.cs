using AIC_LAB5.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC_LAB5.DAL
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Student> Students { get; set; } = null!;

        public string DbPath { get; }

        public ApplicationContext()
        {
            string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DbPath = Path.Combine(BaseDirectory, "Data");


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"Data Source=(localdb)\mssqllocaldb;AttachDbFilename={DbPath}\students.mdf;Integrated Security=True; Initial Catalog=DecanatDb;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(u => u.Id);
        }

    }
}
