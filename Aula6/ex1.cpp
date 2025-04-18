#include <iostream>

using namespace std;
int reverso(int numero) {
    int reverso = 0;
    
    while (numero != 0) {
        reverso = reverso * 10 + numero % 10; 
        numero /= 10; 
    }
    
    return reverso;
}

int main() {
    int numero;
    cout << "Digite um numero inteiro: ";
    cin >> numero;

    cout << "Numero reverso: " << reverso(numero) << endl;

return 0;
}