namespace Calculadora.ConsoleApp
{
    public static class Calculadora
    {
       public static decimal Somar(decimal num1, decimal num2) 
        {
            decimal resultado = num1 + num2;
            
            return resultado;
        }

        public static decimal Subtrair(decimal num1, decimal num2)
        {
            decimal resultado = num1 - num2;

            return resultado;
        }
        public static decimal Multiplicar(decimal num1, decimal num2)
        {
            decimal resultado = num1 * num2;

            return resultado;
        }
        public static decimal Dividir(decimal num1, decimal num2)
        {
            decimal resultado = num1 / num2;

            return resultado;
        }
    }
}
