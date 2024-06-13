using Microsoft.Extensions.DependencyInjection;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Managers;
using LogicClassLibrary.Service_Classes;
using LogicClassLibrary.Interface.Service;
using DataAccessLibrary;
using LogicClassLibrary.Interface.Algorhitmic;
using LogicClassLibrary.Algorithmic;
using DTOs;
using LogicClassLibrary.Helpers;
using System;
using LogicClassLibrary.Interface.Helpers;

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

            // Service classes
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient<IInterpretationService, InterpretationService>();

            // Recommendation Specific Classes
            services.AddTransient<IRecommendationManager, RecommendationManager>();
            services.AddTransient<IRecommendationService, RecommendationService>();
            services.AddTransient<IRecommendationStrategy, BehaviorBasedRecommendation>();
            services.AddTransient<IRecommendationStrategy, ContentBasedRecommendation>();

            // Helpers
            services.AddTransient<IPasswordHelper, PasswordHelper>(); 

            // Controllers
            services.AddScoped<IDesktopController, DesktopController>();

            // Forms
            services.AddTransient<DesktopApp.Forms.Authentication>();

            return services.BuildServiceProvider();
        }
    }
}
