namespace Bascketball.src.clases;
using Bascketball.src.interfaces;

public class Jugador:IJugador{

    private string nombres {get; set;}
    private int rendimiento{get; set;}

    public Jugador(string nombres, int rendimiento){
        this.nombres = nombres;
        this.rendimiento = rendimiento;
    }
    public string nombrejugador(){
        return this.nombres;
    }

    public int rendimientojugador(){
        return this.rendimiento;
    }
    }

    public class Equipo{
        private string equiponombre;
        private List<IJugador> jugadores;

    public Equipo(string equiponombre){
        this.equiponombre = equiponombre;
        this.jugadores = new List<IJugador>();
    }

    public void agregaraequipo(IJugador jugador){
        jugadores.Add(jugador);
    }

    public string nameequipo(){
        return this.equiponombre;
    }

    public int TotalRendimiento(){
        int contador=0;
        for(int i=0; i< jugadores.Count; i++){
            contador+=jugadores[i].rendimientojugador();
        }
        return contador;
    }

    public void ListadeJugadores(){
        Console.WriteLine("Jugadores del equipo: " + this.equiponombre);

        for(int i=0; i < jugadores.Count; i++){
            IJugador jugador= jugadores[i];
            Console.WriteLine(jugador.nombrejugador() + " Su Rendimiento es: " +jugador.rendimientojugador());
        }
    }
    }

