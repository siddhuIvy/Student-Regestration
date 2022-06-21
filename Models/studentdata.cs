using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Student_Regestration.Models
{
    public partial class studentdata : DbContext
    {
        public studentdata()
            : base("name=studentdata")
        {
        }

        public virtual DbSet<student> students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<student>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.Dept)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.city)
                .IsUnicode(false);
        }
    }
}
