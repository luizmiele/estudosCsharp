// 1- Reescrever a classe Conta, utilizando properties.

class Conta{
    public string Titular {get; set;}
    public int IdConta {get; set;}
    public float Saldo {get; set;}
    public int Senha {get; set;}
}

// 2- Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie
// DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.

// 3- Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.

class Carro
{
    private int ano;
    public string Fabricante {get; set;}
    public string Modelo {get; set;}
    public int Ano {
        get => ano; 
        set 
        {
            if(value < 1960 || value > 2023){
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            } else {
                ano = value;
            }
        }
    }
    public int QuantidadePortas{get; set;}
    public string DescricaoDetalhada => $"Modelo do carro: {this.Fabricante} {this.Modelo} {this.Ano}";
}

// 4- Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o
// estoque do produto sejam valores positivos e criar uma propriedade que mostra detalhadamente as informações do produto,
// para que seja usado pela equipe de vendas.

class Produto
{
    private double preco;
    private int estoque;
    public string Nome {get; set;}
    public string Marca {get; set;}
    public double Preco {
        get => preco; 
        set
        {
            if(value > 0)
                preco = value;
            else
                preco = 10;
        }
    }
    
    public int Estoque {
        get => estoque; 
        set 
        {
            if(value > 0)
                estoque = value;
            else
                estoque = 0;

        }
    }

    public string DescricaoProduto => $"{this.Nome} {this.Marca} - {this.Preco}";

}

/* Extra: Agora é sua vez! Refaça esse método Somar() usando uma função lambda retornando o resultado da operação.
public int Somar(int a, int b)
{
    int resultado = a + b;
    return resultado;
}
*/

internal class Program
{
    public static void Main(string[] args)
    {
        int Somar(int a, int b) => a + b;
        Console.WriteLine(Somar(5, 4));
    }
}
