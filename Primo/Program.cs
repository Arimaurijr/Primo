//primo
internal class Program
{
    private static void Main(string[] args)
    {
        double numero;
        int count = 0;

        Console.WriteLine("Digite um número");
        numero = int.Parse(Console.ReadLine());

        if (numero == 1)
        {
            Console.WriteLine("É primo");
        }
        else
        {
            for (int divisor = 1; divisor <= numero; divisor++)
            {
                if (numero % divisor == 0)
                {
                    count++;
                }
            }
        }

        if(count == 2)
        {
            Console.WriteLine("O número é PRIMO ");
        }
        else
        {
            Console.WriteLine("O número NÃO é PRIMO");
        }
    }
}