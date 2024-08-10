Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

Console.WriteLine(numeroSecreto);
var numeroChutes = 3;

do
{
    Console.WriteLine("Digite um número entre 1 e 100:");
    int chute = int.Parse(Console.ReadLine());
    
     if (chute == numeroSecreto)
     {
         Console.WriteLine("Parabéns! Você acertou o número secreto!");
         break;
     }
     else if (chute > numeroSecreto)
     {
         Console.WriteLine("O número secreto é menor que o chute.");
         numeroChutes--;
     }
     else
     {
         Console.WriteLine("O número secreto é maior que o chute.");
         numeroChutes--;
     }
     
     if (numeroChutes == 1)
     {
         Console.WriteLine("ULTIMA CHANCE! Boa sorte.");
     }
     else if( numeroChutes == 0)
     {
         Console.WriteLine("Você perdeu! O número secreto era " + numeroSecreto);
     }
     else
     {
         Console.WriteLine("VOCE AINDA TEM  " + numeroChutes + " CHANCES.");
     }
} while (numeroChutes > 0);
     

