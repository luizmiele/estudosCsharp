using Aula4;

// 3- Instanciar uma Conta e exibir suas informações na tela, utilizando construtores.

Titular titular = new Titular("Luiz Miele", 31, "Rua tal - ali");

Conta conta1 = new Conta(titular, 1, 2234, 100000, 100000);

conta1.ExibeDetalhes();

