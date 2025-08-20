#include <iostream>

using namespace std;
    
int main() {
    int A, B;
    
    cout << "Digite dois números inteiros separados por espaço: " << endl;
    cin >> A >> B; 

    if ((A % B == 0) || (B % A == 0) ) {
        cout << A << " e " << B << " sao mltiplos. " << endl;
    } else {
        cout << A << " e " << B << " nao sao múltiplos. " << endl;
    }
    
}