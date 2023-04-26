using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace EFDataAccess.DataAccess;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestLine> RequestLines { get; set; }

        public DbSet<User> Users { get; set; }
    }