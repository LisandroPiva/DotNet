using ejercicio7;

namespace ejercicio8;


public class ListaDePersonas{
    private List<Persona> lista;

    public ListaDePersonas(){
        lista = new List<Persona>();
    }
    public void Agregar(Persona p){
        lista.Add(p);
    }

    public Persona? this[int dni]{
        get{
            foreach (Persona p in lista){
                if ((int)p[2] == dni){
                    return p;
                }
            }
            return null;
        }
    }

    public List<string> this[char c]{
        get{
            List<string> nombres = new List<string>();
            foreach (Persona p in lista){
                if (p[0].ToString().FirstOrDefault().Equals(c)){
                    nombres.Add(p[0].ToString());
                 }
            }
            
            return nombres;

        }
    }

}
}
