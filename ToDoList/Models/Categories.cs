namespace ToDoList.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Categories
    {
        public Categories()
        {
        }

        [Key]
        public long CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Color { get; set; }
    }
}
