namespace SisVet.Model
{
    public class ClienteAnimal
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int AnimalId { get; set; }

        public ClienteAnimal(int id)
        {
            Id = id;
        }

        public ClienteAnimal()
        {
        }
    }
}
