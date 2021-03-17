using System.Globalization;

namespace ProgramContaDeBanco
{
    class ContaBanco
    {
        private string _titular;
        public int NumConta { get; private set; }
        public double SaldoTotal  { get; private set; }

        public ContaBanco(string titular, int numConta)
        {
            _titular = titular;
            NumConta = numConta;
            
        }
        public ContaBanco(string titular, int numConta, double depositoInicial) : this(titular, numConta)
        {
            Depositar(depositoInicial);
           
        }

        public string GetTitular()
        {
            return _titular;
        }

        public void SetTitular(string titular)
        {
            if (titular != null && titular.Length > 1) { 
            _titular = titular;                        }
        }

        public void Depositar(double val)
        {
            SaldoTotal +=  val;
        }

        public void Sacar(double val)
        {
            SaldoTotal -= val + 5;
        }

        public override string ToString()
        {
            return "\nDados da conta:\nConta: " + NumConta + ", Titular: " + _titular + ", Saldo: R$" + SaldoTotal.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }

    }
}
