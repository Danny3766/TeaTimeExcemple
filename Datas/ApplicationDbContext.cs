using Microsoft.EntityFrameworkCore;
using TeaTimeExample.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // 自定義的資料表：
    
}
