#include <iostream> // Biblioteca para entrada e saída
#include <string>   // Biblioteca para manipulação de strings

using namespace std; // Para usar cout, cin, string diretamente

double soma; // Variável global (não usada globalmente aqui, poderia ser local)

// Função principal
int main() {
    double n; // Variável para armazenar o número digitado pelo usuário
    cout << "Digite um numero: " << endl;
    cin >> n; // Lê o número

    // Calcula o quadrado do número e converte para long long para evitar estouro
    long long quadrado = static_cast<long long>(n * n);
    cout << "O quadrado do numero: " << quadrado << endl;

    // Converte o quadrado para string para poder percorrer os dígitos
    string numString = to_string(quadrado);
    
    int soma = 0; // Variável para acumular a soma dos dígitos

    // Loop que percorre cada caractere da string
    for (char digito : numString) {
        if (isdigit(digito)) { // Verifica se o caractere é um dígito
            soma += digito - '0'; // Converte o caractere para inteiro e soma
        }
    }

    // Exibe a soma dos dígitos
    cout << "A soma dos digitos do quadrado: " << soma << std::endl;
}
