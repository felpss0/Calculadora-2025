namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
               
                while (true)
                {
                    string opcao = ExibirMenu();

                if (OpcaoSairFoiEscolhida(opcao) == true)
                    break;

                else if (OpcaoTabuadaFoiEscolhida(opcao))
                    ExibirTabuada();

                else if (OpcaoHistoricoFoiEscolhida(opcao))
                    ExibirHistoricoOperacoes();
                else
                    ExibirResultado(RealizarCalculo(opcao));


            }
                
        
        }

        static string ExibirMenu() 
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("6 - Histórico de Operações");
            Console.WriteLine("S - Sair");

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine().ToUpper();
            return opcao;
        }


        static bool OpcaoSairFoiEscolhida(string opcao) 
        {
            bool opcaoSairFoiEscolhida = opcao == "S";

            return opcaoSairFoiEscolhida;
        }

        static bool OpcaoTabuadaFoiEscolhida(string opcao) 
        {
            bool opcaoTabuadaFoiEscolhida = opcao == "5";

            return opcaoTabuadaFoiEscolhida;
        }

        static bool OpcaoHistoricoFoiEscolhida(string opcao) 
        {
            bool opcaoHistoricoFoiEscolhida = opcao == "6";

            return opcaoHistoricoFoiEscolhida;
        }

        static void ExibirTabuada() 
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Tabuada");
            Console.WriteLine("-----------------------------");

            //usuario digita um numero
            Console.Write("Digite o numero: ");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());

            string[] linhasTabuada = Calculadora.GerarTabuada(numeroTabuada);

            Console.ReadLine();
        }

        static void ExibirHistoricoOperacoes() 
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Histórico de Operações");
            Console.WriteLine("-----------------------------");

            string[] historicoOperacoes = Calculadora.ObterHistoricoOperacoes();

            for (int contador = 0; contador < historicoOperacoes.Length; contador++)
            {
                string valorAtual = historicoOperacoes[contador];
                if (valorAtual != null)
                    Console.WriteLine(valorAtual);
            }
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
        }

        static decimal RealizarCalculo(string operacao) 
        {
            Console.Write("Digite o Primeiro numero: ");
            string num1String = Console.ReadLine();
            decimal num1 = Convert.ToDecimal(num1String);

            Console.Write("Digite o Segundo numero: ");
            string num2String = Console.ReadLine();
            decimal num2 = Convert.ToDecimal(num2String);

            decimal resultado = 0;

            if (operacao == "1")
                resultado = Calculadora.Somar(num1, num2);
            else if (operacao == "2")
                resultado = Calculadora.Subtrair(num1, num2);
            else if (operacao == "3")
                resultado = Calculadora.Multiplicar(num1, num2);
            else if (operacao == "4")
                //opcao1
                //if (num2 != 0)
                //    resultado = num1 / num2;

                //else
                //    Console.WriteLine("Não é possivel dividir por zero");
                //    Console.ReadLine();
                //    continue;

                //opcao2
                //if (num2 == 0) 
                //{
                //        Console.WriteLine("Não é possivel dividir por zero");
                //        Console.ReadLine();
                //        continue;
                //}
                //resultado = num1 / num2;

                while (num2 == 0)
                {
                    Console.Write("Não é possível dividir por 0\n Digite o segundo número novamente -> ");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                }
                resultado = Calculadora.Dividir(num1, num2);
                
            

            
            return resultado;
        }

        static void ExibirResultado(decimal resultado) 
        {
            Console.WriteLine("-----------------------------");
            Console.Write("O resultado é: " + resultado.ToString("F2"));
            Console.WriteLine("-----------------------------");

            Console.ReadLine();
        }
    }
}
