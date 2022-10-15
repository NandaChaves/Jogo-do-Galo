
string[,] matriz = new string[3, 3];

string turnos = "X";
List<string> numeros = new List<string>();

int index = 1;
//parametro de contagem 
int tentativas = 1;
//preencher a matriz com valores(fill the matriz with number
//i=linhas(lines) e j=colunas(columns)

Console.WriteLine("-------------------------");
Console.WriteLine("Bem vindo ao jogo da velha(Welcome to Tic-tac-toe game");
Console.WriteLine("-------------------------");

for (int i = 0; i < matriz.GetLength(0); i++)
{
    //é 1 pois é o segundo índice
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        //preencher valores na matriz
        matriz[i, j] = index.ToString();
        numeros.Add(index.ToString());
        index++;
    }
}
//imprimir a matriz
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write($"[{matriz[i, j]}]");
    }
    //Vai ler a linha e depois quebrar criando a matriz 3x3
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine($"Você quer jogar[{turnos}] em qual posição?(You want[{turnos}] to play in which position?)");
string jogada = Console.ReadLine();

Console.Clear();
while (tentativas < 9)
{
    Console.WriteLine("-------------------------");
    Console.WriteLine("Bem vindo ao jogo da velha");
    Console.WriteLine("-------------------------");
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            //se o valor valor digitado estiver dentro da matriz
            if (matriz[i, j] == jogada && numeros.Contains(jogada))
            {
                //substitui ele
                matriz[i, j] = turnos;
                numeros.Remove(jogada);
            }
        }
    }
    //imprimir matriz(print matrix)
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write($" [{matriz[i, j]}] ");
        }
        Console.WriteLine();
    }

    if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] ||
        matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0] ||
        matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] ||
        matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
        //Condição de vitória nas colunas(victory conditions in columns)
        matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] ||
        matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
        matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2] ||
        //vitoria nas linhas(victory conditions in lines)
        matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] ||
        matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] ||
        matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])
    {
        Console.WriteLine("");
        Console.WriteLine("Fim de jogo(End game)!!!");
        Console.WriteLine($"Parabéns!!! O ganhador é [{turnos}].");
        break;
    }
    if (turnos == "X")
        turnos = "O";
    else turnos = "X";

    Console.WriteLine();
    Console.WriteLine($"Você quer jogar[{turnos}] em qual posição?(You want[{turnos}] to play in which position?)");
    jogada = Console.ReadLine();

    //enquanto o valor digitado não estiver dentro da lista
    while (!numeros.Contains(jogada))
    {
        Console.WriteLine();
        Console.WriteLine("Jogada inválida. Tente novamente(Try again)");
        jogada = Console.ReadLine();
    }

    tentativas++;
    Console.Clear();
}
if (tentativas == 9)
{
    Console.WriteLine("");
    Console.WriteLine("Fim de jogo!!!(Endgame!!!)");
    Console.WriteLine($"\nQue triste ninguém ganhou");
}
Console.ReadLine();
