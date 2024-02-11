using System.ComponentModel.DataAnnotations;
using WebAPI_Funcionarios.Enums;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_Funcionarios.Models
{
    public class FuncionarioModel
    {
        [Key] // informa que o id é chave primaria
        public int Id { get; set; }
        public string Nome { get; set; }
        public string cpf { get;set; }
        public DepartamentoEnum Departamento { get; set;}
        public bool Ativo {  get; set;}
        public TurnoEnum Turno { get; set;}
        public DateTime DataDeCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteracao { get; set; } = DateTime.Now.ToLocalTime();
    }
}
  