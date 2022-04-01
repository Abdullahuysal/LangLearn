using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class LangLearnDbContext:DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2DE1HM4\\SQLEXPRESS,Database=LangLearnDb;Integrated Security=True");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins{ get; set; }
        public DbSet<Word> Words { get; set; }

    }
}
