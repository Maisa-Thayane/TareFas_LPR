#include <iostream> 
#include <string>

using namespace std;


double soma;

int main() {
    double n;
    cout << "Digite um numero: " << endl;
    cin >> n;

    long long quadrado = static_cast<long long>(n * n);
    cout << "O quadrado do numero: " << quadrado << endl;

    string numString = to_string(quadrado);
    
    int soma = 0;
    for (char digito : numString) {
        if (isdigit(digito)) { 
            soma += digito - '0'; 
        }
    }
    cout << "A soma dos digitos do quadrado: " << soma << std::endl;
}