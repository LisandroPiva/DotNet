Auto a = new Auto();
a.Marca = "Ford";
Console.WriteLine(a.Marca);
class Auto {
    private string marca;
    public string Marca {
        set {
            Marca = value;
        }
        get{
            return marca;
            
        }
    }
}