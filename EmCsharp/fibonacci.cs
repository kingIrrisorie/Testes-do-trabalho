using System;

namespace EmCsharp
{
    class Program
    {      
        static void Main(string[] args)
        {
            int number = 0;

            if (args.Length > 0)
            {
                if (int.TryParse(args[0], out number))
                {
                    if (Fibonacci(number))
                    {
                        Console.WriteLine("O número " + number + " pertence a sequência de fibonacci");
                    } else
                    {
                        Console.WriteLine("O número " + number + " nao pertence a sequência de fibonacci");
                    }
                }
            }
            else
            {
                Console.Write("Insira um numero: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (Fibonacci(number))
                {
                    Console.WriteLine("O número " + number + " pertence a sequência de fibonacci");
                } else 
                {
                    Console.WriteLine("O número " + number + " nao pertence a sequência de fibonacci");
                }
            }
        }
        public static bool Fibonacci(int number)
        {
            int numeroAnterior = 0, proximoNumero = 1;
            int tempNumeroAnterior = 0;

            if (number < 0)
                return false;
            else if (number == 0 || number == 1)
                return true;
            else
            {
                while (proximoNumero < number)
                {
                    tempNumeroAnterior = numeroAnterior;
                    numeroAnterior = proximoNumero;

                    proximoNumero = tempNumeroAnterior + numeroAnterior;
                }

                if (proximoNumero == number)
                    return true;
                else
                    return false;
            }
        } 
    }
}