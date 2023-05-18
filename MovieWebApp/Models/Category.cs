using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieWebApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayName("Görüntülenme Sırası")]
        [Range(1, 100, ErrorMessage = "Çok uzun!")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
