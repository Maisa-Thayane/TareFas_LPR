#include <iostream>
using namespace std;

int main() {
    // Declaração das matrizes A, B e C (3x3)
    int A[3][3];
    int B[3][3];
    int C[3][3] = {0}; // Inicializa todos os elementos com zero

    // Entrada dos elementos da matriz A
    cout << "Digite os elementos da matriz A (3x3):\n";
    for (int i = 0; i < 3; i++) {        // Percorre as linhas
        for (int j = 0; j < 3; j++) {    // Percorre as colunas
            cin >> A[i][j];              // Lê o valor digitado pelo usuário
        }
    }

    // Entrada dos elementos da matriz B
    cout << "Digite os elementos da matriz B (3x3):\n";
    for (int i = 0; i < 3; i++) {        // Percorre as linhas
        for (int j = 0; j < 3; j++) {    // Percorre as colunas
            cin >> B[i][j];              // Lê o valor digitado pelo usuário
        }
    }

    // Multiplicação das matrizes A x B
    for (int i = 0; i < 3; i++) {           // Percorre as linhas da matriz resultante C
        for (int j = 0; j < 3; j++) {       // Percorre as colunas da matriz C
            for (int k = 0; k < 3; k++) {   // Percorre a linha de A e coluna de B
                C[i][j] += A[i][k] * B[k][j]; // Soma do produto dos elementos correspondentes
            }
        }
    }

    // Exibe a matriz resultante C
    cout << "Resultado da multiplicação das matrizes A x B:\n";
    for (int i = 0; i < 3; i++) {        // Percorre as linhas
        for (int j = 0; j < 3; j++) {    // Percorre as colunas
            cout << C[i][j] << " ";      // Mostra cada elemento seguido de espaço
        }
        cout << endl;                    // Quebra de linha após cada linha da matriz
    }

    return 0; // Encerra o programa
}
