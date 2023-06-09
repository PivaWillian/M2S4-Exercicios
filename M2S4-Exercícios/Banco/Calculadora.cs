namespace M2S4_Exercícios.Banco
{
    static class Calculadora
    {
        public const double Pi = 3.14;

        public static void Soma(double x, double y)
        {
            Console.WriteLine($"{x+y}");
        }
        public static void Diminui(double x, double y)
        {
            Console.WriteLine($"{x - y}");
        }

        public static void Multiplica(double x, double y)
        {
            Console.WriteLine($"{x * y}");
        }
        public static void Dividi(double x, double y)
        {
            if(y!= 0)
                Console.WriteLine($"{x / y}");
        }
    }
}
