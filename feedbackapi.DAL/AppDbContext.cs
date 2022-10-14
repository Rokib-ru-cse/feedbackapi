using feedbackapi.Model.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace feedbackapi.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<FeedbackImage> FeedbackImages { get; set; }



    }
}
