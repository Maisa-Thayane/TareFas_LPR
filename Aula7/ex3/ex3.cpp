#include <iostream>
using namespace std;

int main(){
    string partida;
    string destino;

    int matriz[4][4] = { {0, 524, 521, 882}, {524, 0, 434, 586}, {521, 434, 0, 429}, {882, 586, 429, 0} };
    //int VV = matriz[0][0];
    int BHV = matriz[1][0];
    int RJV = matriz[2][0];
    int SPV = matriz[3][0];
    int VBH = matriz[0][1];
    //int BHBH = matriz[1][1];
    int RJBH = matriz[2][1];
    int SPBH = matriz[3][1];
    int VRJ = matriz[0][2];
    int BHRJ = matriz[1][2];
    //int RJRJ = matriz[2][2];
    int SPRJ = matriz[3][2];
    int VSP = matriz[0][3];
    int BHSP = matriz[1][3];
    int RJSP = matriz[2][3];
    //int SPSP = matriz[3][3];
while(true){
    cout << "Qual a cidade de partida? Sinalize com (V,BH,RJ,SP)";
    cin >> partida;
    cout << "Qual a cidade de destino?";
    cin >> destino;

    if(partida == destino){
        cout << "Voce esta na cidade que deseja! Encerrando programa.";
        break;
    }
    else if(partida == "V"){
        if(destino == "BH"){
            cout << "Distancia: " << BHV << "km" << endl;
        }
        if(destino == "RJ"){
            cout << "Distancia: " << RJV << "km" << endl;
        }
        if (destino == "SP"){
        {
            cout << "Distancia: " << SPV << "km" << endl;
        }
    }
    }
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
    else if(partida == "RJ"){
        if(destino == "V"){
            cout << "Distancia: " << VRJ << "km" << endl;
        }
        if(partida == "BH"){
            cout << "Distancia: " << BHRJ << "km" << endl;
        }
        if(partida == "SP"){
            cout << "Distancia: " << SPRJ << "km" << endl;
        }
    }
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

    
