using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinkr.Models;

namespace Drinkr.Data
{
    public class SeedingService
    {
        private readonly DrinkrContext _context;

        public SeedingService(DrinkrContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Usuario.Any()||
                _context.Motorista.Any() ||
                _context.Endereco.Any() ||
                _context.Carro.Any () ||
                _context.Cartao.Any() ||
                _context.Corrida.Any())
            {
                return; //db populado
            }

            Usuario u1 = new Usuario(1, "Chico", "chico@chico.com", 088769, 0909090, new DateTime(1995, 4, 21), "123");
            Usuario u2 = new Usuario(2, "Maria", "maria@maria.com", 098765, 969696, new DateTime(1994, 3, 6), "123");

            Motorista m1 = new Motorista(1, "Caetano", "caetano@caetano.com", 28793829, 8920173, new DateTime(1990, 9, 14), "123");
            
            Carro c1 = new Carro(1, "HB20", "Hyundai", "HJ57", "azul", u1);
            Carro c2 = new Carro(2, "hb20", "hyundai", "doze", "verde", u2);

            Endereco en1 = new Endereco(1, 455556, "Rua Rua", 12, "Algo", "Curitiba", u1);
            Endereco en2 = new Endereco(2, 455556, "Rua Rua Rua", 12, "AlgoAlgo", "Belo Horizonte", u2);

            Cartao cr1 = new Cartao(1, 4555343, "chico", new DateTime(2023, 11, 4), u1);
            Cartao cr2 = new Cartao(2, 1236731, "maria", new DateTime(2023, 6, 6), u2);

            Corrida cor1 = new Corrida(1, new DateTime(2020, 6, 22), "Bar do zé", "Casa do usuario", Models.Enums.StatusCorrida.Andamento);
            
            _context.Usuario.AddRange(u1, u2);
            _context.Motorista.AddRange(m1);
            _context.Carro.AddRange(c1, c2);
            _context.Endereco.AddRange(en1, en2);
            _context.Cartao.AddRange(cr1, cr2);
            _context.Corrida.AddRange(cor1);

            _context.SaveChanges();
        }
    }
}
