using System.Collections.Generic;
using System;
using SisVet.Model;

namespace SisVet.Repositorie
{
    public class AtendimentoRepositorie
    {
        public bool Salvar(Atendimento atendimento)
        {
            return true;
        }

        public Atendimento Retornar(int atendimentoId)
        {
            Atendimento atendimento= new Atendimento(atendimentoId);

            // Buscar dados do bd

            if (atendimentoId == 1)
            {
                atendimento.Id = 1;
                atendimento.DataHora = DateTime.Now;
                atendimento.ClinicaId = 1;
                atendimento.Clinica = new Clinica { };
                atendimento.VeterinarioId = 1;
                atendimento.Veterinario = new Veterinario { };
                atendimento.AnimalId = 1;
                atendimento.Animal = new Animal { };
                atendimento.ProcedimentoId = 1;
            }

            return atendimento;
        }

        public List<Atendimento> Retornar()
        {
            return new List<Atendimento>();
        }
    }
}
