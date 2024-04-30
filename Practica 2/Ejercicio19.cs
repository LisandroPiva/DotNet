//A
int res;

void fac(int n, out int res){
    int aux = 1;
    for (int i = n; i > 0; i--){
        aux = aux * i;
    }
    res = aux;
}
fac(num,out res);
Console.WriteLine(res);

//B
int res = 1;
void fac (int n, out int res){
    if (n != 1) {
        fac(n-1, out res); 
        res = n * res;
    }
    else {
        res = 1;
    }
}

fac(num,out res);
Console.WriteLine(res);