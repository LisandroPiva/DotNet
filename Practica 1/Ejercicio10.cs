Console.WriteLine("Ingrese 17 o 29");
string str = Console.ReadLine();
int num = int.Parse(str);
int mul = 0;
if (num != 17 || num != 29){
    for (int i = 1; i <= 1000; i++){
        mul = num * i;
        Console.WriteLine(mul);
    }
}