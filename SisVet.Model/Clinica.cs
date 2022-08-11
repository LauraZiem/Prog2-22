using System.Collections.Generic;

namespace SisVet.Model
{
    public class Clinica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int EnderecoId { get; set; }
        // Navigation Property:
        public Endereco Endereco { get; set; }

        public ICollection<Atendimento> Atendimentos { get; set; } = new List<Atendimento>();

        public Clinica(int id)
        {
            Id = id;
        }

        public Clinica()
        {
        }
    }
}
