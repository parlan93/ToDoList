namespace ToDoList.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tasks
    {
        [Key]
        public long TaskId { get; set; }

        [Required]
        //[StringLength(2147483647)]
        public string Name { get; set; }

        public DateTime CreationDateTime { get; set; }

        public DateTime TaskDateTime { get; set; }

        public bool Completed { get; set; }

        public long CategoryId { get; set; }

        public long AlertId { get; set; }

        public virtual Alerts Alerts { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
