// See https://aka.ms/new-console-template for more information
Pessoa pessoa1 = new Pessoa("Loló", 14, "Rua José n° 260");
pessoa1.Saudacao();


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