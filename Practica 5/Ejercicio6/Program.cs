

using ejercicio6;

/*double [,] matriz = new double[3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 };*/

Matriz m = new Matriz(2,2);
m[0,0] = 1;
m[0,1] = 2;
m[1,0] = 3;
m[1,1] = 4;

for (int i = 0; i < m.Filas; i++){
    for (int j = 0; j < m.Columnas; j++){
        Console.Write(m[i,j] + " ");
    }
    Console.WriteLine(" ");
}

Console.WriteLine("----------------------------");

double[] dp = m.DiagonalPrincipal;

for (int i = 0; i < dp.Length; i++){
    Console.WriteLine(dp[i]);
}

Console.WriteLine("----------------------------");

double[] ds = m.DiagonalSecundaria;

for (int i = 0; i < ds.Length; i++){
    Console.WriteLine(ds[i]);
}