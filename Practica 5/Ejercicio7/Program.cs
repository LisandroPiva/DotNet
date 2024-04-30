using ejercicio7;

DateTime date = new DateTime(2002,03,04);
Persona p = new Persona();

p[0] = "Julian";
p[1] = 'H';
p[2] = 44045058;
p[3] = date;

for (int i = 0; i < 5; i++){
    Console.WriteLine(p[i]);
}
