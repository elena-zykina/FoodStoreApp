using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodStoreApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
    }
}
