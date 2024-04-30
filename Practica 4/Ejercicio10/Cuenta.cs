namespace ejercicio10;

public class Cuenta {
    double _monto;
    int _titularDNI;
    string? _titularNombre;

    public Cuenta(){}

    public Cuenta(int dni){
        _titularDNI = dni;
    }

    public Cuenta(string nombre){
        _titularNombre = nombre;
    }

    public Cuenta(string nombre, int dni) :this(nombre){
        _titularDNI = dni;
    }

    public String tieneNombre() {
        if (_titularNombre != null) {
            return _titularNombre;
        }
        else{
            return "No especificado";
        }
    } 
    public String tieneDNI(){
        if (_titularDNI != 0){
            return _titularDNI.ToString();
        }
        else {
            return "No especificado";
        }
    }

    public void Imprimir(){
        Console.WriteLine("Nombre: "+this.tieneNombre()+", DNI: "+this.tieneDNI()+", Monto: "+_monto);
    }

    public void Depositar(double monto){
        _monto += monto;
    }

    public void Extraer(double monto){
        if (_monto - monto >= 0){
            _monto -= monto;
        }
        else{
            Console.WriteLine("Operacion cancelada, monto insuficiente");
        }
    }


}
