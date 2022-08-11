using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repositorie
{
    public class RacaRepositorie
    {
        public bool Salvar(Raca raca)
        {
            return true;
        }

        public Raca Retornar(int racaId)
        {
            Raca raca = new Raca(racaId);

            // Buscar dados do bd

            if (racaId == 1)
            {
                raca.Id = 1;
                raca.Nome = "Chow chow";
                raca.TipoAnimalId = 1;
                raca.TipoAnimal = new TipoAnimal
                {
                    Id = 1, Tipo = "Cachorro"
                };
            }

            return raca;
        }

        public List<Raca> Retornar()
        {
            return new List<Raca>();
        }
    }
}
