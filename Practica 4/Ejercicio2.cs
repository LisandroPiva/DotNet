List<Persona> personas = new List<Persona>();
string nombreDeArchivo = "datos.txt";

try {
    Console.SetIn(new StreamReader(nombreDeArchivo));
    string linea;
    while ((linea = Console.ReadLine()) != null) {
        string[] datos = linea.Split(',');
        if (datos.Length == 3) {
            Persona p = new Persona(datos[0].Trim(),int.Parse(datos[1]),int.Parse(datos[2]));
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

Console.WriteLine("Nro) Nombre  Edad  DNI.");
for(int i = 0; i < personas.Count; i++){
    Console.WriteLine((i+1)+ ")" + "  " + personas[i].imprimir());
}

public class Persona {
    private string nombre;
    private int edad;
    private int dni;

    public Persona(string nombre, int edad, int dni){
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;
    }

    public String imprimir(){
        return nombre + " " + edad + " " + dni;
    }
}