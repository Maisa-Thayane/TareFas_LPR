#include <iostream>  // Biblioteca para entrada e saída

using namespace std;

// Função que recebe um número inteiro e retorna seu reverso
int reverso(int numero) {
    int reverso = 0;  // Variável para armazenar o número invertido
    
    // Enquanto ainda houver dígitos no número
    while (numero != 0) {
        reverso = reverso * 10 + numero % 10; // Pega o último dígito e adiciona ao reverso
        numero /= 10; // Remove o último dígito do número original
    }
    
    return reverso; // Retorna o número invertido
}

int main() {
    int numero;
    cout << "Digite um numero inteiro: "; // Solicita número ao usuário
    cin >> numero;                        // Lê o número digitado

    // Chama a função reverso e exibe o resultado
    cout << "Numero reverso: " << reverso(numero) << endl;

    return 0;
}
