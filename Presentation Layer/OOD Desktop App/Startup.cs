using Microsoft.Extensions.DependencyInjection;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Managers;
using LogicClassLibrary.Service_Classes;
using LogicClassLibrary.Interface.Service;
using DataAccessLibrary;
using LogicClassLibrary.Interface.Algorhitmic;
using LogicClassLibrary.Algorithmic;

namespace DesktopApp
{
    public class Startup
    {
        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // DAL Classes
            services.AddTransient<IUserDAL, UserDAL>();
            services.AddTransient<IMovieDAL, MovieDAL>();
            services.AddTransient<IReviewDAL, ReviewDAL>();
            services.AddTransient<IInterpretationDAL, InterpretationDAL>();
       

            // Business Logic Layer
            services.AddTransient<IUserManager, UserManager>();
            services.AddTransient<IMovieManager, MovieManager>();
            services.AddTransient<IReviewManager, ReviewManager>();
            services.AddTransient<IInterpretationManager, InterpretationManager>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient<IInterpretationService, InterpretationService>();

            // Recommendation Specific Classes
            services.AddTransient<IRecommendationManager, RecommendationManager>();
            services.AddTransient<IRecommendationService, RecommendationService>();
            services.AddTransient<IRecommendationStrategy, BehaviorBasedRecommendation>();
            services.AddTransient<IRecommendationStrategy, ContentBasedRecommendation>();

            // Forms
            services.AddTransient<DesktopApp.Forms.Authentication>();

            return services.BuildServiceProvider();
        }
    }
}
