using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinkr.Models
{
    public class Cartao
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Nome { get; set; }
        public DateTime Validade { get; set; }
        public Usuario Usuario { get; set; }
        public Cartao()
        {
        }

        public Cartao(int id, int numero, string nome, DateTime validade, Usuario usuario)
        {
            Id = id;
            Numero = numero;
            Nome = nome;
            Validade = validade;
            Usuario = usuario;
        }
    }
}
