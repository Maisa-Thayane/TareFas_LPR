#include <iostream>
#include <string.h>
#include <iomanip>
using namespace std;

int main(){
    cout << "Digite as alturas entre 150 e 220 cm." <<endl;
    cin >> altura1, altura2, altura3;
    if (altura1 > altura2 && altura1<altura3 || altura1 < altura2 && altura1 > altura3){
        cout << "A altura do gatti é: " + altura1;
    } else if (altura2 < altura1 && altura2  > altura3 || altura2 > altura1 && altura2  < altura3){
        cout << "A altura do gatti é: " + altura2;
    } else {
        cout << "A altura do gatti é: " + altura3;
    }
}