using Microsoft.EntityFrameworkCore;
using Notebook.API.Models.Domain;
using System;

namespace Notebook.API.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions oprions) : base(oprions)
        {

        }
        public DbSet<Notes> Note { get; set; } 
    }
}
