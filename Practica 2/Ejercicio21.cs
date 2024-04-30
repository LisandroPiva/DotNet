void imprimir(params object[] vector){
    foreach (object obj in vector)
    {
        Console.Write(obj.ToString() + " ");
    }
    Console.WriteLine();
}

imprimir(1, "casa", 'a', 3.4);