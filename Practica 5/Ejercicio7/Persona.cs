namespace ejercicio7;

public class Persona{
    private string Nombre {get; set;}
    private char Sexo {get; set;}
    private int Dni {get; set;}
    private DateTime FechaNacimiento {get; set;}
    private int Edad => DateTime.Today.Year - FechaNacimiento.Year;

    public object? this[int i]{
        get {
            switch (i){
                case 0:
                    return Nombre;
                case 1:
                    return Sexo;
                case 2:
                    return Dni;
                case 3: 
                    return FechaNacimiento;
                case 4: 
                    return Edad;
                default:
                    Console.WriteLine("Valor incorrecto");
                    return null;
            }
        }
        set {
            switch (i){
                case 0:
                    Nombre = (string)value;
                    break;
                case 1:
                    Sexo = (char)value;
                    break;
                case 2:
                    Dni = (int)value;
                    break;
                case 3: 
                    FechaNacimiento = (DateTime)value;
                    break;
                
                default:
                    Console.WriteLine("Valor incorrecto");
                    break;
            }
        }
    }


}
