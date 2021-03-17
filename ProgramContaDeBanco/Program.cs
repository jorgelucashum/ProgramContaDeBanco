using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramContaDeBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBanco conta;

            Console.Write("Digite o número da conta do banco: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial? (s/n): ");
            char x = char.Parse(Console.ReadLine());
            if (x == 's' || x == 'S')
            {
                Console.Write("Digite o valor do depósito: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBanco(titular, numero, depositoInicial);
                
            } else
            {
                conta = new ContaBanco(titular, numero);
            }

            Console.WriteLine(conta);

            Console.Write("Digite um valor para depositar: ");
            conta.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta);

            Console.WriteLine("Digite um valor para sacar: ");
            conta.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta);

            Console.ReadLine();
        }
    }
}
