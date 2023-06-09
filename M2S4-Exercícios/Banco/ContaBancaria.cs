namespace M2S4_Exercícios.Banco
{
    internal class ContaBancaria
    {
        private int numeroConta;
        private decimal saldo;

        public ContaBancaria(int numeroConta)
        {
            this.numeroConta = numeroConta;
        }
        public void Deposita(decimal valor)
        {
            saldo += valor;
        }

        public void Saca(decimal valor)
        {
            if(valor > saldo)
            {
                Console.WriteLine("Valor solicitado é maior que o saldo disponível");
                return;
            }
                
            saldo -= valor;
        }

        public decimal GetSaldo()
        {
            return saldo;
        }
    }
}
