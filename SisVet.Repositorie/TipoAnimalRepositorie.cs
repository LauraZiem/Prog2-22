using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repositorie
{
    public class TipoAnimalRepositorie
    {
        public bool Salvar(TipoAnimal tipoAnimal)
        {
            return true;
        }

        public TipoAnimal Retornar(int tipoAnimalId)
        {
            TipoAnimal tipoAnimal= new TipoAnimal(tipoAnimalId);

            // Buscar dados do bd

            if (tipoAnimalId == 1)
            {
                tipoAnimal.Id = 1;
                tipoAnimal.Tipo = "Cachorro";
            }

            return tipoAnimal;
        }

        public List<TipoAnimal> Retornar()
        {
            return new List<TipoAnimal>();
        }
    }
}
