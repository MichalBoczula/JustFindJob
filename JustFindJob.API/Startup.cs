using IdentityServer4.AccessTokenValidation;
using IdentityServer4.Services;
using JustFindJob.API.HttpHandlers;
using JustFindJob.API.Service;
using JustFindJob.Application;
using JustFindJob.Application.Contracts.Identity;
using JustFindJob.Persistance;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustFindJob.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private readonly string _myOriginName = "IdentityServer";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddTransient<BearerTokenHandler>();
            services.AddApplication();
            services.AddPersistance(Configuration);
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "JustFindJob.API", Version = "v1" });
            });
            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
                .AddIdentityServerAuthentication(opt =>
                {
                    opt.Authority = "https://localhost:5000/";
                    opt.ApiName = "justfindjobapi";
                })
                .AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme, opt =>
                {
                    opt.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                    opt.Authority = "https://localhost:5000/";
                    opt.ClientId = "justfindjob";
                    opt.ResponseType = "code";
                    opt.Scope.Add("openid");
                    opt.Scope.Add("profile");
                    opt.Scope.Add("justfindjobapi");
                    opt.SaveTokens = true;
                    opt.ClientSecret = "this is my secret";
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "JustFindJob.API v1"));
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        //    // This method gets called by the runtime. Use this method to add services to the container.
        //    public void ConfigureServices(IServiceCollection services)
        //    {
        //        //services.AddCors(options =>
        //        //{
        //        //    options.AddPolicy(name: _myOriginName,
        //        //                  builder =>
        //        //                  {
        //        //                      builder.WithOrigins("http://example.com",
        //        //                                          "http://www.contoso.com")
        //        //                      .WithMethods("PUT", "POST", "GET");
        //        //                  });
        //        //});
        //        //services.AddAuthentication("Bearer")
        //        //    .AddJwtBearer("Bearer", opt =>
        //        //    {
        //        //        opt.Authority = "https://localhost:5001";
        //        //        opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
        //        //        {
        //        //            ValidateAudience = false
        //        //        };
        //        //    });
        //        //services.AddAuthentication(opt =>
        //        //{
        //        //    opt.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        //        //    opt.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
        //        //})
        //        //.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
        //        //.AddOpenIdConnect(CookieAuthenticationDefaults.AuthenticationScheme, opt =>
        //        //{
        //        //    opt.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        //        //    opt.Authority = "https://localhost:5000";
        //        //    opt.ClientId = "justfindjob";
        //        //    opt.ResponseType = "code";
        //        //    opt.UsePkce = false;
        //        //    opt.Scope.Add("openid");
        //        //    opt.Scope.Add("profile");
        //        //    opt.SaveTokens = true;
        //        //    opt.ClientSecret = "this is my secret";

        //        //});
        //        services.AddScoped<ICurrentUserService, CurrentUserService>();
        //        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        //        services.AddApplication();
        //        services.AddPersistance(Configuration);
        //        services.AddControllers();
        //        services.AddSwaggerGen(c =>
        //        {
        //            c.SwaggerDoc("v1", new OpenApiInfo { Title = "JustFindJob.API", Version = "v1" });
        //            //c.OperationFilter<AuthorizeCheckOperationFilter>();
        //            //c.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
        //            //{
        //            //    Type = SecuritySchemeType.OAuth2,

        //            //    Flows = new OpenApiOAuthFlows()
        //            //    {

        //            //        AuthorizationCode = new OpenApiOAuthFlow
        //            //        {
        //            //            AuthorizationUrl = new Uri("https://localhost:5001/connect/authorize"),
        //            //            TokenUrl = new Uri("https://localhost:5001/connect/token"),
        //            //            Scopes = new Dictionary<string, string>
        //            //            {
        //            //                {"JustFindJob", "Full access" },
        //            //                {"user", "User info" }
        //            //            }
        //            //        }
        //            //    }
        //            //});
        //        });
        //        //services.AddAuthorization(options =>
        //        //{
        //        //    options.AddPolicy("ApiScope", policy =>
        //        //    {
        //        //        policy.RequireAuthenticatedUser();
        //        //        policy.RequireClaim("scope", "JustFindJob");
        //        //    });
        //        //});
        //    }

        //    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //    {
        //        if (env.IsDevelopment())
        //        {
        //            app.UseDeveloperExceptionPage();
        //        }

        //        app.UseSwagger();
        //        app.UseSwaggerUI(c =>
        //        {
        //            c.SwaggerEndpoint("/swagger/v1/swagger.json", "JustFindJob.API v1");
        //            //c.OAuthClientId("swagger");
        //            //c.OAuth2RedirectUrl("http://localhost:59735/swagger/oauth2-redirect.html");
        //            //c.OAuthUsePkce();
        //        });
        //        app.UseHttpsRedirection();
        //        app.UseRouting();

        //        //app.UseCors(_myOriginName);
        //        //app.UseAuthentication();
        //        //app.UseAuthorization();

        //        app.UseEndpoints(endpoints =>
        //        {
        //            endpoints.MapControllers();
        //        });
        //    }
        //}
    }
}
