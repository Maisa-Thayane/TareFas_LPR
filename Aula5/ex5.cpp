#include <iostream> // Biblioteca para entrada e saída
#include <cmath>    // Biblioteca para funções matemáticas, como ceil()

using namespace std;

int main() {
    int horas_semana;  // Variável para armazenar horas de treino por semana
    int horas_dia;     // Horas de treino por dia
    const int dias_semana = 5;    // Assume que o Jedi treina 5 dias por semana
    const double semanas_mes = 4.5; // Aproximação de semanas em um mês
    const int total_horas = 1000;   // Total de horas que o Jedi precisa treinar

    // Mensagem inicial
    cout << "Vamos treinar um Jedi?" << endl;
    cout << "Qual e o numero de horas que ele vai treinar por dia?" << endl;

    cin >> horas_dia; // Lê as horas de treino por dia fornecidas pelo usuário

    // Calcula horas de treino por semana
    horas_semana = dias_semana * horas_dia;
    cout << "O Jedi vai treinar por " << horas_semana << " horas por semana." << endl;

    // Calcula o número de semanas necessárias para atingir 1000 horas
    double semanasNecessarias = static_cast<double>(total_horas) / horas_semana;
    cout << "Ele precisara de aproximadamente: " << endl;

    // Calcula a quantidade de dias necessários, arredondando para cima
    int diasNecessarios = ceil(semanasNecessarias * dias_semana);
    cout << diasNecessarios << " dias de treinamento," << endl;

    // Mostra semanas necessárias arredondadas para cima
    cout << ceil(semanasNecessarias) << " semanas de treinamento," << endl;

    // Converte semanas em meses (aproximadamente) e arredonda para cima
    double mesesNecessarios = semanasNecessarias / semanas_mes;
    cout << ceil(mesesNecessarios) << " meses de treinamento para alcancar 1000 horas." << endl;
}
