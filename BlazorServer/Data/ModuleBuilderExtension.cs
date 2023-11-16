using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Data
{
    public static class ModuleBuilderExtension
    {
        public static void Seed(this ModelBuilder builder) {
            var pwd = "P@$$w0rd";
            var passwordHasher = new PasswordHasher<IdentityUser>();

            // Seed Roles
            var adminRole = new IdentityRole("Admin");
            adminRole.NormalizedName = adminRole.Name.ToUpper();

            var memberRole = new IdentityRole("Member");
            memberRole.NormalizedName = memberRole.Name.ToUpper();

            // EJ
            var financeRole = new IdentityRole("Finance");
            financeRole.NormalizedName = financeRole.Name.ToUpper();

            List<IdentityRole> roles = new List<IdentityRole>() {
                adminRole,
                memberRole,
                financeRole 
            };

            builder.Entity<IdentityRole>().HasData(roles);

            

            
            // Seed Users
            var adminUser = new IdentityUser {
                UserName = "a@a.a",
                Email = "a@a.a",
                EmailConfirmed = true,
            };
            adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
            adminUser.NormalizedEmail = adminUser.Email.ToUpper();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, pwd);

            var memberUser = new IdentityUser {
                UserName = "m@m.m",
                Email = "m@m.m",
                EmailConfirmed = true,
            };
            memberUser.NormalizedUserName = memberUser.UserName.ToUpper();
            memberUser.NormalizedEmail = memberUser.Email.ToUpper();
            memberUser.PasswordHash = passwordHasher.HashPassword(memberUser, pwd);

        
            var financeUser = new IdentityUser {
                UserName = "f@f.f",
                Email = "f@f.f",
                EmailConfirmed = true,
            };
            financeUser.NormalizedUserName = financeUser.UserName.ToUpper();
            financeUser.NormalizedEmail = financeUser.Email.ToUpper();
            financeUser.PasswordHash = passwordHasher.HashPassword(financeUser, pwd);

            List<IdentityUser> users = new List<IdentityUser>() {
                adminUser,
                memberUser,
                financeUser
            };

            builder.Entity<IdentityUser>().HasData(users);

             // Seed UserRoles
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            userRoles.Add(new IdentityUserRole<string> {
                UserId = users[0].Id,
                RoleId = roles.First(q => q.Name == "Admin").Id
            });

            userRoles.Add(new IdentityUserRole<string> {
                UserId = users[1].Id,
                RoleId = roles.First(q => q.Name == "Member").Id
            });

            // EJ
            userRoles.Add(new IdentityUserRole<string> {
                UserId = users[2].Id,
                RoleId = roles.First(q => q.Name == "Finance").Id
            });

            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}