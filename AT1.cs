//Atividade 1

double distancia,x1, x2, y1, y2;

Console.WriteLine("Digite o x1");
x1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o y1");
y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o x2");
x2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o y2");
y2 = double.Parse(Console.ReadLine());  


distancia = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));

Console.WriteLine("A distância dos pontos é " + distancia);