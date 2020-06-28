using Drinkr.Models.Enums;
using System;

namespace Drinkr.Models
{
    public class Corrida
    {
        public int Id { get; set; }
        public DateTime DataCorrida { get; set; }
        public string Local { get; set; }
        public string Destino { get; set; }
        public Motorista Motorista { get; set; }

        public Corrida()
        {
        }
        public Corrida(int id, DateTime dataCorrida, string local, string destino, Motorista motorista)
        {
            Id = id;
            DataCorrida = dataCorrida;
            Local = local;
            Destino = destino;
            Motorista = motorista;
        }

    }
}
