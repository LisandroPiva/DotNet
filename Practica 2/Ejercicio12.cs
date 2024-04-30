
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

for (int i = 11; i >= 0; i--){
    Console.WriteLine((Meses)i);
}



Console.WriteLine("Ingrese un texto:");
String rta = Console.ReadLine();
bool esMes = false; 

for (Meses m = Meses.enero; m <= Meses.diciembre; m++){

    if (rta==m.ToString()) esMes=true; 
}
if (esMes){
    Console.WriteLine("Corresponde al nombre de un mes");
    }
else {
    Console.WriteLine("NO corresponde al nombre de un mes");
}



enum Meses {
    enero, febrero,marzo, abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre
}



