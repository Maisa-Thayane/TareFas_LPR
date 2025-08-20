#include <iostream>   // Biblioteca de entrada e saída (cin, cout, endl)

using namespace std;  // Para evitar escrever std::cout, std::cin, etc.
    
int main() {
    int A, B; // Declara duas variáveis inteiras

    // Pede para o usuário digitar dois números inteiros
    cout << "Digite dois números inteiros separados por espaço: " << endl;
    cin >> A >> B; // Lê os valores digitados e armazena em A e B

    // Verifica se um número é múltiplo do outro
    // Se A dividido por B não deixa resto (A % B == 0)
    // OU se B dividido por A não deixa resto (B % A == 0)
    if ((A % B == 0) || (B % A == 0) ) {
        cout << A << " e " << B << " sao multiplos. " << endl;
    } else {
        cout << A << " e " << B << " nao sao multiplos. " << endl;
    }
}
