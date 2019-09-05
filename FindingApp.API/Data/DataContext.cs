using FindingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FindingApp.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){ }
        public DbSet<Value> Values { get; set; }
    }
}