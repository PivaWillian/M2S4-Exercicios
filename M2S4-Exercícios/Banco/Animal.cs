namespace M2S4_Exercícios.Banco
{
    abstract class Animal
    {
        private string nome;
        private int idade;

        public abstract void EmitirSom();
        
    }

    class Dog:Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Au-au");
        }
    }

    class Cat: Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau");
        }

    }
}
