using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinkr.Models
{
    public class Motorista : PadraoCadastro
    {
        public Motorista()
        {
        }

        public Motorista(int id, string nome, string email, int cpf, int telefone, DateTime idade, string password) : base(id, nome, email, cpf, telefone, idade, password)
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
