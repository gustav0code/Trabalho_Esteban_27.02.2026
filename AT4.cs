//atividade 4

int n;

Console.WriteLine("Digite um número inteiro");
n = int.Parse(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine(n + " é um número par");
}
else
{
    Console.WriteLine(n + " é um número impar");
}

Console.ReadLine();
