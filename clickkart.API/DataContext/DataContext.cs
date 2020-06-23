using clickkart.API.Modal;
using Microsoft.EntityFrameworkCore;

namespace clickkart.API.DataAccess
{
    public class data:DbContext
    {
        public data(DbContextOptions<data> options): base(options)
    {
    }
        public DbSet<Value> values{get;set;}
    }
}