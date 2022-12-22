using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class RegisterContext:DbContext
    {
        public RegisterContext(DbContextOptions<RegisterContext> options): base(options)
        {
        }
        public DbSet<Register> Registers { get; set; }
    }
}
