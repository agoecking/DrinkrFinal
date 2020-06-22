using System;

namespace Drinkr.Models
{
    public abstract class PadraoCadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Cpf { get; set; }
        public int Telefone { get; set; }
        public DateTime Idade { get; set; }

        protected PadraoCadastro()
        {
        }

        protected PadraoCadastro(int id, string nome, string email, int cpf, int telefone, DateTime idade)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Telefone = telefone;
            Idade = idade;
        }
    }
}
