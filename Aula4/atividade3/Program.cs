// Exibe as opções de classes para o usuário escolher
Console.WriteLine("Escolha a classe do seu personagem: ");
Console.WriteLine("Digite 1, para Guerreiro");
Console.WriteLine("Digite 2, para Mago");
Console.WriteLine("Digite 3, para Arqueiro");

// Lê a escolha do usuário e converte para inteiro
int num = Convert.ToInt32(Console.ReadLine());

// Estrutura switch: escolhe um "caminho" baseado no valor digitado
switch(num){
    case 1:
        // Se o usuário digitou 1 → Guerreiro
        Console.WriteLine("Atributos do Guerreiro:");
        Console.WriteLine("Ataque Pesado, Defesa Total, Resistencia, Trabalho em Equipe.");
        break; // Encerra o case

    case 2: 
        // Se digitou 2 → Mago
        Console.WriteLine("Atributos do Mago: ");
        Console.WriteLine("Bola de Fogo, Escudo de Gelo, Invisibilidade Temporaria, Manipulacao.");
        break;

    case 3:
        // Se digitou 3 → Arqueiro
        Console.WriteLine("Atributos do Arqueiro:");
        Console.WriteLine("Flecha Precisa, Disparo Triplo, Estrategia, Agilidade.");
        break;

    default:
        // Caso o usuário digite algo diferente de 1, 2 ou 3
        Console.WriteLine("Opção inválida. Por favor, escolha uma classe válida (1, 2 ou 3).");
        break;
}
