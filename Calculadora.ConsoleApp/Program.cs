namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Tabajara 2025");

            Console.Write("Digite o Primeiro numero");
            string num1String = Console.ReadLine();
            int num1 = Convert.ToInt32(num1String);

            Console.Write("Digite o Segundo numero");
            string num2String = Console.ReadLine();
            int num2 = Convert.ToInt32(num2String);

            int resultado = num1 + num2;

            Console.WriteLine(resultado);

            Console.ReadLine();



        }
    }
}
