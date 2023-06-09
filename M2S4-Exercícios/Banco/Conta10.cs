namespace M2S4_Exercícios.Banco
{
    internal class Conta10
    {
        private decimal saldo;
        public string registro = string.Empty;

        public void Depositar(decimal valor)
        {
            saldo += valor;
            registro += $"Foram depositados {valor} reais\n";
        }

        public void Sacar(decimal valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                registro += $"Foram sacados {valor} reais\n";
            }
        }

        public decimal GetSaldo()
        {
            return saldo;
        }

        public string RetornaRegistro()
        {
            return registro;
        }
    }
}
