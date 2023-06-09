namespace M2S4_Exercícios.Banco
{
    internal class Person
    {
        private string nome;
        private int idade;
        public int Idade
        {
            get { return idade; }
            set
            {
                idade = value >= 0 ? value : 0;
            }
        }

        public void DefinirNome( string nome)
        {
            this.nome = nome;
        }

        public string RetomarNome()
        {
            return this.nome;
        }

        public void DefinirIdade( int idade )
        {
            if( idade >= 0 ) 
                this.idade = idade;
            return;
        }

        public int RetomarIdade()
        {
            return this.idade;
        }
    }
}
