Console.WriteLine("Escolha a classe do seu personagem: ");
Console.WriteLine("Digite 1, para Guerreiro");
Console.WriteLine("Digite 2, para Mago");
Console.WriteLine("Digite 3, para Arqueiro");

int num = Convert.ToInt32(Console.ReadLine());
switch(num){
    case 1:
        Console.WriteLine("Atributos do Guerreiro:");
        Console.WriteLine("Ataque Pesado, Defesa Total, Resistencia, Trabalho em Equipe.");
        break;
  
    case 2: 
        Console.WriteLine("Atributos do Mago: ");
        Console.WriteLine("Bola de Fogo, Escudo de Gelo, Invisibilidade Temporaria, Manipulacao.");
        break;

    case 3:
        Console.WriteLine("Atributos do Arqueiro:");
        Console.WriteLine("Flecha Precisa, Disparo Triplo, Estrategia, Agilidade.");
        break;
    
    default:
        Console.WriteLine("Opção inválida. Por favor, escolha uma classe válida (1, 2 ou 3).");
        break;
}
