using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repositorie
{
    public class EnderecoRepositorie
    {
        public bool Salvar(Endereco endereco)
        {
            return true;
        }

        public Endereco Retornar(int enderecoId)
        {
            Endereco endereco= new Endereco(enderecoId);

            // Buscar dados do bd

            if (enderecoId == 1)
            {
                endereco.Id = 1;
                endereco.Rua = "Luis Moreira Leite";
                endereco.Nro = "S/N";
                endereco.Complemento = "Casa";
                endereco.Bairro = "Centro";
                endereco.Cidade = "Lebon Régis";
                endereco.Pais = "Brasil";
                endereco.Cep = "89515-000";
            }

            return endereco;
        }

        public List<Endereco> Retornar()
        {
            return new List<Endereco>();
        }
    }
}
