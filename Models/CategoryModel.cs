using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeaTimeExample.Models
{
    /// <summary>
    /// 類別
    /// </summary>
    public class CategoryModel : IValidatableObject
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "類別名稱為必填欄位")]
        [MaxLength(30, ErrorMessage = "類別名稱最多 30 個字元")]
        [DisplayName("類別名稱")]
        public string Name { get; set; }

        [Range(0, 100, ErrorMessage = "輸入的範圍要在 1-100 之間")]
        [DisplayName("顯示順序")]
        public int DisplayOrder { get; set; }

        // 自訂驗證邏輯
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Name == DisplayOrder.ToString()) // 檢查 Name 是否與 DisplayOrder 相同
            {
                yield return new ValidationResult("類別名稱不能與顯示順序相同", ["Name"]);
            }
        }
    }
}
