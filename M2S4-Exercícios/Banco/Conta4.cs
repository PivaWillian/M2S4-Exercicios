namespace M2S4_Exercícios.Banco
{
    internal class Conta4
    {
        private decimal saldo;
        public decimal Saldo { 
            get { return saldo; } 
            set 
            { 
                saldo = value >= 0 ? value: 0;
            } 
        }

        public void Depositar(decimal amount) 
        {
            Saldo += amount; 
        }

        public bool Sacar(decimal amount)
        {
            if(saldo >= amount && amount > 0)
            {
                Saldo -= amount;
                return true;
            }
            return false;
        }
    }
}
