int num2 = int.Parse(args[1]);
Swap(ref num,ref num2);
Console.WriteLine(num + " " + num2);
void Swap(ref int num1, ref int num2){
    int aux = num1;
    num1 = num2;
    num2 = aux;
}