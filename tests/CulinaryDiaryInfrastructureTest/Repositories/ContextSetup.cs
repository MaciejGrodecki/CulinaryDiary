namespace CulinaryDiary.Infrastructure.Test.Repositories;
public static class ContextSetup
{
    public static InMemoryTestContext GetInMemoryTestContext()
    {
        var options = new DbContextOptionsBuilder<CulinaryDiaryContext>()
                .UseInMemoryDatabase(databaseName: "IngDb")
                .Options;

        IOptions<SqlServerSettings> sqlOptions = Options.Create<SqlServerSettings>(new SqlServerSettings());

        return new InMemoryTestContext(options, sqlOptions);
    }
}
