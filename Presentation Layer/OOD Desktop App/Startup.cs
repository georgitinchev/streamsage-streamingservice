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
        private readonly string _connectionString = "Server=mssqlstud.fhict.local;Database=dbi524441_streamsage;User Id = dbi524441_streamsage; Password=e9999619;TrustServerCertificate=true";
        public IServiceProvider ConfigureServices()
        {

            var services = new ServiceCollection();

            // DAL Classes
            services.AddTransient<IUserDAL>(provider => new UserDAL(_connectionString));
            services.AddTransient<IMovieDAL>(provider => new MovieDAL(_connectionString));
            services.AddTransient<IReviewDAL>(provider => new ReviewDAL(_connectionString));
            services.AddTransient<IInterpretationDAL>(provider => new InterpretationDAL(_connectionString));

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
