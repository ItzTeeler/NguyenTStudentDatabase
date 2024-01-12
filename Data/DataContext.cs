using Microsoft.EntityFrameworkCore;
using NguyenTStudentDatabase.Models;

namespace NguyenTStudentDatabase.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<StudentDatabase> Students {get; set; }
    }
