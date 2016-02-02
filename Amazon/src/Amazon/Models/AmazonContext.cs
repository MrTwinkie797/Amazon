using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public class AmazonContext : DbContext
    {
        public DbSet<Comment> Customers { get; set; }
    }
}
