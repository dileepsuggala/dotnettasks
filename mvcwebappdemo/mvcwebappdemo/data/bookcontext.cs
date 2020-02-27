using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvcwebappdemo.Models;

namespace mvcwebappdemo.data
{
    public class bookcontext:DbContext
    {
        public bookcontext(DbContextOptions<bookcontext> options):base(options)
        {

        }
        public DbSet<book> Books { get; set; }
    }
}
