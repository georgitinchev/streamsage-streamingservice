using DataAccessLibrary;
using Microsoft.Extensions.Configuration;
using LogicClassLibrary.Algorithmic;
using LogicClassLibrary.Helpers;
using LogicClassLibrary.Interface.Algorhitmic;
using LogicClassLibrary.Interface.Helpers;
using LogicClassLibrary.Interface.Manager;
using LogicClassLibrary.Interface.Service;
using LogicClassLibrary.Managers;
using LogicClassLibrary.Service_Classes;
using Microsoft.AspNetCore.Authentication.Cookies;
using StreamSageWAD;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("StreamSageDb");
builder.Services.AddRazorPages();
builder.Services.AddScoped<IWebController, WebController>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<IInterpretationService, InterpretationService>();
builder.Services.AddScoped<IRecommendationService, RecommendationService>();
builder.Services.AddScoped<IMovieManager, MovieManager>();
builder.Services.AddScoped<IUserManager, UserManager>();
builder.Services.AddScoped<IReviewManager, ReviewManager>();
builder.Services.AddScoped<IInterpretationManager, InterpretationManager>();
builder.Services.AddScoped<IRecommendationManager, RecommendationManager>();
builder.Services.AddScoped<BehaviorBasedRecommendation>();
builder.Services.AddScoped<ContentBasedRecommendation>();
builder.Services.AddScoped<IPasswordHelper, PasswordHelper>();
builder.Services.AddScoped<IMovieDAL>(serviceProvider => new MovieDAL(connectionString));
builder.Services.AddScoped<IUserDAL>(serviceProvider => new UserDAL(connectionString));
builder.Services.AddScoped<IInterpretationDAL>(serviceProvider => new InterpretationDAL(connectionString));
builder.Services.AddScoped<IReviewDAL>(serviceProvider => new ReviewDAL(connectionString));
builder.Services.AddScoped<RandomPageSelector>();


builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
	options.IdleTimeout = TimeSpan.FromMinutes(5);
	options.Cookie.HttpOnly = true;
	options.Cookie.IsEssential = true;
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options =>
	{
		options.LoginPath = new PathString("/Login");
		options.AccessDeniedPath = new PathString("/Error");
	});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

