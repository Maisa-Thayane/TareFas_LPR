#include <iostream>
#include <vector>
#include <cstdlib>
using namespace std;


void ex1() {
    int quant;
    cout << "Digite a quantidade de elementos a serem contabilizados: ";
    cin >> quant;

    vector<int> elementos(quant);
    int acumulador = 0, contagem = 0;

    cout << "Liste os elementos da media:\n";
    for (int i = 0; i < quant; i++) {
        cout << "Elemento " << (i + 1) << ": ";
        cin >> elementos[i];

        if (elementos[i] % 2 == 0) {
            acumulador += elementos[i];
            contagem++;
        }
    }

    if (contagem > 0) {
        double media = (double)acumulador / contagem;
        cout << "A media dos numeros pares e: " << media << endl;
    } else {
        cout << "Nao ha numeros pares para calcular a media.\n";
    }
}


void ex2() {
    cout << "Tente descobrir o numero secreto de 1 a 100!\n";
    srand(time(0));
    int valorSecreto = rand() % 100 + 1;
    int chute, tentativas = 0;

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


void ex3() {
    int soma = 0;
    for (int i = 50; i <= 500; i++) {
        if ((i % 2 != 0) && (i % 3 == 0)) {
            soma += i;
        }
    }
    cout << "A soma de todos os numeros impares multiplos de 3 entre 50 e 500 é: " << soma << endl;
}


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
                ex1();
                break;
            case 2:
                ex2();
                break;
            case 3:
                ex3();
                break;
            case 0:
                cout << "Saindo...\n";
                break;
            default:
                cout << "Opcao invalida!\n";
        }
    } while (escolha != 0);
}


int main() {
    menu();
    return 0;
}
