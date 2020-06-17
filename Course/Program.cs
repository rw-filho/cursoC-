using System;
using System.Globalization;
using System.Reflection;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine().ToLower());

            Banco banco;

            if (resposta == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                banco = new Banco(numeroDaConta, nome, saldo);
            }
            else
            {
                banco = new Banco(numeroDaConta, nome);
            }    

            Console.WriteLine();
            Console.WriteLine(banco);

            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Deposito(valor);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(banco);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            banco.Saque(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(banco);
        }
    }
}