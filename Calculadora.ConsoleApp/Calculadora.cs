namespace Calculadora.ConsoleApp
{
    public static class Calculadora
    {

        //atributos de classe
        static string[] historicoOperacoes = new string[100];
        static int contadorHistorico = 0;
        public static decimal Somar(decimal num1, decimal num2) 
        {
            decimal resultado = num1 + num2;

            historicoOperacoes[contadorHistorico] = $"{num1} + {num2} = {resultado}";
            contadorHistorico++;

            return resultado;
        }

        public static decimal Subtrair(decimal num1, decimal num2)
        {
            decimal resultado = num1 - num2;

            historicoOperacoes[contadorHistorico] = $"{num1} - {num2} = {resultado}";
            contadorHistorico++;

            return resultado;
        }
        public static decimal Multiplicar(decimal num1, decimal num2)
        {
            decimal resultado = num1 * num2;

            historicoOperacoes[contadorHistorico] = $"{num1} * {num2} = {resultado}";
            contadorHistorico++;

            return resultado;
        }
        public static decimal Dividir(decimal num1, decimal num2)
        {
            decimal resultado = num1 / num2;

            historicoOperacoes[contadorHistorico] = $"{num1} / {num2} = {resultado}";
            contadorHistorico++;

            return resultado;
        }
        public static string[] GerarTabuada(int numeroTabuada) 
        {
            string[] linhasTabuada = new string[10];

            //calcula tabuada até o 10 desse numero
            for (int contador = 1; contador <= 10; contador++)
            {
                int resultadoTabuada = numeroTabuada * contador;

                //string LinhaTabuada = numeroTabuada + " X " + contador + " = " + resultadoTabuada;
                linhasTabuada[contador - 1] = $"{numeroTabuada} x {contador} = {resultadoTabuada}";
            }
            return linhasTabuada;
        }

        public static string[] ObterHistoricoOperacoes() 
        {
            return historicoOperacoes;
        }
    }
}
