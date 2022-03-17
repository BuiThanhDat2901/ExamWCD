using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ExamWCD.Models;

namespace ExamWCD.Data
{
    public class Context : DbContext
    {
        public Context() : base("name=ExamWCD")
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}