using Microsoft.EntityFrameworkCore;
using TeaTimeExample.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // 自定義的資料表：
    public DbSet<CategoryModel> Categories { get; set; }

    /// <summary>
    /// <para>用來配置資料模型，包括定義實體類別與資料表之間的對應關係、欄位屬性、關聯以及其他資料庫配置。</para>
    /// <para>此方法可用來設定主鍵、外鍵、欄位長度、必填欄位、資料表名稱等。</para> 
    /// <para>通常在此方法中設置自訂邏輯或覆蓋 EF Core 的預設映射行為。</para>
    /// </summary>
    /// <param name="modelBuilder">提供一個 API，用來配置資料庫模型，包括實體的屬性、關聯與約束等。</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryModel>().HasData(
            new CategoryModel { Id = 1, Name = "茶飲", DisplayOrder = 1 },
            new CategoryModel { Id = 1, Name = "水果茶", DisplayOrder = 2 },
            new CategoryModel { Id = 1, Name = "咖啡", DisplayOrder = 3 }
            );

        base.OnModelCreating(modelBuilder);
    }
}
