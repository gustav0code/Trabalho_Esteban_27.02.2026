//Atividade 3


double media, n1, n2, n3;

Console.WriteLine("Digite a primeira nota");
n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota");
n3 =  double.Parse(Console.ReadLine());

media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

Console.WriteLine("Sua nota média é : " + media);
