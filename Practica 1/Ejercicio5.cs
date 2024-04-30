/*Console.WriteLine("Ingresa la wea: ");
string str = Console.ReadLine();
if (string.IsNullOrWhiteSpace(str)) {
    Console.WriteLine("¡Buen dia mundo!");
} 
else{
    if (str == "Juan"){
        Console.WriteLine("¡Hola Amigo!");
    }
    else if (str == "Maria") {
        Console.WriteLine("Buen dia señora");
    }
    else if (str == "Alberto"){
        Console.WriteLine("Hola Alberto");
    }
    else {
        Console.WriteLine("Buen dia "+ str);
    }
}
*/
Console.WriteLine("Ingresa la wea: ");
string str = Console.ReadLine();
switch (str){
    case " ": //no pude utilizar string.IsNullOrWhiteSpace(str)
        Console.WriteLine("¡Buen dia mundo!");
        break;
    case "Juan":
        Console.WriteLine("¡Hola Amigo!");        
        break;

    case "Maria":
        Console.WriteLine("Buen dia señora");
        break;

    case "Alberto":
        Console.WriteLine("Hola Alberto");
        break;

    default:
        Console.WriteLine("Buen dia "+ str);
        break;
}
