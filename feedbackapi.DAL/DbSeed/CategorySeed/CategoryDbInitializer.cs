using feedbackapi.DAL.Table;
using feedbackapi.Model.EntityModels;

namespace feedbackapi.DAL.DbSeed.CategorySeed
{
    public class CategoryDbInitializer
    {
        private readonly AppDbContext context;

        public CategoryDbInitializer(AppDbContext context)
        {
            this.context = context;
        }

        public void SeedCategory()
        {
            if (TableCheck.CheckTableExists<Category>(context))
            {
                if (!context.Categories.Any())
                {
                    var categories = new List<Category>()
                    {
                        new Category()
                        {
                            Id = 1,
                            Name = "Electronics",
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                        new Category()
                        {
                            Id = 2,
                            Name = "Food",
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                        new Category()
                        {
                            Id = 3,
                            Name = "Medical",
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        }
                    };
                    context.Categories.AddRange(categories);
                    context.SaveChanges();
                }
            }
        }
    }
}
