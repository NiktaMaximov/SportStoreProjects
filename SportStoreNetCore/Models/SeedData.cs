using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SportStoreNetCore.Models.DAL;
using System.Linq;

namespace SportStoreNetCore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder builder)
        {
            StoreDBContext context = builder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDBContext>();

            if (context.Database.GetPendingMigrations().Any())
                context.Database.Migrate();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Каяк",
                        Description = "Лодка для одного человека",
                        Category = "Водный спорт",
                        Price = 275m
                    },
                    new Product
                    {
                        Name = "Спасательный жилет",
                        Description = "Зашитный и модный",
                        Category = "Водный спорт",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Футбольный мяч",
                        Description = "Размер и вес, одобренные ФИФА",
                        Category = "Футбол",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Угловые флаги",
                        Description = "Придайте вашему игровому полю профессиональный оттенок",
                        Category = "Футбол",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Стадион",
                        Description = "Переполненный стадион на 35 000 мест",
                        Category = "Футбол",
                        Price = 79500m
                    },
                    new Product
                    {
                        Name = "Мыслящий колпачок",
                        Description = "Повысить эффективность работы мозга на 75%",
                        Category = "Шахматы",
                        Price = 16m
                    },
                    new Product
                    {
                        Name = "Шаткий стул",
                        Description = "Тайно поставьте своего противника в невыгодное положение",
                        Category = "Шахматы",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Человеческая шахматная доска",
                        Description = "Веселая игра для всей семьи",
                        Category = "Шахматы",
                        Price = 75m
                    },
                    new Product
                    {
                        Name = "Король побрякушек-побрякушек",
                        Description = "Позолоченный, усыпанный бриллиантами король",
                        Category = "Шахматы",
                        Price = 1200m
                    });
            }

            context.SaveChanges();
        }
    }
}
