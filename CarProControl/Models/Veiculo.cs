using System.ComponentModel.DataAnnotations;

namespace CarProControl.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        [Display(Name = "Ano do Veiculo")]
        public int Ano { get; set; }

        [Display(Name = "Modelo do Veiculo")]
        public string Modelo { get; set; }

        [Display(Name = "Placa do Veiculo")]
        public string Placa { get; set; }

        [Display(Name = "Propietario do Veiculo")]  
        public string Propietario { get; set; }
    }
}
