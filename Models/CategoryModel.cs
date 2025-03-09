using System.ComponentModel;
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
        [DisplayName("類別名稱")]
        public string Name { get; set; }

        [DisplayName("類別名稱")]
        public int DisplayOrder { get; set; }
    }
}
