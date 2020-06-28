using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinkr.Models
{
    public class Usuario : PadraoCadastro
    {
        public ICollection<Carro> Carros { get; set; } = new List<Carro>();
        public ICollection<Corrida> Corridas { get; set; } = new List<Corrida>();

        public Usuario() { }
        public Usuario(int id, string nome, string email, int cpf, int telefone, DateTime idade, string password) : base (id, nome, email, cpf, telefone, idade, password)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Telefone = telefone;
            Idade = idade;
            Password = password;
        }
        

    }
}
