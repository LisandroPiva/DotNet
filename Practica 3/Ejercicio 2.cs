
double [,] matriz = new double[3,3];
ImprimirMatriz(matriz);

void ImprimirMatriz (double[,] matriz){
    int dimC = matriz.GetLength(0);
    int dimF = matriz.GetLength(1);
    for (int i = 0; i < dimC; i++){
        for (int j = 0; j < dimF; j++){
            Console.Write(matriz[i,j]);
        }
        Console.WriteLine();
    }
}

