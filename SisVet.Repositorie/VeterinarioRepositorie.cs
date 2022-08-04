using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repositorie
{
    public class VeterinarioRepositorie
    {
        public bool Salvar(Veterinario veterinario)
        {
            return true;
        }

        public Veterinario Retornar(int veterinarioId)
        {
            Veterinario veterinario = new Veterinario(veterinarioId);

            // Buscar dad0os do bd

            if(veterinarioId == 1)
            {
                veterinario.Nome = "Laura";
                veterinario.Sobrenome = "Ziem";
                veterinario.Srv = "123456";
                veterinario.Email = "laura.ziem12@gmail.com";
                veterinario.Telefone = "49 9 9999 9999";
            }

            return veterinario;
        }

        public List<Veterinario> Retornar()
        {
            return new List<Veterinario>();
        }
    }
}
