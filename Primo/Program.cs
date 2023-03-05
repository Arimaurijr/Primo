internal class Program
{
    private static void Main(string[] args)
    {
        int numero, cont;
        bool verifica;

        void Entrada()
        {
            Console.WriteLine("DIGITE UM NÚMERO");
            numero = int.Parse(Console.ReadLine());
        }
        void iteracao()
        {
            cont = 0;
            int i = 1;
            while ((cont <= 2) && (i <= numero))
            {
                if (numero % i == 0)
                {
                    cont++;
                }

                i++;
            }

            Verifica();
        }

        void Verifica()
        {
            verifica = false;

            if (cont == 2)
            {
                verifica = true;
            }
        }

        Entrada();

        if (numero == 1)
        {
            Console.WriteLine("O NÚMERO É PRIMO !!!");
        }
        else
        {
            iteracao();

            if (verifica)
            {
                Console.WriteLine("O NÚMERO É PRIMO !!!");
            }
            else
            {
                Console.WriteLine("O NÚMERO NÃO É PRIMO !!!");
            }
        }

    }
}