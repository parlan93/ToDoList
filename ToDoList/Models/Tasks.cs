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
        [StringLength(2147483647)]
        public string Name { get; set; }

        public decimal? CreationDateTime { get; set; }

        public decimal? TaskDateTime { get; set; }

        public decimal? Completed { get; set; }

        public long? CategoryId { get; set; }

        public long? AlertId { get; set; }

        public virtual Alerts Alerts { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
