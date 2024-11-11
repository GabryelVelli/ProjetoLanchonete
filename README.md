# ProjetoLanchonete
## Projeto Lanchonete 🍔 ##
Este projeto simula o sistema de uma lanchonete, permitindo cadastrar lanches, realizar pedidos e gerar a conta com totalização e taxa de serviço. Ele foi desenvolvido em C# e utiliza conceitos como listas e dicionários para armazenar e gerenciar os dados dos pedidos.

## Funcionalidades ##
- Cadastro de Lanches: Permite cadastrar até 10 lanches no sistema, incluindo nome, descrição e preço.
- Exibição do Cardápio: Exibe todos os lanches cadastrados para facilitar a escolha.
- Pedido de Lanches: Permite ao usuário selecionar um ou mais lanches para compor o pedido, com controle de quantidades.
- Conta: Mostra a lista dos lanches pedidos, a quantidade de cada um, o total da compra e a inclusão de uma taxa de serviço de 7%.

## Como Usar
1. Execute o programa.
2. Escolha uma opção no menu principal:
- Cardápio: Exibe os lanches disponíveis.
- Fazer Pedido: Adiciona lanches ao pedido.
- Conta: Exibe o resumo e o total do pedido.
- Cadastrar novo lanche: Permite cadastrar um novo lanche no sistema.
- Sair: Finaliza o programa.
3. Siga as instruções no terminal para navegar pelas funcionalidades.

## Estrutura do Código

- Classe Lanchonete
A classe principal Lanchonete gerencia o cardápio, os pedidos e o cálculo da conta. Suas principais propriedades e métodos são:

- List<Lanches> lanchesDisponiveis: Lista que armazena os lanches cadastrados.
- Dictionary<Lanches, int> pedidoAtual: Dicionário que armazena os lanches pedidos e suas respectivas quantidades.
- AdicionarLanche: Método para cadastrar um novo lanche no cardápio.
- Pedido: Método para adicionar um lanche ao pedido.
- Conta: Método que exibe o resumo do pedido, o total e a taxa de serviço.

- Classe Lanches
A classe Lanches define as propriedades básicas de um lanche: Nome, Descrição, e Preço.

- Ao escolher a opção 1 o cardapio será exibido para o usuário.
- Ao escolher a opção 4 e cadastrar um novo lanche, será solicitado o nome, a descrição e o preço.
- Na opção 2, você escolhe um lanche pelo número para adicionar ao pedido.
- A opção 3 exibe o resumo do pedido, incluindo quantidade, total e taxa de serviço.
