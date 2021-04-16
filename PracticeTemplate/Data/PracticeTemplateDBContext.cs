using Microsoft.EntityFrameworkCore;
using PracticeTemplate.Extentions;
using PracticeTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTemplate.Data
{
    public class PracticeTemplateDBContext : DbContext
    {
        public PracticeTemplateDBContext (DbContextOptions<PracticeTemplateDBContext> options) : 
            base(options)
        {

        } 
        protected override void OnModelCreating(ModelBuilder modelbulder)
        {
            modelbulder.Seed();
        }
        public DbSet<LoginUser> loginUsers { get; set; }
        public DbSet<SalaryTable> salaryTables { get; set; }
    }
}
