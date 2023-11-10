using System.Data.Entity;

public class ApplicationDbContext : DbContext
{

    public DbSet<Student> Students { get; set; }
    public DbSet<UniversityCampus> UniversityCampuses { get; set; }
}
