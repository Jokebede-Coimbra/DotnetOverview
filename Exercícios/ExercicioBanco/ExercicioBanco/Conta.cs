using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public static double Taxa = 5.00;

        public Conta()
        {
        }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;

        }

        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
        {

            Deposito(depositoInicial);

        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + Taxa;

        }
        public override string ToString()
        {
            return
            "Conta "
            + Numero
            + ", "
            + "Titular: "
            + Titular
            + ", "
            + "Saldo:  $"
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
