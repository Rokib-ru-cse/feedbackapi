using feedbackapi.DAL.DbSeed.CategorySeed;
using feedbackapi.DAL.DbSeed.SubCategorySeed;

namespace feedbackapi.Utils
{
    public class Seed
    {
        private readonly CategoryDbInitializer categoryDbInitializer;
        private readonly SubCategoryDbInitializer subCategoryDbInitializer;
        public Seed(
            CategoryDbInitializer categoryDbInitializer,
            SubCategoryDbInitializer subCategoryDbInitializer)
        {
            this.categoryDbInitializer = categoryDbInitializer;
            this.subCategoryDbInitializer = subCategoryDbInitializer;
        }
        public void SeedData()
        {
            categoryDbInitializer.SeedCategory();
            subCategoryDbInitializer.SeedSubCategory();
        }
    }
}
