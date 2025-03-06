namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("S - Sair");

            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine().ToUpper();

            if (opcao == "S") {
                return;
            } 

                Console.Write("Digite o Primeiro numero: ");
            string num1String = Console.ReadLine();
            int num1 = Convert.ToInt32(num1String);

            Console.Write("Digite o Segundo numero: ");
            string num2String = Console.ReadLine();
            int num2 = Convert.ToInt32(num2String);

            int resultado = 0;

            if (opcao == "1") {
                 resultado = num1 + num2;
            } else 
            {
                resultado = num1 - num2;
            }



            Console.WriteLine(resultado);

            Console.ReadLine();



        }
    }
}
