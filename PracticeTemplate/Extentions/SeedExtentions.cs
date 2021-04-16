using Microsoft.EntityFrameworkCore;
using PracticeTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTemplate.Extentions
{
    public static class SeedExtentions
    {
        public static void Seed(this ModelBuilder modelBulder)
        {
            modelBulder.Entity<LoginUser>().HasData(
                new LoginUser
                {
                    Id = 1,
                    Username = "user1",
                    Password = "123"
                },
                  new LoginUser
                  {
                      Id = 2,
                      Username = "user2",
                      Password = "123"
                  },
                    new LoginUser
                    {
                        Id = 3,
                        Username = "user3",
                        Password = "123"
                    },
                      new LoginUser
                      {
                          Id = 4,
                          Username = "user4",
                          Password = "123"
                      }

                );
            modelBulder.Entity<SalaryTable>().HasData(
                new SalaryTable
                {
                    Id = 1,
                    Name = "Tiger Nixon",
                     Position = "System Architect",
                      Office = "Edinburgh",
                      Age = 61,
                      Start = DateTime.Parse("2011-04-25"),
                       Salary =   320800,
                },
                  new SalaryTable  {
                Id = 2,
                    Name = "Tiger Nixon",
                     Position = "System Architect",
                      Office = "Edinburgh",
                      Age = 61,
                      Start = DateTime.Parse("2011-04-25"),
                  },
                  new SalaryTable
            {
                Id = 3,
                    Name = "Tiger Nixon",
                     Position = "System Architect",
                      Office = "Edinburgh",
                      Age = 61,
                      Start = DateTime.Parse("2011-04-25"),
                       Salary = 320800,
                },
                  new SalaryTable
            {
                Id = 4,
                    Name = "Tiger Nixon",
                     Position = "System Architect",
                      Office = "Edinburgh",
                      Age = 61,
                      Start = DateTime.Parse("2011-04-25"),
                       Salary = 320800,
                }
                
                );
        }
    }
}
