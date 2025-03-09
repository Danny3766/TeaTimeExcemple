using System.ComponentModel.DataAnnotations;

namespace TeaTimeExample.Models
{
    /// <summary>
    /// 類別
    /// </summary>
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
