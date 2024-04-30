char aper = '(';
Stack<char> pila = new Stack<char>();
int i =0;
bool cumple=true;

string? st = Console.ReadLine();
char[]? cadena = st.ToCharArray();

while ((i < cadena.Length)&&(cumple)){
   if(cadena[i].Equals(aper)){
      pila.Push(cadena[i]);
   }
   else{
      if(pila.Count != 0){
         pila.Pop();
      }
      else{
         cumple=false;
      }
   }
   i++;
}

Console.WriteLine(cumple);