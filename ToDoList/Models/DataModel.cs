namespace ToDoList.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<Alerts> Alerts { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alerts>()
                .Property(e => e.DateTime)
                .HasPrecision(53, 0);

            modelBuilder.Entity<Alerts>()
                .Property(e => e.Active)
                .HasPrecision(53, 0);

            modelBuilder.Entity<Tasks>()
                .Property(e => e.CreationDateTime)
                .HasPrecision(53, 0);

            modelBuilder.Entity<Tasks>()
                .Property(e => e.TaskDateTime)
                .HasPrecision(53, 0);

            modelBuilder.Entity<Tasks>()
                .Property(e => e.Completed)
                .HasPrecision(53, 0);
        }
    }
}
