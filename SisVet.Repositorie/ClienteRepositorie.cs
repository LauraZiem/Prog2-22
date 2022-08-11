using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repositorie
{
    public class ClienteRepositorie
    {
        public bool Salvar(Cliente cliente)
        {
            return true;
        }

        public Cliente Retornar(int clienteId)
        {
            Cliente cliente = new Cliente(clienteId);

            // Buscar dados do bd

            if (clienteId == 1)
            {
                cliente.Id = 1;
                cliente.Nome = "Laura";
                cliente.Cpf = "01287091970";
                cliente.Email = "Laura.ziem12@gmail.com";
                cliente.Telefone = "49 9 9993 5692";
                cliente.EnderecoId = 1;
            }

            return cliente;
        }

        public List<Cliente> Retornar()
        {
            return new List<Cliente>();
        }
    }
}
