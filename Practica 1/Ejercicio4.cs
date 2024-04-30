Console.WriteLine("Ingresa la wea: ");
string str = Console.ReadLine();
if (string.IsNullOrWhiteSpace(str)) {
    Console.WriteLine("Hola Mundo");
} 
else{
    Console.WriteLine("Hola " + str);
}
