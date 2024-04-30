using ejercicio7;
using ejercicio8;
DateTime date1 = new DateTime(2002,03,04);
DateTime date2 = new DateTime(2004,03,04);

Persona p1 = new Persona();
Persona p2 = new Persona();
Persona p3 = new Persona();

p1[0] = "Julian";
p1[1] = 'H';
p1[2] = 44045058;
p1[3] = date1;

p2[0] = "Maria";
p2[1] = 'M';
p2[2] = 5000000;
p2[3] = date2;

p3[0] = "Martina";
p3[1] = 'M';
p3[2] = 5504200;
p3[3] = date2;

ListaDePersonas listaDePersonas = new ListaDePersonas();
listaDePersonas.Agregar(p1);
listaDePersonas.Agregar(p2);
listaDePersonas.Agregar(p3);

Persona? buscada = listaDePersonas[44045058];
if (buscada != null){
    for (int i = 0; i < 5; i++){
        Console.WriteLine(buscada[i]);
    } 
}
else
    Console.WriteLine("es null");

Console.WriteLine("-----------------");

List<String> nombres = listaDePersonas['M']; 
if (nombres != null){
    foreach (String st in nombres){
        Console.WriteLine(st);
    } 
}


