namespace ToDoList.Models
{
    using System.ComponentModel.DataAnnotations;

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
