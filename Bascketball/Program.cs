using Bascketball.src.interfaces;
using Bascketball.src.clases;



Console.WriteLine("Ingresa la cantidad de jugadores");
int jugadoresc= Convert.ToInt32(Console.ReadLine());
int contador=1;
List<IJugador> jugadoresdisponibles = new List<IJugador>();
while(jugadoresc>=contador){
Console.WriteLine("Ingrese el nombre del jugador");
string nombrejugador= Console.ReadLine();
IJugador jugador = new Jugador(nombrejugador, new Random().Next(1, 11));
jugadoresdisponibles.Add(jugador);
contador++;
};

Console.WriteLine("Ingrese el nombre del equipo #1");
string nom1= Console.ReadLine();
Equipo equipo1 = new Equipo(nom1);
Console.WriteLine("Ingresa el nombre del equipo #2");
string nom2= Console.ReadLine();
Equipo equipo2 = new Equipo(nom2);
Random random = new Random();

Console.WriteLine(jugadoresdisponibles.Count);


for (int i = 0; i < jugadoresc / 2; i++){
    IJugador jugadorsele = jugadoresdisponibles[random.Next(jugadoresdisponibles.Count)];
    equipo1.agregaraequipo(jugadorsele);
    jugadoresdisponibles.Remove(jugadorsele);
    jugadorsele = jugadoresdisponibles[random.Next(jugadoresdisponibles.Count)];
    equipo2.agregaraequipo(jugadorsele);
    jugadoresdisponibles.Remove(jugadorsele);
    }
    equipo1.ListadeJugadores();
    equipo2.ListadeJugadores();

    int rendimientoEquipo1 = equipo1.TotalRendimiento();
    int rendimientoEquipo2 = equipo2.TotalRendimiento();

    if (rendimientoEquipo1 > rendimientoEquipo2){
            Console.WriteLine(equipo1.nameequipo() + " Ha Ganado");
        }
    else if (rendimientoEquipo2 > rendimientoEquipo1){
            Console.WriteLine(equipo2.nameequipo() + " Ha Ganado");
        }
    else{
            Console.WriteLine("Empate");
        }