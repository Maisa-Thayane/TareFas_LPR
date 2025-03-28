#include <iostream>
#include <cmath>

using namespace std;
int main(){
    int horas_semana;
    int horas_dia;
    const int dias_semana = 5;
    const double semanas_mes = 4.5;
    const int total_horas= 1000;
    
    cout << "Vamos treinar um Jedi?" << endl;
    cout << "Qual e o numero de horas que ele vai treinar por dia?" << endl;
    cin >> horas_dia;

    horas_semana = dias_semana*horas_dia;
    cout << "O Jedi vai treinar por " << horas_semana << " horas por semana." << endl;

    double semanasNecessarias = static_cast<double>(total_horas) / horas_semana;
    cout << "Ele precisara de aproximadamente: " << endl;

    int diasNecessarios = ceil(semanasNecessarias * dias_semana);
    cout << diasNecessarios << " dias de treinamento," << endl;


    cout << ceil(semanasNecessarias) << " semanas de treinamento," << endl;

    double mesesNecessarios = semanasNecessarias / semanas_mes;
    cout << ceil(mesesNecessarios) << " meses de treinamento para alcancar 1000 horas." << endl;
}