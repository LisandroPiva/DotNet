using System.Text;

namespace ejercicio5;


public class Hora {
    int _hora;
    int _minutos;
    double _segundos;
    public Hora(int hora, int minutos, double segundos){
        if ((hora >= 0) & (hora <= 23)) {
            _hora = hora;
        }
        if ((minutos >= 0) & (minutos <= 60)) {
            _minutos = minutos;
        }
        if ((segundos >= 0) & (segundos <= 60)) {
            _segundos = segundos;
        }
    }

    public Hora(double numero){
       // Extraer la parte entera como horas
        _hora = (int)numero;
        
        // Extraer los minutos
        double minutosDecimal = (numero - _hora) * 60;
        _minutos = (int)minutosDecimal;
        
        // Extraer los segundos
        double segundosDecimal = (minutosDecimal - _minutos) * 60;
        _segundos = Math.Round(segundosDecimal, 3); // Redondear a 3 decimales
        if (_segundos == 60) { _segundos = 0; _minutos++; }
    }

    public void Imprimir(){
        Console.WriteLine(_hora + " horas, " + _minutos + " minutos y " + _segundos + " segundos");
    }

}
