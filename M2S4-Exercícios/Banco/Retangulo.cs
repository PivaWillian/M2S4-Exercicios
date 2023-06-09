namespace M2S4_Exercícios.Banco
{
    internal class Retangulo
    {
        private int largura;
        private int altura;
        public int Largura
        {
            get { return largura; }
            set { largura = value >= 0 ? value : 0; }
        }

        public int Altura
        {
            get { return altura; }
            set { altura = value >= 0 ? value : 0; }
        }

        public void CalcularArea()
        {
            Console.WriteLine($"{largura * altura}");
        }

    }
}
