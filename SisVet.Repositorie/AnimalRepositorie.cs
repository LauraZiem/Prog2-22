using System.Collections.Generic;
using System;
using SisVet.Model;

namespace SisVet.Repositorie
{
    public class AnimalRepositorie
    {
        public bool Salvar(Animal animal)
        {
            return true;
        }

        public Animal Retornar(int animalId)
        {
            Animal animal= new Animal(animalId);

            // Buscar dados do bd

            if (animalId == 1)
            {
                animal.Id = 1;
                animal.Nome = "Mel";
                animal.DataNascimento = DateTime.Now;
                animal.Peso = 3.5;
                animal.Altura = 0.5;
                animal.Complimento = 0.5;
                animal.Cor = "Branca";
                animal.RacaId = 1;
                animal.Raca = new Raca { };
                animal.EnderecoId = 1;
                animal.Endereco = new Endereco { };
            }

            return animal;
        }

        public List<Animal> Retornar()
        {
            return new List<Animal>();
        }
    }
}
