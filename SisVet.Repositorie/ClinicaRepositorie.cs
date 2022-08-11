using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repositorie
{
    public class ClinicaRepositorie
    {
        public bool Salvar(Cliente clinica)
        {
            return true;
        }

        public Clinica Retornar(int clinicaId)
        {
            Clinica clinica= new Clinica(clinicaId);

            // Buscar dados do bd

            if (clinicaId == 1)
            {
                clinica.Id = 1;
                clinica.Nome = "Pet lovers";
                clinica.Telefone = "49 9 9999 9999";
                clinica.Email = "petlovers@gmail.com";
                clinica.EnderecoId = 1;
                clinica.Endereco = new Endereco { };
            }

            return clinica;
        }

        public List<Clinica> Retornar()
        {
            return new List<Clinica>();
        }
    }
}
