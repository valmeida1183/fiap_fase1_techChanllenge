using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Configuration.Seed;
public static class DirectDistanceDialingSeed
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DirectDistanceDialing>().HasData(

            // São Paulo
            new DirectDistanceDialing { Id = 11, Region = "São Paulo", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 12, Region = "São Paulo", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 13, Region = "São Paulo", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 14, Region = "São Paulo", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 15, Region = "São Paulo", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 16, Region = "São Paulo", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 17, Region = "São Paulo", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 18, Region = "São Paulo", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 19, Region = "São Paulo", CreatedOn = DateTime.UtcNow },

            // Rio de Janeiro
            new DirectDistanceDialing { Id = 21, Region = "Rio de Janeiro", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 22, Region = "Rio de Janeiro", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 24, Region = "Rio de Janeiro", CreatedOn = DateTime.UtcNow },

            // Espírito Santo
            new DirectDistanceDialing { Id = 27, Region = "Espírito Santo", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 28, Region = "Espírito Santo", CreatedOn = DateTime.UtcNow },

            // Minas Gerais
            new DirectDistanceDialing { Id = 31, Region = "Minas Gerais", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 32, Region = "Minas Gerais", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 33, Region = "Minas Gerais", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 34, Region = "Minas Gerais", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 35, Region = "Minas Gerais", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 37, Region = "Minas Gerais", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 38, Region = "Minas Gerais", CreatedOn = DateTime.UtcNow },

            // Paraná
            new DirectDistanceDialing { Id = 41, Region = "Paraná", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 42, Region = "Paraná", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 43, Region = "Paraná", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 44, Region = "Paraná", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 45, Region = "Paraná", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 46, Region = "Paraná", CreatedOn = DateTime.UtcNow },

            // Santa Catarina
            new DirectDistanceDialing { Id = 47, Region = "Santa Catarina", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 48, Region = "Santa Catarina", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 49, Region = "Santa Catarina", CreatedOn = DateTime.UtcNow },

            // Rio Grande do Sul
            new DirectDistanceDialing { Id = 51, Region = "Rio Grande do Sul", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 53, Region = "Rio Grande do Sul", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 54, Region = "Rio Grande do Sul", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 55, Region = "Rio Grande do Sul", CreatedOn = DateTime.UtcNow },

            // Distrito Federal
            new DirectDistanceDialing { Id = 61, Region = "Distrito Federal", CreatedOn = DateTime.UtcNow },

            // Goiás
            new DirectDistanceDialing { Id = 62, Region = "Goiás", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 64, Region = "Goiás", CreatedOn = DateTime.UtcNow },

            // Mato Grosso
            new DirectDistanceDialing { Id = 65, Region = "Mato Grosso", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 66, Region = "Mato Grosso", CreatedOn = DateTime.UtcNow },

            // Mato Grosso do Sul
            new DirectDistanceDialing { Id = 66, Region = "Mato Grosso do Sul", CreatedOn = DateTime.UtcNow },

            // Alagoas
            new DirectDistanceDialing { Id = 82, Region = "Alagoas", CreatedOn = DateTime.UtcNow },

            // Bahia
            new DirectDistanceDialing { Id = 71, Region = "Bahia", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 73, Region = "Bahia", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 74, Region = "Bahia", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 75, Region = "Bahia", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 77, Region = "Bahia", CreatedOn = DateTime.UtcNow },

            // Ceará
            new DirectDistanceDialing { Id = 85, Region = "Ceará", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 88, Region = "Ceará", CreatedOn = DateTime.UtcNow },

            // Maranhão
            new DirectDistanceDialing { Id = 98, Region = "Maranhão", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 99, Region = "Maranhão", CreatedOn = DateTime.UtcNow },

            // Paraíba
            new DirectDistanceDialing { Id = 83, Region = "Paraíba", CreatedOn = DateTime.UtcNow },

            // Pernambuco
            new DirectDistanceDialing { Id = 81, Region = "Pernambuco", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 87, Region = "Pernambuco", CreatedOn = DateTime.UtcNow },

            // Piauí
            new DirectDistanceDialing { Id = 86, Region = "Piauí", CreatedOn = DateTime.UtcNow },
            new DirectDistanceDialing { Id = 89, Region = "Piauí", CreatedOn = DateTime.UtcNow },

            // Rio Grande do Norte
            new DirectDistanceDialing { Id = 84, Region = "Rio Grande do Norte", CreatedOn = DateTime.UtcNow },

            // Sergipe
            new DirectDistanceDialing { Id = 79, Region = "Sergipe", CreatedOn = DateTime.UtcNow }
        );
    }
}