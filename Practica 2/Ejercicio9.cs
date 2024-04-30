using System.Text;

string st = "";
DateTime ini = DateTime.Now;
for (int i = 0; i < 10000; i++){
    st = st + " " + i;
}
DateTime end = DateTime.Now;
TimeSpan time = end - ini;

Console.WriteLine("Tiempo String: " + time.TotalSeconds);


StringBuilder stb = new StringBuilder();
ini = DateTime.Now;
for (int i = 0; i < 10000; i++){
    stb.Append(" ").Append(i);
}
end = DateTime.Now;
time = end - ini;

Console.WriteLine("Tiempo String Builder: " +  time.TotalSeconds);


