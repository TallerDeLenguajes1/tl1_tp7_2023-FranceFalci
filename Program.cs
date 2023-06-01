using EspacioCaclculadora;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculadora valor = new();
        valor.Sumar(10);

        Console.WriteLine("resultado valor" + valor.Resultado);
    }
}