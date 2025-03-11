namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string[] historicoOperacoes = new string[100];
                int contadorHistorico = 0;

                 
                


                while (true)
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

                if (opcao == "S")
                    break;
                else if (opcao == "5")
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("-----------------------------");

                    //usuario digita um numero
                    Console.Write("Digite o numero: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    //calcula tabuada até o 10 desse numero
                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int resultadoTabuada = numeroTabuada * contador;

                        //string LinhaTabuada = numeroTabuada + " X " + contador + " = " + resultadoTabuada;
                        Console.WriteLine($"{numeroTabuada} x {contador} = {resultadoTabuada}");
                    }
                    Console.ReadLine();

                    continue;

                }
                else if (opcao == "6") 
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Histórico de Operações");
                    Console.WriteLine("-----------------------------");

                    for (int contador = 0; contador < historicoOperacoes.Length; contador++) 
                    {
                        string valorAtual = historicoOperacoes[contador];
                        if(valorAtual != null)
                        Console.WriteLine(valorAtual);
                    }
                    Console.WriteLine("Aperte ENTER para continuar");
                    Console.ReadLine();
                    continue;
                }


                    Console.Write("Digite o Primeiro numero: ");
                string num1String = Console.ReadLine();
                decimal num1 = Convert.ToDecimal(num1String);

                Console.Write("Digite o Segundo numero: ");
                string num2String = Console.ReadLine();
                decimal num2 = Convert.ToDecimal(num2String);

                decimal resultado = 0;

                if (opcao == "1")
                {
                    resultado = num1 + num2;
                    historicoOperacoes[contadorHistorico] = $"{num1} + {num2} = {resultado}";
                }

                else if (opcao == "2") 
                {
                    resultado = num1 - num2;
                    historicoOperacoes[contadorHistorico] = $"{num1} - {num2} = {resultado}";
                }
                
                else if (opcao == "3") 
                {
                    resultado = num1 * num2;
                    historicoOperacoes[contadorHistorico] = $"{num1} * {num2} = {resultado}";
                }
                    

                else if (opcao == "4")
                {
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
                    resultado = num1 / num2;
                    historicoOperacoes[contadorHistorico] = $"{num1} / {num2} = {resultado}";
                }

                contadorHistorico++;


                    Console.WriteLine("-----------------------------");
                Console.Write("O resultado é: " + resultado.ToString("F2"));
                Console.WriteLine("-----------------------------");

                Console.Write("Deseja continuar? (S/N)");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S") 
                    break;

                Console.ReadLine();
            }

           



        }
    }
}
