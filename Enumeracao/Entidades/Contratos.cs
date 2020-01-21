using System;

namespace Enumeracao.Entidades
{
    class Contratos
    {
        public DateTime Data { get; set; }
        public double ValorHora { get; set; }
        public int Quantidade { get; set; }

        public Contratos()
        {
        }

        public Contratos(DateTime data, double valorHora, int quantidade)
        {
            Data = data;
            ValorHora = valorHora;
            Quantidade = quantidade;
        }

        public double Total()
        {
            return (double) ValorHora * Quantidade;
        }

    }
}
