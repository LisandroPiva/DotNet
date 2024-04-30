namespace Figuras;

public class Rectangulo
{
    double _base;
    double _altura;
    
    public Rectangulo(double basee, double altura){
        _altura = altura;
        _base = basee;
    }

    public double GetArea() => _base * _altura;
}
