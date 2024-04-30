Console.WriteLine("Ingrese numero");
string str = Console.ReadLine();
int num = int.Parse(str);

for (int i = num; i > 0; i--){
    if (num % i == 0) {  
        Console.WriteLine(i);
    }
}