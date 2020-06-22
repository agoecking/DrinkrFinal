using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinkr.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public Usuario Usuario { get; set; }

        public Carro()
        {
        }

        public Carro(int id, string modelo, string marca, string placa, string cor, Usuario usuario)
        {
            Id = id;
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
            Cor = cor;
            Usuario = usuario;
        }
    }
}
