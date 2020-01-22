using System;
using Enumeracao.Entidades.Enum;
using Enumeracao.Entidades;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de empregados");
            Console.Write("Departamento: ");
            string depart = Console.ReadLine();
            Departamento departamento = new Departamento(depart);
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nível: ");
            WorkerLevel nivel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário Base: ");
            double SalarioBase = double.Parse(Console.ReadLine());
            Worker trabalhador = new Worker(departamento, nome, nivel, SalarioBase);

            Console.WriteLine();
            Console.Write("Quantidade de contratos do empregado: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                Console.Write("Data do contrato: ");
                DateTime dataDoContrato = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Quantidade de horas: ");
                int quantidade = int.Parse(Console.ReadLine());
                Contratos contrato = new Contratos(dataDoContrato, valorPorHora, quantidade);
                trabalhador.AcrescContratos(contrato);
                
            }

            Console.WriteLine();
            Console.WriteLine("Entre com o mês e o ano: ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine("Dados do empregado:" + Environment.NewLine
                + "Nome: " + nome
                + Environment.NewLine
                + "Departamento: " + departamento.Name
                + Environment.NewLine
                + "Nível: " + nivel
                + Environment.NewLine
                + "Saláro Base: " + SalarioBase
                + Environment.NewLine
                + "Total de salário: " + trabalhador.TotaldeSalario(ano, mes).ToString("C"));

        }
    }
}
