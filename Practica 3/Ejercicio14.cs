using System.Collections;

Console.Write("Ingrese mensaje a cifrar: "); //OBTENGO MENSAJE A CIFRAR
string? mensaje = Console.ReadLine();
char[] arrayMensaje = mensaje.ToCharArray(); 

Console.Write("Ingrese clave: ");   //OBTENGO CLAVE PARA CIFRAR
string? stClave = Console.ReadLine(); 
char[] chClave = stClave.ToCharArray(); //CONVIERTO CLAVE A UN ARREGLO DE CHARS
int[] arrayClave = new int[chClave.Length]; //DECLARO UN ARRAY DE ENTEROS PARA OBTENER LOS VALORES
int[] mensajeCodificado = new int[arrayMensaje.Length];
int clave;


Queue<int> queue = new Queue<int>(); //DECLAR LA QUEUE DONDE VOY A CARGAR LA CLAVE

for(int i = 0; i < chClave.Length; i++){    //Convertir char a int
    arrayClave[i] = Convert.ToInt32(chClave[i] - '0');
}

foreach(int elem in arrayClave){ //Cargo la queue
    queue.Enqueue(elem);
}

//Codigo cifrado
for(int i = 0; i<arrayMensaje.Length; i++){
    
    switch (arrayMensaje[i]) {
        case  >= 'A' and <= 'N': 
            clave=queue.Dequeue();
            mensajeCodificado[i]=arrayMensaje[i] - 64 + clave;
            if (mensajeCodificado[i] > 28) {
                mensajeCodificado[i] = mensajeCodificado[i] % 28;
            }
            queue.Enqueue(clave);
            break;
        case >= 'O' and <= 'Z':
            clave=queue.Dequeue();
            mensajeCodificado[i]=arrayMensaje[i] - 63 + clave;
            if (mensajeCodificado[i] > 28) {
                mensajeCodificado[i] = mensajeCodificado[i] % 28;
            }
            queue.Enqueue(clave);
            break;
        case 'Ñ':
            clave=queue.Dequeue();
            mensajeCodificado[i]= 15 + clave;
            if (mensajeCodificado[i] > 28)
            {
                mensajeCodificado[i] = mensajeCodificado[i] % 28;
            }
            queue.Enqueue(clave);
            break;
            
        case ' ':
            clave=queue.Dequeue();
            mensajeCodificado[i]= (28 + clave) % 28;
            queue.Enqueue(clave);
            break;
        default: break;
    } 
}

//Codigo descifrado
foreach(int ch in mensajeCodificado){
    Console.WriteLine(ch);
}


for (int i = 0; i < mensajeCodificado.Length; i++){
    switch (mensajeCodificado[i]) {
        case  >= 1 and <= 14:
            mensajeCodificado[i] += 64;
            arrayMensaje[i] = (char)mensajeCodificado[i];
        break;

        case 15:
            arrayMensaje[i] = 'Ñ';
        break;

        case >= 16 and <= 27:
            mensajeCodificado[i] += 63;
            arrayMensaje[i] = (char)mensajeCodificado[i];
        break;
        
        case 28:
            arrayMensaje[i] = ' ';
        break;
    } 
}

foreach(char ch in arrayMensaje){
    Console.Write(ch);
}
