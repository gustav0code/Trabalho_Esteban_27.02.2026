//atividade 5

int maior,soma, n1, n2, n3;

Console.WriteLine("Digite o 1° número");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o 2° número");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o 3° número");
n3 = int.Parse(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    maior = n1;
}
else if (n2 > n3)
{
   maior  = n2;
}
else
{
    maior = n3;
}

Console.WriteLine("O maior número é " +  maior);

soma = n1 + n2 + n3;

if (soma % 2 == 0 )
{
    Console.WriteLine("A soma dos número é: " + soma + " e a soma é um número par");
}
else
{
    Console.WriteLine("A soma dos número é: " + soma + " e a soma é um número ímpar");
}