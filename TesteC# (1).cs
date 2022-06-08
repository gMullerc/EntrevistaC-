
teste();
void teste()
{
    Console.WriteLine("Primeiramente digite a quantidade de amostras que serão usadas");

    int notasUsadas;
    notasUsadas = int.Parse(Console.ReadLine());

    int[] media = new int[notasUsadas];

    int aux = 0;

    for (int i = 0; i < media.Length; i++)
    {

        int aluno = 1;
        aluno = i + aluno;
        Console.WriteLine("Digite as " + notasUsadas + " amostras usadas para calcular a eficiência do Aluno[" + aluno + "].");

        media[i] = int.Parse(Console.ReadLine());

        Console.WriteLine(" A nota " + "[" + i + "] do aluno é = " + media[i]);

        aux += media[i];
    }

    double med = (aux / media.Length);
    Console.WriteLine("Média = " + med);
}
Console.WriteLine("Deseja calcular a media de mais algum aluno?[1] para continuar [2] para parar ");
int resposta;
resposta = int.Parse(Console.ReadLine());
if(resposta == 1 )
{
    teste();
}else
{
    Console.WriteLine("Obrigado, estou sempre a disposição");

}



Console.ReadLine();
}
