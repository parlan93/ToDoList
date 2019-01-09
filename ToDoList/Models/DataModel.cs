namespace ToDoList.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Configuration;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }

        public virtual DbSet<Alerts> Alerts { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }
}
