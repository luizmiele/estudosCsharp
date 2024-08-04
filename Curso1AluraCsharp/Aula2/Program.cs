var notaMedia = 8;
string[] linguagens = ["C#", "JAVA", "JS"];

if (notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação");
} 

Console.WriteLine(linguagens[0]);

Console.WriteLine("Digite 1 para C#, 2 para JAVA , 3 para JS ");

int escolha = Convert.ToInt32(Console.ReadLine());
if (escolha < 3)
{
    Console.WriteLine(linguagens[escolha - 1]);
}
else
{
    Console.WriteLine("Opção invalida!");
}
