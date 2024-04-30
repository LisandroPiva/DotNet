double[,] matriz = new double[2,2] {{1,2},{3,4}};
int filas = matriz.GetLength(0);
int columnas = matriz.GetLength(1);
double [][] vv = GetArregloDeArreglo(matriz);
imprimirVectorDeVector(vv);

double [][] GetArregloDeArreglo(double[,]matriz){
    double [][] vv = new double[filas][];
    for (int i = 0; i < filas; i++) {
        vv[i] = new double[columnas];
    }

    for (int i = 0; i < filas; i++){
        for (int j = 0; j < columnas; j++){
            vv[i][j] = matriz[i,j];
        }
    }
    return vv;
}

void imprimirVectorDeVector(double[][] vv){
    for (int i = 0; i < filas; i++){
        for (int j = 0; j < columnas; j++){
            Console.WriteLine(vv[i][j]);
        }
    }
}