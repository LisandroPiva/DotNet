double [,] matriz = new double[4,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 7, 8, 9 } };
int filas = matriz.GetLength(0);
int columnas = matriz.GetLength(1);

if (filas != columnas){
    throw new ArgumentException("La matriz no es cuadrada");
}

int dim = Math.Min(filas,columnas);
imprimirPosMatriz(matriz);
Console.WriteLine();
imprimirContenido(matriz);
Console.WriteLine($"DIM = {dim}");

if (filas != columnas){
    throw new ArgumentException("La matriz no es cuadrada");
}

double [] diagonalPrincipal = GetDiagonalPrincipal(matriz);
imprimirVector(diagonalPrincipal);
Console.WriteLine();
double [] diagonalSecundaria = GetDiagonalSecundaria(matriz);
imprimirVector(diagonalSecundaria);


double[] GetDiagonalPrincipal(double[,] matriz){
    double[] v = new double[dim];

    for (int i = 0; i < dim; i++){
        v[i] = matriz[i,i];
    }
    return v;
}

double[] GetDiagonalSecundaria(double[,] matriz) {
    double[] v = new double[dim];

    for (int i = 0; i < dim; i++){
        v[i] = matriz[i,dim - i - 1];
    }
    return v;
}


void imprimirPosMatriz (double[,] matriz){
    for (int i = 0; i < filas; i++){
        for (int j = 0; j < columnas; j++){
            Console.Write(i + "" + j + " ");
        }
        Console.WriteLine();
    }
}

void imprimirVector(double[] vector){
    for (int i = 0; i < vector.Length; i++){
        Console.WriteLine(vector[i]);
    }
}

void imprimirContenido(double[,] m){
    for (int i = 0; i < filas; i++){
        for (int j = 0; j < columnas; j++){
            Console.Write(m[i,j]);
        }
        Console.WriteLine();
    }
}