using Microsoft.EntityFrameworkCore;
using Persistence.Configuration.Seed;

namespace Persistence.Configuration.Extension;
public static class ModelBuilderExtension
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        DirectDistanceDialingSeed.Seed(modelBuilder);
    }
}
