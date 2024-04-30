Console.WriteLine("Ingresa la cadena pa: ");
string st = Console.ReadLine();
string[] v = st.Split(" ");
string sec1 = v[0];
string sec2 = v[1];
bool simetricos = true;

if (sec1.Length == sec2.Length) {
    for (int i = 0; i < sec1.Length - 1; i++){
        if (!sec1[i].Equals(sec2[sec2.Length - 1 - i])){
            simetricos = false;  
            break;
        }
    }
}    
else
{
    simetricos = false;
}

if (simetricos == false){
    Console.WriteLine("NO son simetricos");
} 
else{
    Console.WriteLine("Son simetricos");

}