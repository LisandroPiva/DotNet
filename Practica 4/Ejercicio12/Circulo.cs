namespace Figuras;

public class Circulo
{
    double _radio;

    public Circulo (double radio){
        _radio = radio;
    }

    public double GetArea() => Math.PI * (_radio * _radio);
}
