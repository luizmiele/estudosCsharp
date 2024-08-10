//1 - Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas 
//(adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
string CalculoDoisNumeros()
{
    Console.WriteLine("Digite o primeiro numero: ");
    int a = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Digite o segundo numero: ");
    int b = Convert.ToInt32(Console.ReadLine());
    
    Console.Clear();
    int soma = a + b;
    int subtracao = a - b;
    int multiplicacao = a * b;
    int divisao = a / b;
    
    return $"Soma de {a} + {b} é: {soma}\nSubratacao de {a} - {b} é: {subtracao}\nMultiplicação de {a} * {b} é: {multiplicacao}\nDivisao de {a} / {b} é: {divisao}" ;
}

// Console.WriteLine(CalculoDoisNumeros());


//2- Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
// 3- Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
List<string> bandas = new List<string> { };

void AdicionaBandas()
{
    bool sair = false;
    do
    {
        Console.WriteLine("Digite o nome de uma banda. ou digite SAIR");
        var banda = Console.ReadLine()!;

        if (banda == "SAIR" || banda == "sair" )
        {
            foreach (string bandaExibir in bandas)
            {
                Console.WriteLine(bandaExibir);
            }
            sair = true;
        }
        bandas.Add(banda);
    } while(sair == false);
}

//AdicionaBandas();

// 4- Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.



void somaDaLista()
{
    List<int> numerosRandom = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int somaNumeros = 0;
    for (int i = 0; i < numerosRandom.Count; i++ )
    {
        somaNumeros += numerosRandom[i];
    }
    Console.WriteLine($"Resultado da soma da lista é: {somaNumeros}");
}

somaDaLista();