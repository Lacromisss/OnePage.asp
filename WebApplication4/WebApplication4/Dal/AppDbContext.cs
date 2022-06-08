using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication4.Models;

namespace WebApplication4.Dal
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<User> Users { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Education> educations { get; set; }
        public DbSet<WorkFlow> WorkFlows { get; set; }
        public DbSet<Icons> Icons { get; set; }

        public DbSet<Skill> skills { get; set; }
        public DbSet<Award> awards { get; set; }

        public DbSet<Interest> interests { get; set; }






    }
}
