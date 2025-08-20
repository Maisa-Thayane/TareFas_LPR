#include <iostream>  // Biblioteca para entrada e saída
#include <vector>    // Biblioteca para usar vetor dinâmico
#include <cstdlib>   // Biblioteca para rand() e srand()
using namespace std;

// ----------------------- Exercício 1 -----------------------
// Calcula a média dos números pares digitados pelo usuário
void ex1() {
    int quant;
    cout << "Digite a quantidade de elementos a serem contabilizados: ";
    cin >> quant;

    vector<int> elementos(quant); // Cria um vetor com "quant" posições
    int acumulador = 0, contagem = 0; // Para somar pares e contar quantos existem

    cout << "Liste os elementos da media:\n";
    for (int i = 0; i < quant; i++) {
        cout << "Elemento " << (i + 1) << ": ";
        cin >> elementos[i];

        if (elementos[i] % 2 == 0) { // Se for par
            acumulador += elementos[i]; // Soma no acumulador
            contagem++;                 // Conta o número de pares
        }
    }

    // Verifica se houve algum número par para calcular a média
    if (contagem > 0) {
        double media = (double)acumulador / contagem; // Calcula média
        cout << "A media dos numeros pares e: " << media << endl;
    } else {
        cout << "Nao ha numeros pares para calcular a media.\n";
    }
}

// ----------------------- Exercício 2 -----------------------
// Jogo de adivinhar o número secreto entre 1 e 100
void ex2() {
    cout << "Tente descobrir o numero secreto de 1 a 100!\n";
    srand(time(0)); // Inicializa o gerador de números aleatórios
    int valorSecreto = rand() % 100 + 1; // Número aleatório entre 1 e 100
    int chute, tentativas = 0;

    // Loop até o jogador acertar
    do {
        cout << "Qual sera o chute? ";
        cin >> chute;
        tentativas++;

        if (chute < valorSecreto) {
            cout << "Muito baixo!\n";
        } else if (chute > valorSecreto) {
            cout << "Muito alto!\n";
        } else {
            cout << "Parabens, voce acertou!\n";
            cout << "Voce precisou de " << tentativas << " tentativas.\n";
        }
    } while (chute != valorSecreto);
}

// ----------------------- Exercício 3 -----------------------
// Soma todos os números ímpares múltiplos de 3 entre 50 e 500
void ex3() {
    int soma = 0;
    for (int i = 50; i <= 500; i++) {
        if ((i % 2 != 0) && (i % 3 == 0)) { // Se ímpar e múltiplo de 3
            soma += i; // Adiciona à soma
        }
    }
    cout << "A soma de todos os numeros impares multiplos de 3 entre 50 e 500 é: " << soma << endl;
}

// ----------------------- Menu -----------------------
// Exibe um menu interativo para escolher os exercícios
void menu() {
    int escolha;
    do {
        cout << "\nMenu:\n";
        cout << "1 - Exercicio 1\n";
        cout << "2 - Exercicio 2\n";
        cout << "3 - Exercicio 3\n";
        cout << "0 - Sair\n";
        cout << "Escolha uma opcao: ";
        cin >> escolha;

        switch (escolha) {
            case 1:
                ex1(); // Chama exercício 1
                break;
            case 2:
                ex2(); // Chama exercício 2
                break;
            case 3:
                ex3(); // Chama exercício 3
                break;
            case 0:
                cout << "Saindo...\n";
                break;
            default:
                cout << "Opcao invalida!\n";
        }
    } while (escolha != 0); // Repete até o usuário escolher 0
}

// ----------------------- Função principal -----------------------
int main() {
    menu(); // Chama o menu principal
    return 0;
}
