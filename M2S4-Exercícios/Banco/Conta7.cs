namespace M2S4_Exercícios.Banco
{
    internal class Conta7
    {
        public int NumeroConta;
        public const decimal saldoMaximo = 10000.00m;
        public decimal Saldo;

        public void Depositar(decimal valor)
        {
            if(valor > 0 && (Saldo + valor)<= saldoMaximo)
            {
                Saldo += valor;
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
        }
    }
}
