List<Persona> personas = new List<Persona>();
string nombreDeArchivo = "datos.txt";

try {
    // Redirigimos la entrada estándar hacia el archivo
    Console.SetIn(new StreamReader(nombreDeArchivo));

    // Leemos los datos desde el archivo como si estuviéramos leyendo desde la consola
    string linea;
    while ((linea = Console.ReadLine()) != null) {
        // Procesamos la línea para obtener los datos de la persona
        string[] datos = linea.Split(',');
        if (datos.Length == 3) {
            // Creamos una nueva instancia de la clase Persona y la agregamos a la lista
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



Persona masViejo = personas[0];
for (int i = 0; i < personas.Count; i++){
    if (personas[i].esMayorQue(masViejo)){
        masViejo = personas[i];
    }
}

Console.WriteLine("La persona mas vieja es: " + masViejo.imprimir());


public class Persona {
    private string nombre;
    private int edad;
    private int dni;

    public Persona(string nombre,int dni,int edad){
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;
    }

    public String imprimir(){
        return nombre + " " + edad + " " + dni;
    }

    public Boolean esMayorQue (Persona p){
        return this.edad > p.edad;

    }
}