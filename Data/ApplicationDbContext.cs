using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentSystemWeb.Models;

namespace StudentSystemWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Title> Titles { get; set; }
        public DbSet<IssizlikOrani> IssizlikOraniTablo1 { get; set; }


    }
}
