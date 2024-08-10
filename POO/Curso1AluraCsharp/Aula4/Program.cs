// 1- Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
Dictionary<string, List<int>> alunos = new Dictionary<string, List<int>>
{
    {"Joao", new List<int>{ 10, 10, 9}},
    {"Pedro", new List<int>{9, 4, 10}},
    {"Paulo", new List<int> { 4, 3, 2}}
};

void MostraMediaAlunos()
{
    foreach (var aluno in alunos)
    {
        double soma = 0;
        for(int i = 0; i < aluno.Value.Count ; i++){
            soma += aluno.Value[i];
        }
        double media = soma / aluno.Value.Count();
        Console.WriteLine($"A média do aluno {aluno.Key} é: {media}");
    }
}

//MostraMediaAlunos();

//2- Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas
// quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque. 

Dictionary<string, int> produtos = new Dictionary<string, int>
{
    {"Mouse", 10},
    {"Teclado", 14},
    {"Fone", 2}
};

void MostrarEstoque()
{
    Console.WriteLine("Escolha um produto ");
    foreach (var produto in produtos)
    {
        Console.WriteLine(produto.Key);
    }
    var opcao = Console.ReadLine();

    if (produtos.ContainsKey(opcao))
    {
        Console.WriteLine($"O estoque de {opcao} é de {produtos[opcao]} unidades.");
    }
    else
    {
        Console.WriteLine("Produto não encontrado.");
    }
}

//MostrarEstoque();

// 3- Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as
// perguntas e as respostas corretas.

Dictionary<string, string> quiz = new Dictionary<string, string>
{
    {"Quantos Mouse tem na loja anterior?", "10"},
    {"Quantos Teclados tem na loja anterior?", "14"},
    {"Quantos Fones tem na loja anterior?", "2"}
};

void JogoQuiz()
{
    int pontuacao = 0;

    foreach (var pergunta in quiz)
    {
        Console.WriteLine(pergunta.Key);
        Console.Write("Sua resposta: ");
        string respostaUsuario = Console.ReadLine();

        if (respostaUsuario.ToLower() == pergunta.Value.ToLower())
        {
            Console.WriteLine("Resposta CERTA!!!!\n");
            pontuacao++;
        }
        else
        {
            Console.WriteLine($"Incorreto. A resposta correta é: {pergunta.Value}\n");
        }
    }

    Console.WriteLine($"Pontuação final: {pontuacao} de {quiz.Count}");
}

//JogoQuiz();

// 4- Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

Dictionary<string, string> loginSenha = new Dictionary<string, string>
{
    {"Miele", "123"},
    {"Raphael", "456"},
    {"Boeck", "111"}
};

void Cadastro()
{
    Console.WriteLine("Digite o login que deseja criar: ");
    var novoLogin = Console.ReadLine()!;
    Console.WriteLine("Digte a senha: ");
    var novaSenha = Console.ReadLine()!;

    loginSenha.Add(novoLogin, novaSenha);
}

void Login()
{
    Console.WriteLine("Qual o seu login? ");
    var login = Console.ReadLine()!;
    
    Console.WriteLine("Qual a sua senha? ");
    var senha = Console.ReadLine()!;

    if (loginSenha.ContainsKey(login) && loginSenha[login] == senha)
    {
        Console.WriteLine("LOGIN EFETUADO!");
    }
    else
    {
        Console.WriteLine("Login ou senha incorreto!");
    }
    
}
Cadastro();
Login();

