namespace ejercicio7;

public class Matriz
{
    double[,] _matriz;
    int _filas;
    int _columnas;

    public Matriz(int filas, int columnas){
        _matriz = new double[filas,columnas];
        _filas = filas;
        _columnas = columnas;
    }

    public Matriz(double[,]matriz){
        _matriz = matriz; 
        _filas = matriz.GetLength(0);
        _columnas = matriz.GetLength(1); 
    }

    public void SetElemento(int fila, int columna, double elemento){
        _matriz[fila,columna] = elemento;
    }

    public double GetElemento(int fila, int columna){
        return _matriz[fila,columna];
    }

    public void imprimir(){
        for (int i = 0; i < _filas; i++){
            for (int j = 0; j < _columnas; j++){
                Console.WriteLine(_matriz[i,j]);
            }
        }
    }

     public void imprimir(string formatString){
        for (int i = 0; i < _filas; i++){
            for (int j = 0; j < _columnas; j++){
                Console.Write($"{_matriz[i,j].ToString(formatString)} ");
            }
        }
    }

    public double[] GetFila(int fila){
        double[] aux = new double[_columnas];
        for (int j = 0; j < _columnas; j++){
            aux[j] = _matriz[fila,j];
        }
        return aux;
    }
    
    public double[] GetColumna(int columna){
        double[] aux = new double[_filas];
        for (int i = 0; i < _filas; i++){
            aux[i] = _matriz[i,columna];
        }
        return aux;
    }

    public double[] GetDiagonalPrincipal(){

        int dim = Math.Min(_filas,_columnas);
        double[] v = new double[dim];

        for (int i = 0; i < dim; i++){
            v[i] = _matriz[i,i];
        }
        return v;
    }

    public double[] GetDiagonalSecundaria(){
        int dim = Math.Min(_filas,_columnas);
        double[] v = new double[dim];
        for (int i = 0; i < dim; i++){
            v[i] = _matriz[i,dim - 1 - i];
        }
        return v;
    }

    public double[][] GetArregloDeArreglo(){
        double[][] m = new double[_filas][];
        for (int i=0; i < _filas; i++){
            m[i] = new double[_columnas];
        }
        for (int i = 0; i < _filas; i++){
            for (int j = 0; j < _columnas; j++){
                m[i][j] = _matriz[i,j];
            }
        }
        return m;
    }

    public double[,] GetMatriz(){
        return this._matriz;
    }

    public void sumarle (Matriz m){
        double[,] mat = m.GetMatriz();
        if (_filas == mat.GetLength(0) && (_columnas == mat.GetLength(1))){
            for (int i = 0; i < _filas; i++){
                for (int j = 0; j < _columnas; j++){
                    _matriz[i,j] += mat[i,j];
                } 
            }
        }
    }

    public void restarle (Matriz m){
        double[,] mat = m.GetMatriz();
        if (_filas == mat.GetLength(0) && (_columnas == mat.GetLength(1))){
            for (int i = 0; i < _filas; i++){
                for (int j = 0; j < _columnas; j++){
                    _matriz[i,j] -= mat[i,j];
                } 
            }
        }
    }

    public void multiplicarPor (Matriz m){
        double[,] mat = m.GetMatriz();
        for (int i = 0; i < _filas; i++){
            for (int j = 0; j < _columnas; j++){
                _matriz[i,j] *= mat[i,j];
            } 
        }
    }
    
}
