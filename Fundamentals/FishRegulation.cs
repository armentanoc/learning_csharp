namespace Fundamentals
{
    public class FishRegulation
    {

        public static void run()
        {
            const double fishLimit = 50F;

            double
                fishWeight = Receive.Float("Informe a quantidade em kg de peixes pescados: "),
                excess,
                taxation;

            if(fishWeight > fishLimit)
            {
                excess = Math.Truncate(fishWeight - fishLimit);
                taxation = excess * 4;
                Console.WriteLine($"\nExcesso: {excess}kg");
                Console.WriteLine($"Multa: R${Math.Round(taxation, 2)}");
            } else if(fishWeight < 0)
            {
                Console.WriteLine("O valor não pode ser negativo.\n");
                run();
            } else
            {
                Console.WriteLine($"\nExcesso: ZERO");
                Console.WriteLine($"Multa: ZERO");
            }

        }
    }
}

/*

DESAFIO 05:

Sr. José, pescador, comprou um microcomputador para
controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de
peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo
(50 quilos) deve pagar uma multa de R$4,00 por quilo excedente. Sr. José, precisa que
você faça programa que leia o peso de peixes e verifique se há excesso.
Se houver, gravar o Excesso e o valor da multa que Sr. José
deverá pagar. Caso contrário mostrar os valores com o conteúdo ZERO. 
Apresentar as mensagens no console.
 
 */