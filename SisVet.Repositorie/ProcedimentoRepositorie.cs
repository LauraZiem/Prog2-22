using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repositorie
{
    public class ProcedimentoRepositorie
    {
        public bool Salvar(Procedimento procedimento)
        {
            return true;
        }

        public Procedimento Retornar(int procedimentoId)
        {
            Procedimento procedimento = new Procedimento(procedimentoId);

            // Buscar dados do bd

            if (procedimentoId == 1)
            {
                procedimento.Id = 1;
                procedimento.TipoProcedimento = "Cirurgia";
                procedimento.Descricao = "Tudo certo";
            }

            return procedimento;
        }

        public List<Procedimento> Retornar()
        {
            return new List<Procedimento>();
        }
    }
}
