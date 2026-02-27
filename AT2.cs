//Atividade 2


int n1, n2, n3;
double resultado, R, S;

Console.WriteLine("Digite o primeiro número");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número");
n3 = int.Parse(Console.ReadLine());

R = Math.Pow(n1 + n2 ,2);

S = Math.Pow(n2 + n3,2);

resultado = (R + S) / 2;

Console.WriteLine("O resultado é: " + resultado);



