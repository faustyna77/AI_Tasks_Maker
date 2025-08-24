using System.ComponentModel.DataAnnotations;

namespace AI_Tasks_Maker.Models.Domains
{
    public class Category
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
