using System;
using AutoMapper;
using Flipper.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;

namespace Flipper
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CommanderContext>(opt => opt.UseSqlServer(
                Configuration.GetConnectionString("CommanderConnection")));

            services.AddDbContext<GroupsContext>(opt => opt.UseSqlServer(
                Configuration.GetConnectionString("GroupsConnection")));

            services.AddDbContext<UsersContext>(opt => opt.UseSqlServer(
                Configuration.GetConnectionString("UsersConnection")));

            services.AddDbContext<GroupsxUsersContext>(opt => opt.UseSqlServer(
                Configuration.GetConnectionString("GroupsxUsersConnection")));

            services.AddDbContext<IconsUserContext>(opt => opt.UseSqlServer(
                Configuration.GetConnectionString("IconsUserConnection")));

            services.AddDbContext<IconsGroupContext>(opt => opt.UseSqlServer(
                Configuration.GetConnectionString("IconsGroupConnection")));

            services.AddDbContext<MessagesContext>(opt => opt.UseSqlServer(
                Configuration.GetConnectionString("MessagesConnection")));

            services.AddControllers().AddNewtonsoftJson(s =>
            {
                s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });            

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            
            services.AddScoped<ICommanderRepo, SqlCommanderRepo>();
            
            services.AddScoped<IGroupsRepo, SqlGroupsRepo>();

            services.AddScoped<IUsersRepo, SqlUsersRepo>();

            services.AddScoped<IGroupsxUsersRepo, SqlGroupsxUsersRepo>();

            services.AddScoped<IIconsUserRepo, SqlIconsUserRepo>();

            services.AddScoped<IIconsGroupRepo, SqlIconsGroupRepo>();

            services.AddScoped<IMessagesRepo, SqlMessagesRepo>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); 
            });
        }
    }
}
