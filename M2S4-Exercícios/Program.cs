using M2S4_Exercícios.Banco;
//Pessoa pessoa1 = new Pessoa("Loló", 14, "Rua José n° 260");
//pessoa1.Saudacao();

//ContaBancaria conta1 = new ContaBancaria(1234);
//conta1.Deposita(1000);
//Console.WriteLine(conta1.GetSaldo());
//conta1.Saca(500);
//Console.WriteLine(conta1.GetSaldo());
//conta1.Saca(1000);

Conta10 conta = new Conta10();
conta.Depositar(1000);
conta.Sacar(500);
Console.WriteLine(conta.GetSaldo());
Console.WriteLine(conta.RetornaRegistro());


class Pessoa
{
    private string Nome { get; set; }
    protected int Idade { get; set; }
    public string Endereco { get; set; }

    public Pessoa(string nome, int idade, string endereco)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Endereco = endereco;
    }
    public void Saudacao()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos");
    }
}