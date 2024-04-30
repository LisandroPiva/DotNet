int n = int.Parse(args[0]);

bool EsPrimo(int n){
    bool primo=true;
        for (int i = 2; i <= (int) Math.Sqrt(n); i++){
            if(n % i == 0){
                primo = false;
            }
        }
    if (n==1)
    {
        primo=false;
    }
    return primo;
}

for (int j = 1; j <= n; j++)
{
    if (EsPrimo(j))
    {
        Console.WriteLine(j + " es primo");
    }
    else{
        Console.WriteLine(j + " NO es primo");
    }
    
}