using System;
using System.Collections.Generic;
using System.Text;
using Enumeracao.Entidades.Enum;
using System.Collections.Generic;

namespace Enumeracao.Entidades
{
    class Worker
    {
        public Departamento Depart { get; set; }
        public string Nome { get; set; }
        public WorkerLevel Level { get; set; }
        public double SalarioBase { get; set; }
        public List<Contratos> Contrato { get; set; }

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
            foreach (Contratos contrat in Contrato)
            {
                if (contrat.Data.Year == ano && contrat.Data.Month == mes)
                {
                    sum += contrat.Total();
                }
            }
            return sum;
        }

    }
}
