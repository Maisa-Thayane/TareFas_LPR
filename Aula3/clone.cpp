#include <iostream>
#include <locale>

using namespace std;

int main() {
    setlocale(LC_ALL, "pt_BR.utf8"); //Para usar acentuacao
    cout << "\033[1;34m***************************************************\033[0m\n";
    cout << "\033[1;32m*                                                 *\033[0m\n";
    cout << "\033[1;32m*   \033[1;33m PARABENS 34DS!                     \033[1;32m          *\033[0m\n";
    cout << "\033[1;32m*                                                 *\033[0m\n";
    cout << "\033[1;32m*   \033[1;36mVoce clonou um repositorio publico do Git     \033[1;32m*\033[0m\n";
    cout << "\033[1;32m*   \033[1;36mpara o seu repositorio local!                 \033[1;32m*\033[0m\n";
    cout << "\033[1;32m*                                                 *\033[0m\n";
    cout << "\033[1;34m*************************<3************************\033[0m\n";

    return 0;
}