namespace ejercicio4;

public class Hora {
    int _hora;
    int _minutos;
    int _segundos;
    public Hora(int hora, int minutos, int segundos){
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

    public void Imprimir(){
        Console.WriteLine(_hora + " horas, " + _minutos + " minutos y " + _segundos + " segundos");
    }

}
