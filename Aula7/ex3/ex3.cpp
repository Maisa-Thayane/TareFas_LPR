#include <iostream>
using namespace std;

int main(){
    // Variáveis para armazenar a cidade de partida e de destino
    string partida;
    string destino;

    // Matriz de distâncias entre as cidades (em km)
    // Linhas/colunas: 0 = V, 1 = BH, 2 = RJ, 3 = SP
    int matriz[4][4] = { 
        {0, 524, 521, 882}, 
        {524, 0, 434, 586}, 
        {521, 434, 0, 429}, 
        {882, 586, 429, 0} 
    };

    // Cria variáveis individuais para facilitar o acesso às distâncias
    int BHV = matriz[1][0];   // BH -> V
    int RJV = matriz[2][0];   // RJ -> V
    int SPV = matriz[3][0];   // SP -> V

    int VBH = matriz[0][1];   // V -> BH
    int RJBH = matriz[2][1];  // RJ -> BH
    int SPBH = matriz[3][1];  // SP -> BH

    int VRJ = matriz[0][2];   // V -> RJ
    int BHRJ = matriz[1][2];  // BH -> RJ
    int SPRJ = matriz[3][2];  // SP -> RJ

    int VSP = matriz[0][3];   // V -> SP
    int BHSP = matriz[1][3];  // BH -> SP
    int RJSP = matriz[2][3];  // RJ -> SP

    // Loop infinito para permitir várias consultas
    while(true){
        // Solicita cidade de partida
        cout << "Qual a cidade de partida? Sinalize com (V,BH,RJ,SP) ";
        cin >> partida;

        // Solicita cidade de destino
        cout << "Qual a cidade de destino? ";
        cin >> destino;

        // Caso a cidade de partida seja igual à de destino
        if(partida == destino){
            cout << "Voce esta na cidade que deseja! Encerrando programa.";
            break; // Encerra o programa
        }
        // Condições para partida = V (Vitoria)
        else if(partida == "V"){
            if(destino == "BH"){
                cout << "Distancia: " << BHV << "km" << endl;
            }
            if(destino == "RJ"){
                cout << "Distancia: " << RJV << "km" << endl;
            }
            if (destino == "SP"){
                cout << "Distancia: " << SPV << "km" << endl;
            }
        }
        // Condições para partida = BH (Belo Horizonte)
        else if(partida == "BH"){
            if(destino == "V"){
                cout << "Distancia: " << VBH << "km" << endl;
            }
            if(destino == "RJ"){
                cout << "Distancia: " << RJBH << "km" << endl;
            }
            if(destino == "SP"){
                cout << "Distancia: " << SPBH << "km" << endl;
            }
        }
        // Condições para partida = RJ (Rio de Janeiro)
        else if(partida == "RJ"){
            if(destino == "V"){
                cout << "Distancia: " << VRJ << "km" << endl;
            }
            if(destino == "BH"){ // Corrigido: era "partida == BH", agora compara corretamente destino
                cout << "Distancia: " << BHRJ << "km" << endl;
            }
            if(destino == "SP"){
                cout << "Distancia: " << SPRJ << "km" << endl;
            }
        }
        // Condições para partida = SP (São Paulo)
        else if (partida == "SP"){
            if(destino == "V"){
                cout << "Distancia: " << VSP << "km" << endl;
            }
            if(destino == "BH"){
                cout << "Distancia: " << BHSP << "km" << endl;
            }
            if(destino == "RJ"){
                cout << "Distancia: " << RJSP << "km" << endl;
            }
        }
    }
}
