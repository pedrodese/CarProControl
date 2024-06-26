using System;
using System.Collections.Generic;
using System.Linq;

namespace CarProControl.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public string DescricaoServico { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public double ValorOrcamento { get; set; }
        public Veiculo Veiculo { get; set; }
        public Funcionario FuncionarioResponsavel { get; set; }


        public  OrdemServico() { }

        public OrdemServico(int id, string descricaoServico, DateTime dataEntrada, DateTime dataSaida, double valorOrcamento, Veiculo veiculo, Funcionario funcionarioResponsavel)
        {
            Id = id;
            DescricaoServico = descricaoServico;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
            ValorOrcamento = valorOrcamento;
            Veiculo = veiculo;
            FuncionarioResponsavel = funcionarioResponsavel;
        }
    }
}
