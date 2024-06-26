using System.ComponentModel.DataAnnotations;

namespace CarProControl.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Display(Name = "Idade do Funcionario")]
        public int Idade { get; set; }

        [Display(Name = "Nome do Funcionario")]
        public string Nome { get; set; }

        [Display(Name = "Salario do Funcionario")]
        [DisplayFormat(DataFormatString = "R${0:F2}")]
        public double Salario { get; set; }
    }
}
