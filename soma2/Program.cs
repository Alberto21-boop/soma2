namespace soma2;

public class Program
{
    static void Main(string[] args)
    {
        //Pergunta 1 de 1, int INDICE = 13, SOMA = 0, K = 0; Ao final do processamento, qual será o valor da variável SOMA?

        int indice, soma, K;

        indice = 13;
        soma = 0;
        K = 0;

        Console.WriteLine("Entre com o numero inteiro zero por favor.");
        Console.Write("Digite o zero = ");
        K = int.Parse(Console.ReadLine());

        while(K < indice)
        {
            soma = soma + K;
            K++;
        }
        Console.WriteLine("O valor de soma é = " + soma);
    }
}