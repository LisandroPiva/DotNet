
double [,] matriz = new double[,] { { 1.5, 2.3, 3.2 }, { 4.2, 5.6, 6.8 } };
ImprimirMatriz(matriz,".");

void ImprimirMatriz (double[,] matriz,string formatString){
    int dimC = matriz.GetLength(0);
    int dimF = matriz.GetLength(1);
    for (int i = 0; i < dimC; i++){
        for (int j = 0; j < dimF; j++){
            Console.Write($"{matriz[i,j].ToString(formatString)} ");
        }
        Console.WriteLine();
    }
}

