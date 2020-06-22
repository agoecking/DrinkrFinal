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
        public StatusCorrida Status { get; set; }

        public Corrida()
        {
        }
        public Corrida(int id, DateTime dataCorrida, string local, string destino, StatusCorrida status)
        {
            Id = id;
            DataCorrida = dataCorrida;
            Local = local;
            Destino = destino;
            Status = status;
        }

    }
}
