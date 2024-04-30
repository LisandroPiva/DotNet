double [,]? a = new double[2,2];
double [,]? b = new double[2,2];
int filasA = a.GetLength(0);
int columnasA = a.GetLength(1);
int filasB = b.GetLength(0);
int columnasB = b.GetLength(1);

double[,]? Suma(double[,] A, double[,] B){
    if (filasA == filasB) && (columnasB == columnaA){
        double [,]? m = new double[filasA,columnasA];
        for (int i = 0; i < filasA; i++){
            for (int j = 0; j < columnasA; j++){
                m[i,j] = A[i,j] + B[i,j];
            }
        }
        return m;
    }   
    else {
        return null;
    }
}
double[,]? Resta(double[,] A, double[,] B){
     if (filasA == filasB) && (columnasB == columnaA){
        double [,]? m = new double[filasA,columnasA];
        for (int i = 0; i < filasA; i++){
            for (int j = 0; j < columnasA; j++){
                m[i,j] = A[i,j] - B[i,j];
            }
        }
        return m;
    }   
    else {
        return null;
    }
}
double[,] Multiplicacion(double[,] A, double[,] B){
    if (columnasA == filasB) {
        double[,] resul = new double[A.GetLength(0),B.GetLength(1)];
        for(int i=0; i<A.GetLength(0); i++){
          for(int j=0;j<B.GetLength(1); j++){
             resul[i,j]=0;
             for(int x=0; x<A.GetLength(1);x++){
                resul[i,j] += A[i,x] * B[x,j];
             }
          }
        }
       return resul;
    else {
        throw new ArgunmentException("EE");
    }

}

