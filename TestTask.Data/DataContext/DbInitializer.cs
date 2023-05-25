using TestTask.Data.Models;

namespace TestTask.Data.DataContext
{
    public class DbInitializer
    {
        public async static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Categories.Any())
            {
                var waterCategory = new Category { Name = "water" };
                var telecommunicationCategory = new Category { Name = "telecommunication" };
                var graphicWorksCategory = new Category { Name = "graphic-works" };
                var airCategory = new Category { Name = "air" };
                var tvRentCategory = new Category { Name = "tv-rent" };


                var products = new Product[]
                {
                        new Product { Name = "standard1", Categories = new List<Category>(){ waterCategory,telecommunicationCategory}},
                        new Product { Name = "standard2", Categories = new List<Category>(){ graphicWorksCategory,telecommunicationCategory}},
                        new Product { Name = "standard3", Categories = new List<Category>(){ airCategory,telecommunicationCategory}},
                        new Product { Name = "standard4", Categories = new List<Category>(){ waterCategory,tvRentCategory}},
                        new Product { Name = "standard5", Categories = new List<Category>(){ waterCategory,telecommunicationCategory}},
                        new Product { Name = "standard6", Categories = new List<Category>(){ waterCategory,telecommunicationCategory}},
                        new Product { Name = "standard7"},
                        new Product { Name = "standard8"},
                        new Product { Name = "standard9", Categories = new List<Category>(){ airCategory,tvRentCategory}},
                        new Product { Name = "standard10", Categories = new List<Category>(){ graphicWorksCategory,airCategory}},

                };

                await context.AddRangeAsync(products);
            }

            context.SaveChanges();
        }
    }
}
