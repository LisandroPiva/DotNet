Console.Write("Ingresa numero: ");
string? str = Console.ReadLine();
double suma = 0;
double num;
while (str != "") {
    try{
        num = double.Parse(str);
        suma += num;
        Console.WriteLine("TOTAL = "+suma);
        
        Console.Write("Ingresa numero: ");
        str = Console.ReadLine();
        num = double.Parse(str);
    }
    catch (FormatException) {
        Console.WriteLine("Error: La entrada no es un número válido.");
        Console.Write("Ingresa numero: ");
        str = Console.ReadLine();
    }

}
