using HarbirBooks.DataAccess.Repository;
using HarbirBooks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HarbirBookStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public static implicit operator ApplicationDbContext(ApplicationException v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ApplicationDbContext(ApplicationDbConext v)
        {
            throw new NotImplementedException();
        }
    }
}
