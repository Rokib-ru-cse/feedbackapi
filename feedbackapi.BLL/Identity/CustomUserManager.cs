using feedbackapi.BLL.Repository;
using feedbackapi.DAL;
using feedbackapi.Model.IdentityModels;
using feedbackapi.Model.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MySqlConnector;

namespace feedbackapi.BLL.Identity
{
    public class CustomUserManager<TUser> : UserManager<ApplicationUser>
    {
        private readonly AppDbContext _context;
        private MySqlConnection conn;
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        private readonly IMySqlTransactionRepository _mySqlTransactionRepository;


        public CustomUserManager(IUserStore<ApplicationUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<ApplicationUser> passwordHasher, IEnumerable<IUserValidator<ApplicationUser>> userValidators, IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<ApplicationUser>> logger, AppDbContext context, IConfiguration configuration, IMySqlTransactionRepository mySqlTransactionRepository) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            _context = context;
            _configuration = configuration;
            _connectionString = _configuration["ConnectionStrings:DefaultConnection"];
            _mySqlTransactionRepository = mySqlTransactionRepository;
            this.conn = new MySqlConnection(_connectionString);
        }

        public Task<ApplicationUser> GetUserByEmail(string email)
        {
            ReturnResultWithClass<ApplicationUser> returnResult = new ReturnResultWithClass<ApplicationUser>();

            List<ApplicationUser> userList = new List<ApplicationUser>();

            userList = _context.Set<ApplicationUser>().Where(mr => mr.NormalizedEmail == email.ToUpper()).ToList();


            if (userList.Count == 0)
            {
                return Task.FromResult(new ApplicationUser());
            }
            else
            {

                return Task.FromResult(userList.FirstOrDefault());
            }
        }

    }
}
