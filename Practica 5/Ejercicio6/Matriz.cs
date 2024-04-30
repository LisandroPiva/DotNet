using System.Dynamic;

namespace ejercicio6;
/*Modificar la definición de la clase Matriz realizada en la práctica 4. Eliminar los métodos
SetElemento(...) y GetElemento(...). Definir un indizador adecuado para leer y escribir
elementos de la matriz. Eliminar los métodos GetDiagonalPrincipal() y
GetDiagonalSecundaria() reemplazándolos por las propiedades de sólo lectura
DiagonalPrincipal y DiagonalSecundaria.*/

public class Matriz {
    double[,] matriz;
    
    public Matriz(int filas, int columnas){
        this.matriz = new double[filas,columnas];
    }

    public int Filas => matriz.GetLength(0);
    public int Columnas => matriz.GetLength(1);

    public double this[int x,int y]{
        get => matriz[x,y];
        set => matriz[x,y] = value;
    
    }

    public double[] DiagonalPrincipal{
        get {
            double[] diagonal = new double[Math.Min(Filas, Columnas)];
            for (int i = 0; i < diagonal.Length; i++)
            {
                diagonal[i] = matriz[i, i];
            }
            return diagonal;
        }
    }

    public double[] DiagonalSecundaria {
        get {
            int minDimension = Math.Min(Filas, Columnas);
            double[] diagonal = new double[minDimension];
            for (int i = 0; i < minDimension; i++)
            {
                diagonal[i] = matriz[i, minDimension - i - 1];
            }
            return diagonal;
        }
    }

    
}
