using System.Text.Json;
using System.Text.Json.Serialization;

namespace Faturamento
{
    public class Fatura
    {
        [JsonPropertyName("valor")]
        public double Valor { get; set; }
    }
    class Program
    {
        static void Main()
        {
            string dadosInJson = File.ReadAllText("../../dados/dados.json");
            List<Fatura> faturas = JsonSerializer.Deserialize<List<Fatura>>(dadosInJson);

            var resultado = Processamento(faturas);

            Console.WriteLine($"menor faturamento foi: {resultado.MenorFaturamento}");
            Console.WriteLine($"maior faturamento foi: {resultado.MaiorFaturamento}");
            Console.WriteLine($"numero de dias maior que a media: {resultado.NumeroDeDiasMaiorQueMedia}");
        }

        static (double MenorFaturamento, double MaiorFaturamento, int NumeroDeDiasMaiorQueMedia) Processamento(List<Fatura> faturas)
        {
            List<double> faturasValidas = new List<double>();

            foreach (Fatura fatura in faturas)
            {
                if (fatura.Valor > 0)
                {
                    faturasValidas.Add(fatura.Valor);
                }
            }

            int numeroDeDiasMaiorQueMedia = CalculaNumeroDeDiasMaiorQueMedia(faturasValidas);
            double menorFaturamento = CalculoMenorValor(faturasValidas);
            double maiorFaturamento = CalculoMaiorValor(faturasValidas);

            return (menorFaturamento, maiorFaturamento, numeroDeDiasMaiorQueMedia);
        }

        static int CalculaNumeroDeDiasMaiorQueMedia(List<double> numberArray)
        {
            double media = 0;
            foreach (var item in numberArray)
            {
                media += item;
            }
            media /= numberArray.Count;

            int numeroDeDiasMaiorQueMedia = 0;

            foreach (var item in numberArray)
            {
                if (item > media)
                {
                    numeroDeDiasMaiorQueMedia++;
                }
            }

            return numeroDeDiasMaiorQueMedia;
        }

        static double CalculoMaiorValor(List<double> numberArray)
        {
            double maiorValor = numberArray[0];
            for (int i = 1; i < numberArray.Count; i++)
            {
                if (numberArray[i] > maiorValor)
                {
                    maiorValor = numberArray[i];
                }
            }
            return maiorValor;
        }

        static double CalculoMenorValor(List<double> numberArray)
        {
            double menorValor = numberArray[0];
            for (int i = 1; i < numberArray.Count; i++)
            {
                if (numberArray[i] < menorValor)
                {
                    menorValor = numberArray[i];
                }
            }
            return menorValor;
        }
    }
}