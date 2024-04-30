class A {
    private static int a; //variable estatica 
    private static readonly int b; //variable estatica de solo lectura 
    A() { } //constructor de instancia
    public A(int i) : this() { } //constructor de instancia que utiliza el anterior
    static A() => b = 2; //constructor estatico que asigna 2 a b
    int c; //variable de instancia
    public static void A1() => a = 1; //metodo estatico que asigna 1 a a
    public int A1(int a) => A.a  + a;  //metodo de instancia que suma A.a con a(parametro)
    public static int A2; //variable estatica  
    static int A3 => 3; //propiedad estatica de solo lectura 
    private int A4() => 4; //metodo de instancia de solo lectura 
    public int A5 { get => 5; } //propiedad de instancia de solo lectura
    int A6 { set => c = value; } //propiedad de instancia de solo escritura
    public int A7 { get; set; } //propiedad (autoimplementada) de instancia de escritura y lectura
    public int A8 { get; } = 8;//propiedad de instancia de lectura 
    public int this[int i] => i; //indexador 
}