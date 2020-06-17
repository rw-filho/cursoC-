using System;
using System.Globalization;

namespace Course
{
    class Banco
    {
        public int NumeroDaConta { get; }
        public double Saldo { get; private set; }
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public Banco(int numerodaconta, string nome)
        {
            NumeroDaConta = numerodaconta;
            Nome = nome;
        }
        public Banco(int numerodaconta, string nome, double depositoInicial) : this(numerodaconta, nome)
        {
            Deposito(depositoInicial);
        }
        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            Saldo = Saldo - valor - 5;
        }
        public override string ToString()
        {
            return "Conta " +
                NumeroDaConta +
                ", Titular: " +
                Nome +
                ", Saldo: $ " +
                Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
