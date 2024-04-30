int num = int.Parse(args[0]);
//A
int fac(int n){
    int aux = 1;
    for (int i = n; i > 0; i--){
        aux = aux * i;
    }
    Console.WriteLine(aux);
    return aux;
}

//B
int fac (int n){
    if (n != 1) {
        return n * fac(n-1);
    }
    else {
        return 1;
    }
}

//C
int fac(int n ) => (n != 1) ?  n * fac(n-1) : 1; 