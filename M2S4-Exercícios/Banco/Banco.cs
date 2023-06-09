namespace M2S4_Exercícios.Banco
{
    public class Banco
    {
        private decimal saldo { get; set; }

        public void Depositar(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Deposito de R${valor}");
        }

        public void Sacar(decimal valor)
        {
            saldo -= valor;
            Console.WriteLine($"Saque de R${valor}");
        }

        public override string ToString()
        {
            return $"Valor atual em conta: {saldo}";
        }
    }

    public class Conta
    {
        private int numero { get; set; }
        private Cliente cliente { get; set; }
        private Banco banco { get; set; }

        public Conta(Cliente cliente, int numero, Banco banco) 
        {
            this.cliente = cliente;
            this.numero = numero;
            this.banco = banco;
        }

        public void ExibirDador()
        {
            Console.WriteLine($"Dados da conta:\n" +
                $"Conta: {numero}\n" +
                $"{cliente.ToString()}\n" +
                $"Saldo: {banco.ToString()}");
        }

        public void Depositar(decimal valor)
        {
            banco.Depositar(valor); 
        }

        public void Sacar(decimal valor)
        {
            banco.Sacar(valor);
        }
    }

    public class Cliente
    {
        private string nome { get; set; }
        private string CPF { get; set;}

        public Cliente(string nome, string CPF)
        {
            this.nome = nome;
            this.CPF = CPF;
        }

        public override string ToString()
        {
            return $"Nome: {nome}, CPF: {CPF}";
        }
    }
}
