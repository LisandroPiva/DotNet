namespace Automotores;

public class Auto {
    string? _marca;
    int _modelo;

    public Auto(string? marca, int modelo){
        _marca = marca;
        _modelo = modelo;
    }

    public Auto(string? marca){
        _marca = marca;
        _modelo = 2022;
    }

    public String GetDescripcion(){
        return "Auto " + _marca + " " + _modelo;
    }
}
