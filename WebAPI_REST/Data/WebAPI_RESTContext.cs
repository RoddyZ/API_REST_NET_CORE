using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI_REST.Models;

namespace WebAPI_REST.Data
{
    public class WebAPI_RESTContext : DbContext
    {
        public WebAPI_RESTContext (DbContextOptions<WebAPI_RESTContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI_REST.Models.Book> Book { get; set; }
    }
}
