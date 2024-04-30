Stack<int> pila = new Stack<int>();
string? st = Console.ReadLine();
#pragma warning disable CS8604 // Posible argumento de referencia nulo
int num = int.Parse(st);
#pragma warning restore CS8604 // Posible argumento de referencia nulo

while (num >= 2){
   pila.Push(num % 2);
   num = num/2;
}
if(num  == 1){
   pila.Push(num);
}

foreach (int item in pila)
{
   Console.Write(item);
}
Console.WriteLine();