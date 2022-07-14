using FakeXC.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXC.API.Database
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>//DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }
        public DbSet<TouristRoute> TouristRoutes { get; set; }
        public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region dataseedingTouristRoute
            modelBuilder.Entity<TouristRoute>().HasData(
               new[]
               {
                      new TouristRoute{
                      Id=new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                      Title = "黄山",
                      Description = "黄山一日游",
                      OriginalPrice = 1299,
                      Feature = "<p>吃住行购物<p>",
                      Fees = "<p>交通费自理<p>",
                      Notes = "<p>小心危险<p>",
                      CreateTime=DateTime.UtcNow,
                      Rating=4,
                      TravelDays=TravelDays.Five,
                      TripType=TripType.BackPackTour,
                      DepatureCity=DepatureCity.Beijing

                      }
               });
            modelBuilder.Entity<TouristRoutePicture>().HasData(
             new[]
             {
                      new TouristRoutePicture{
                        Id=1,
                        TouristRouteId=new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                        Url="www.image.com/30d318ad-e39c-4b8f-baa3-858431affc67.jpg"
                      },
                       new TouristRoutePicture{
                        Id=2,
                        TouristRouteId=new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                        Url="www.image.com/30d318ad-e39c-4b8f-baa3-858431affc67.jpg"
                      }
             });


            modelBuilder.Entity<TouristRoute>().HasData(
   new[]
   {
                      new TouristRoute{
                      Id=new Guid("20d318ad-e39c-4b8f-baa3-858431affc67"),
                      Title = "华山",
                      Description = "华山一日游",
                      OriginalPrice = 1299,
                      Feature = "<p>吃住行购物<p>",
                      Fees = "<p>交通费自理<p>",
                      Notes = "<p>小心危险<p>",
                      CreateTime=DateTime.UtcNow,
                       Rating=3,
                      TravelDays=TravelDays.Eight,
                      TripType=TripType.BackPackTour,
                      DepatureCity=DepatureCity.Beijing
                      }
   });
            modelBuilder.Entity<TouristRoutePicture>().HasData(
             new[]
             {
                      new TouristRoutePicture{
                        Id=3,
                        TouristRouteId=new Guid("20d318ad-e39c-4b8f-baa3-858431affc67"),
                        Url="www.image.com/20d318ad-e39c-4b8f-baa3-858431affc67.jpg"
                      },
                       new TouristRoutePicture{
                        Id=4,
                        TouristRouteId=new Guid("20d318ad-e39c-4b8f-baa3-858431affc67"),
                        Url="www.image.com/30d318ad-e39c-4b8f-baa3-858431affc67.jpg"
                      }
             });

            //
            modelBuilder.Entity<TouristRoute>().HasData(
new[]
{
                      new TouristRoute{
                      Id=new Guid("10d318ad-e39c-4b8f-baa3-858431affc67"),
                      Title = "华山",
                      Description = "华山一日游",
                      OriginalPrice = 1299,
                      Feature = "<p>吃住行购物<p>",
                      Fees = "<p>交通费自理<p>",
                      Notes = "<p>小心危险<p>",
                      CreateTime=DateTime.UtcNow,
                        Rating=3,
                      TravelDays=TravelDays.Eight,
                      TripType=TripType.BackPackTour,
                      DepatureCity=DepatureCity.Beijing
                      }
});
            modelBuilder.Entity<TouristRoutePicture>().HasData(
             new[]
             {
                      new TouristRoutePicture{
                        Id=5,
                        TouristRouteId=new Guid("10d318ad-e39c-4b8f-baa3-858431affc67"),
                        Url="www.image.com/10d318ad-e39c-4b8f-baa3-858431affc67.jpg"
                      },
                       new TouristRoutePicture{
                        Id=6,
                        TouristRouteId=new Guid("10d318ad-e39c-4b8f-baa3-858431affc67"),
                        Url="www.image.com/30d318ad-e39c-4b8f-baa3-858431affc67.jpg"
                      }
             });
            //
            modelBuilder.Entity<TouristRoute>().HasData(
new[]
{
                      new TouristRoute{
                      Id=new Guid("50d318ad-e39c-4b8f-baa3-858431affc67"),
                      Title = "华山",
                      Description = "华山一日游",
                      OriginalPrice = 1299,
                      Feature = "<p>吃住行购物<p>",
                      Fees = "<p>交通费自理<p>",
                      Notes = "<p>小心危险<p>",
                      CreateTime=DateTime.UtcNow,
                       Rating=3,
                      TravelDays=TravelDays.Eight,
                      TripType=TripType.BackPackTour,
                      DepatureCity=DepatureCity.Beijing
                      }
});
            modelBuilder.Entity<TouristRoutePicture>().HasData(
             new[]
             {
                      new TouristRoutePicture{
                        Id=7,
                        TouristRouteId=new Guid("50d318ad-e39c-4b8f-baa3-858431affc67"),
                        Url="www.image.com/50d318ad-e39c-4b8f-baa3-858431affc67.jpg"
                      },
                       new TouristRoutePicture{
                        Id=8,
                        TouristRouteId=new Guid("50d318ad-e39c-4b8f-baa3-858431affc67"),
                        Url="www.image.com/30d318ad-e39c-4b8f-baa3-858431affc67.jpg"
                      }
             });
            #endregion
            #region Identity
            //初始化用户与数据的种子数据
            //1.更新用户与角色的外键
            modelBuilder.Entity<ApplicationUser>(u => u.HasMany(x => x.UserRoles)
            .WithOne().HasForeignKey(ur => ur.UserId).IsRequired()
            );
            //2.添加管理员角色
            var adminRoleId = "8f677325-b612-4ba4-8852-4922cda2ee88";
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper()
                }
                ) ;

            //3添加用户
            var adminUserId = "8f677325-b612-4ba4-8852-4922cda2ee76";
            ApplicationUser adminUser = new ApplicationUser
            {
                Id = adminUserId,
                UserName = "admin@fakexc.com",
                NormalizedUserName = "admin@fakexc.com".ToUpper(),
                Email = "admin@fakexc.com",
                NormalizedEmail= "admin@fakexc.com".ToUpper(),
                TwoFactorEnabled=false,
                EmailConfirmed=true,
                PhoneNumber="123456789",
                PhoneNumberConfirmed=false
            };
            var ph = new PasswordHasher<ApplicationUser>();
            adminUser.PasswordHash = ph.HashPassword(adminUser, "Pass@123");
            modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            //4给用户绑定角色
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId=adminRoleId,
                    UserId=adminUserId
                }
                ) ;
            #endregion
            base.OnModelCreating(modelBuilder);
            
            //modelBuilder用于补充信息，可以定义外键、补充数据 
        }
    }
}
