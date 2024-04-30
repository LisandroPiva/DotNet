namespace ejercicio6;

public class Ecuacion2 {
    double _a;
    double _b;
    double _c;

    public Ecuacion2 (double a, double b, double c){
        _a = a;
        _b = b;
        _c = c;
    }

    public double GetDiscriminante(){
        return (_b * _b) - 4 * _a * _c;
    }

    public double GetCantidadDeRaices(){
        if (this.GetDiscriminante() <= 0){ return 0;}
        else if (this.GetDiscriminante() == 0) { return 1;}
        else return 2;
    }

    public void ImprimirRaices(){
        if (this.GetCantidadDeRaices() == 1){
            Console.WriteLine(-_b + Math.Sqrt(this.GetDiscriminante()) / (2 * _a));
        }
        else if (this.GetCantidadDeRaices() == 2){
            Console.WriteLine("Raiz 1 --->"+ (-_b + Math.Sqrt(this.GetDiscriminante()) / (2 * _a)));
            Console.WriteLine("Raiz 2 --->"+ (-_b - Math.Sqrt(this.GetDiscriminante()) / (2 * _a)));
        }
        else {
            Console.WriteLine("No tiene ecuaciones reales");
        }
    }
}
