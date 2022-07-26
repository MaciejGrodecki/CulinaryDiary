namespace CulinaryDiary.Infrastructure.Database;

public class InMemoryTestContext : CulinaryDiaryContext
{
    public InMemoryTestContext(DbContextOptions<CulinaryDiaryContext> options, IOptions<SqlServerSettings> settings)
        : base(options, settings)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
}
