
using business.Abstract;
using business.Concrete;
using data.Abstract;
using data.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace uiweb
{
    public class Startup
    {
        IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<ISocialRepo, SocialRepo>();
            services.AddScoped<IAboutRepo, AboutRepo>();
            services.AddScoped<IBlogRepo, BlogRepo>();
            services.AddScoped<ITagRepo, TagRepo>();
            services.AddScoped<ICommentRepo, CommentRepo>();
            services.AddScoped<IMusicRepo, MusicRepo>();
            services.AddScoped<IAuthorRepo, AuthorRepo>();


            services.AddScoped<ISocialService, SocialManager>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<ITagService, TagManager>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IMusicService, MusicManager>();
            services.AddScoped<IAuthorService, AuthorManager>();


            services.AddDbContext<BlogContext>(options => options.UseSqlite(_configuration.GetConnectionString("Source")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {


                endpoints.MapControllerRoute(
                   name: "error",
                   pattern: "Error-404",
                   defaults: new { controller = "home", action = "error" });
              
                endpoints.MapControllerRoute(
                    name: "blog",
                    pattern: "home/blog",
                    defaults: new { controller = "home", action = "blog" });


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
