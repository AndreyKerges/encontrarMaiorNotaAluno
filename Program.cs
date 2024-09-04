double n1, n2, n3;

Console.WriteLine("--- Maior Nota ---");

Console.WriteLine("Digite sua primeira nota: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua primeira nota: ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua primeira nota: ");
n3 = Convert.ToDouble(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"A maior nota é: {n1}");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"A maior nota é: {n2}");
}
else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine($"A maior nota é: {n3}");
}
else
{
    Console.WriteLine("As notas são iguais!");
}