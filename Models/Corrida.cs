using System;

namespace Drinkr.Models
{
    public class Corrida
    {
        public int Id { get; set; }
        public DateTime DataCorrida { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public Motorista Motorista { get; set; }

        public Corrida()
        {
        }
        public Corrida(int id, DateTime dataCorrida, string origem, string destino, Motorista motorista)
        {
            Id = id;
            DataCorrida = dataCorrida;
            Origem = origem;
            Destino = destino;
            Motorista = motorista;
        }

    }
}
