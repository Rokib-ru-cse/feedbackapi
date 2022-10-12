using feedbackapi.DAL.Table;
using feedbackapi.Model.EntityModels;

namespace feedbackapi.DAL.DbSeed.SubCategorySeed
{
    public class SubCategoryDbInitializer
    {
        private readonly AppDbContext context;

        public SubCategoryDbInitializer(AppDbContext context)
        {
            this.context = context;
        }

        public void SeedSubCategory()
        {
            if (TableCheck.CheckTableExists<SubCategory>(context))
            {
                if (!context.SubCategories.Any())
                {
                    var subCategories = new List<SubCategory>()
                    {
                        new SubCategory()
                        {
                            Id = 1,
                            Name="Laptop",
                            CategoryId=1,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                        new SubCategory()
                        {
                            Id = 2,
                            Name="Mobile",
                            CategoryId=1,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                        new SubCategory()
                        {
                            Id = 3,
                            Name="Biriyani",
                            CategoryId=2,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                        new SubCategory()
                        {
                            Id = 4,
                            Name="Chicken",
                            CategoryId=2,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                        new SubCategory()
                        {
                            Id = 5,
                            Name="Doctor",
                            CategoryId=3,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                        new SubCategory()
                        {
                            Id = 6,
                            Name="Medicine",
                            CategoryId=3,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        },
                    };
                    context.SubCategories.AddRange(subCategories);
                    context.SaveChanges();
                }
            }
        }
    }
}
