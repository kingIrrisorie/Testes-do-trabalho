using System;
using System.Collections.Generic;

namespace EmCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var faturamentos = new Dictionary<string, double>
            {
                {"SP", 67836.43},
                {"RJ", 36678.66},
                {"MG", 29229.88},
                {"ES", 27165.48},
                {"Outros", 19849.53}
            };
            double total = CalculaTotal(faturamentos);
            var percentuais = CalcularPercentuais(faturamentos, total);

            foreach (var item in percentuais)
            {
                Console.WriteLine(item.Key + ':' + item.Value.ToString("F2"));
            }
        }

        public static double CalculaTotal(Dictionary<string, double> faturamentos)
        {
            double total = 0;

            foreach (var item in faturamentos)
            {
                total += item.Value;
            }
            return total;
        }

        public static Dictionary<string, double> CalcularPercentuais(Dictionary<string, double> faturamentos, double total)
        {
            var percentuais = new Dictionary<string, double>();
            foreach (var item in faturamentos)
                percentuais.Add(item.Key, (item.Value / total) * 100);
            
            return percentuais;
        }
    }
}