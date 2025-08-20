#include <iostream>   // Biblioteca para entrada e saída (cout, cin, etc.)
#include <string.h>   // Biblioteca para manipulação de strings (não está sendo usada neste código)
#include <iomanip>    // Biblioteca para formatação (também não está sendo usada)
using namespace std;  // Permite usar cout, cin, endl sem precisar escrever std:: antes

int main(){
    // Exibe mensagem pedindo 3 alturas
    cout << "Digite as alturas entre 150 e 220 cm." << endl;

    // ❌ ERRO: as variáveis altura1, altura2 e altura3 não foram declaradas
    // Além disso, a forma de ler está errada (vírgula não funciona com cin)
    // Correto seria: int altura1, altura2, altura3; cin >> altura1 >> altura2 >> altura3;
    cin >> altura1, altura2, altura3;

    // Verifica se altura1 é o valor do meio (não é o maior nem o menor)
    if (altura1 > altura2 && altura1 < altura3 || altura1 < altura2 && altura1 > altura3){
        // ❌ ERRO: "cout << string + int" não funciona
        // Correto: cout << "A altura do gatti é: " << altura1;
        cout << "A altura do gatti é: " + altura1;
    }
    // Verifica se altura2 é o valor intermediário
    else if (altura2 < altura1 && altura2 > altura3 || altura2 > altura1 && altura2 < altura3){
        cout << "A altura do gatti é: " + altura2; // ❌ mesmo erro de concatenação
    }
    // Se nenhuma das condições acima, altura3 é o intermediário
    else {
        cout << "A altura do gatti é: " + altura3; // ❌ mesmo erro de concatenação
    }
}
