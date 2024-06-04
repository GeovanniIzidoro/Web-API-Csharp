using Microsoft.EntityFrameworkCore;
using WebAPI_C_.Models;

namespace WebAPI_C_.DataContext
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {   
        }

        
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
