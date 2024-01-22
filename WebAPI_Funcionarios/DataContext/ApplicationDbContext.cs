using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebAPI_Funcionarios.Models;

namespace WebAPI_Funcionarios.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // cria uma tabela Funcionarios onde chama a Model Funcionarios, assim chamando toda informação de dentro da FuncionarioModel.
        public DbSet<FuncionarioModel> Funcionarios {get; set;}
    }
}
 