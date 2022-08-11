namespace SisVet.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int EnderecoId { get; set; }

        public Cliente(int id)
        {
            Id = id;
        }

        public Cliente()
        {
        }
    }
}
