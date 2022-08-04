using System;
using System.Collections.Generic;

namespace SisVet.Model
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public DateTime DataNascimento { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Complimento{ get; set; }
        public string Cor { get; set; }
        public int RacaId{ get; set; }
        public Raca Raca{ get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public ICollection<Atendimento> Atendimentos { get; set; } = new List<Atendimento>();
    }
}
