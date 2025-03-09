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
        [MaxLength(30)]
        [DisplayName("類別名稱")]
        public string Name { get; set; }

        [Range(0, 100)]
        [DisplayName("顯示順序")]
        public int DisplayOrder { get; set; }
    }
}
