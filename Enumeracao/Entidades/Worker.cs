using System.Collections.Generic;
using Enumeracao.Entidades.Enum;

namespace Enumeracao.Entidades
{
    class Worker
    {
        public Departamento Depart { get; set; }
        public string Nome { get; set; }
        public WorkerLevel Level { get; set; }
        public double SalarioBase { get; set; }
        public List<Contratos> Contrato { get; set; } = new List<Contratos>();

        public Worker()
        {
        }

        public Worker(Departamento depart, string nome, WorkerLevel level, double salarioBase)
        {
            Depart = depart;
            Nome = nome;
            Level = level;
            SalarioBase = salarioBase;
        }

        public void AcrescContratos (Contratos contrato)
        {
            Contrato.Add(contrato);
        }

        public void RemoverContratos (Contratos contrato)
        {
            Contrato.Remove(contrato);
        }

        public double TotaldeSalario(int ano, int mes)
        {
            double sum = SalarioBase;
            foreach (Contratos contrato in Contrato)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    sum += contrato.Total();
                }
            }
            return sum;
        }

    }
}
