using FakeXC.API.Database;
using FakeXC.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FakeXC.API.IServiceTest;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using FakeXC.API.Models;

namespace FakeXC.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

            //���������Ϊ��ʹ�� [Authorize] ��ǩ
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => {
                    var seccretByte = Encoding.UTF8.GetBytes(Configuration["Authentication:Secretkey"]);
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidIssuer = Configuration["Authentication:Issuer"],

                        ValidateAudience = true,
                        ValidAudience = Configuration["Authentication:Audience"],

                        ValidateLifetime = true,
                        IssuerSigningKey = new SymmetricSecurityKey(seccretByte)
                    };
                });
            services.AddControllers(setupAction=> {
                //���� application/json ���ݸ�ʽ��ͷ��
                setupAction.ReturnHttpNotAcceptable = true;
                //��Ӷ� XML output ��֧��
            }).AddNewtonsoftJson(setupAction=>
            {
                setupAction.SerializerSettings.ContractResolver = new DefaultContractResolver();
            })
                .AddXmlDataContractSerializerFormatters()
            //����������֤����ʱ���� 422
            .ConfigureApiBehaviorOptions(setupAction=> {
                setupAction.InvalidModelStateResponseFactory = context =>
                {
                    var problemDetail = new ValidationProblemDetails(context.ModelState)
                    {
                        Type = "����ν",
                        Title = "������֤ʧ��",
                        Status = 422,
                        Detail = "�뿴��ϸ˵��",
                        Instance = context.HttpContext.Request.Path
                    };
                    problemDetail.Extensions.Add("traceId", context.HttpContext.TraceIdentifier);
                    return new UnprocessableEntityObjectResult(problemDetail)
                    {
                        ContentTypes = { "application/problem+json" }
                    };
                };
            })
            ;
            
            services.AddTransient<ITouristRouteRepository, TouristRouteRepository>();
            services.AddDbContext<AppDbContext>(option=> {
                //option.UseSqlServer("server=localhost;Database=FakeXC;User Id=sa;Password=Password12!");
                option.UseSqlServer(Configuration["DbContext:connectstring"]);
            });
            //��� automapper ���񣬻�ɨ��ProfilesĿ¼����� profile �ļ�
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FakeXC.API", Version = "v1" });
            });
            services.AddStone(stone =>
            {
                stone.Name = "lee";
                stone.Age = 18;
            }
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FakeXC.API v1"));
            }

            app.UseHttpsRedirection();

            //������
            app.UseRouting();
            //����˭
            app.UseAuthentication();
            //����Ը�ʲô
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
