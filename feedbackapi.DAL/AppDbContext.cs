using feedbackapi.Model.EntityModels;
using feedbackapi.Model.IdentityModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace feedbackapi.DAL
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<FeedbackImage> FeedbackImages { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<ReportRequest> ReportRequests { get; set; }
        public DbSet<ReportResponse> ReportResponses { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<WishList> WishLists { get; set; }

    }
}
