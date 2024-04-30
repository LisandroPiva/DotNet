using System.Linq.Expressions;

Console.WriteLine("Ingresa una cadena: ");
String? st = Console.ReadLine();

String[]v = st.Split(" ");
foreach (string elem in v) {
    Console.WriteLine(elem);
}