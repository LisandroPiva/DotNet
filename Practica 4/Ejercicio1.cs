List<Persona> personas = new List<Persona>();
string nombreDeArchivo = "datos.txt";

try {
    Console.SetIn(new StreamReader(nombreDeArchivo));

    string linea;
    while ((linea = Console.ReadLine()) != null) {
        string[] datos = linea.Split(',');
        if (datos.Length == 3) {
            Persona p = new Persona();
            p.nombre = datos[0].Trim();
            p.dni = int.Parse(datos[1]);
            p.edad = int.Parse(datos[2]);
            personas.Add(p);
        }
        else
        {
            Console.WriteLine("Error: El formato de entrada es incorrecto.");
        }
    }
}
catch (Exception ex) {
    Console.WriteLine("Error al leer el archivo: " + ex.Message);
}


Console.WriteLine("Nro) Nombre   Edad   DNI.");
for(int i = 0; i < personas.Count; i++){
    Console.WriteLine((i+1)+")  "+" "+personas[i].nombre + "   " + personas[i].edad + " " + personas[i].dni);
}



public class Persona {
    public string nombre;
    public int edad;
    public int dni;
}