using System.Collections.Generic;

namespace SisVet.Model
{
    public class TipoAnimal
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public ICollection<Raca> Racas { get; set; } = new List<Raca>();

        public TipoAnimal(int tipoAnimalId)
        {
            Id = tipoAnimalId;
        }
        public TipoAnimal()
        {
        }
    }

}
