//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

//string[] Juegos =
//{
//    "Carcasone",
//    "Bang",
//    "Jungle Speed",
//    "Los Colhones de Catan",
//    "Zoombies"
//};

//IEnumerable<string> consulta = from j in Juegos
//                               where j.StartsWith("J")
//                               orderby j ascending
//                               select j;

//foreach (string elementos in consulta)
//{
//    Console.WriteLine(elementos);
//}

//Console.WriteLine("Distinct");
//string[] fruits = { "Apple", "Banana", "Apple", "Plum", "Grapes", "Plum" };

//IEnumerable<string> result = fruits.Distinct();  //LINQ distinct function

//foreach (var item in result)

//{

//    Console.WriteLine(item);

//}


IEnumerable<Juego> juegos = new List<Juego>()
{
    new Juego{Id=1, Nombre="Carcasone", MinJugadores=2, MaxJugadores=8},
    new Juego{Id=2, Nombre="Colonos de Catan", MinJugadores=2, MaxJugadores=7},
    new Juego{Id=3, Nombre="Jungle Speed", MinJugadores=1, MaxJugadores=4},
    new Juego{Id=4, Nombre="Bang", MinJugadores=2, MaxJugadores=100},
    new Juego{Id=5, Nombre="Zoombies", MinJugadores=3, MaxJugadores=10},
};

IEnumerable<Consola> consolas= new List<Consola>()
{
    new Consola{Id=1, Nombre="Nintendo", IdJuego=5},
    new Consola{Id=2, Nombre="Sega", IdJuego=1 },
    new Consola{Id=3, Nombre="PlayStation", IdJuego=3},
    new Consola{Id=4, Nombre="Atari", IdJuego=2},
};

//List<Juego> Consulta = (from j in juegos where j.MaxJugadores > 4 orderby j.Nombre select j).ToList();

//foreach (Juego juego in Consulta)
//{
//    Console.WriteLine("{0} ({1}) de {2} a {3} jugadores", juego.Nombre, juego.Id, juego.MinJugadores, juego.MaxJugadores);
//}

//List<Juego> Consulta1 = (from j in juegos select j).ToList(); //Se usa ToList cuando el resultado que tiene que arrojar una lista porque eso indicamos en el tipo de resultado que debe salir

//foreach (Juego juego in Consulta1)
//{
//    Console.WriteLine("{0} ({1}) de {2} a {3} jugadores", juego.Nombre, juego.Id, juego.MinJugadores, juego.MaxJugadores);
//}

//var Consulta2 = from j in juegos select j.Nombre;

//foreach (var juego in Consulta2)
//{
//    Console.WriteLine(juego);
//}


// esto se conoce como tipo implicito porque creo una clase para instanciar. Esto ocurre cuando quiero usar de dos variables en adelante
//Console.WriteLine("Tipo Implicito");
//var Consulta3 = from j in juegos
//                select new Juego
//                {
//                    Nombre = j.Nombre,
//                    Id = j.Id
//                };

//foreach (var juego in Consulta3)
//{
//    Console.WriteLine("Nombre: {0}, Id: {1}", juego.Nombre, juego.Id);
//}

//Console.WriteLine("Tipo Anonimo");
//var Consulta4 = from j in juegos
//                select new
//                {
//                    Nombre = j.Nombre,
//                    Id = j.Id
//                };

//foreach (var juego in Consulta4)
//{
//    Console.WriteLine("Nombre: {0}, Id: {1}", juego.Nombre, juego.Id);
//}

//Console.WriteLine("Filtrar con Where");
//var Consulta5 = from j in juegos
//                where j.MinJugadores > 2
//                select j;

//foreach (var juego in Consulta5)
//{
//    Console.WriteLine("Nombre: {0}, Id: {1}, MinJug: {2}, MaxJug: {3}", juego.Nombre, juego.Id, juego.MinJugadores, juego.MaxJugadores);
//}

//Console.WriteLine("Filtrar con Where usar &&");
//var Consulta6 = from j in juegos
//                where j.MinJugadores > 2 && j.MaxJugadores < 9
//                select j;

//foreach (var juego in Consulta6)
//{
//    Console.WriteLine("Nombre: {0}, Id: {1}, MinJug: {2}, MaxJug: {3}", juego.Nombre, juego.Id, juego.MinJugadores, juego.MaxJugadores);
//}


//Console.WriteLine("Multiseleccion");
//var Consulta7 = from j in juegos
//                from c in consolas
//                where j.Id == c.IdJuego
//                select new
//                {
//                    NombreJuego = j.Nombre,
//                    NombreConsola = c.Nombre,
//                    MinJugadores = j.MinJugadores,
//                    MaxJugadores = j.MaxJugadores

//                };

//foreach (var juego in Consulta7)
//{
//    Console.WriteLine("Nombre: {0}, Consola: {1}, MinJug: {2}, MaxJug: {3}", juego.NombreJuego, juego.NombreConsola, juego.MinJugadores, juego.MaxJugadores);
//}

//Console.WriteLine("Join"); //con join hay que usar on y equals
//var Consulta7 = from j in juegos
//                join c in consolas on j.Id equals c.IdJuego
//                select new
//                {
//                    NombreJuego = j.Nombre,
//                    NombreConsola = c.Nombre,
//                    MinJugadores = j.MinJugadores,
//                    MaxJugadores = j.MaxJugadores

//                };

//foreach (var juego in Consulta7)
//{
//    Console.WriteLine("Nombre: {0}, Consola: {1}, MinJug: {2}, MaxJug: {3}", juego.NombreJuego, juego.NombreConsola, juego.MinJugadores, juego.MaxJugadores);
//}

//Console.WriteLine("Take");
//var Consulta8 = (from j in juegos select j).Take(2);
//foreach (var juego in Consulta8)
//{
//    Console.WriteLine("Nombre: {0}, Id: {1}, MinJug: {2}, MaxJug: {3}", juego.Nombre, juego.Id, juego.MinJugadores, juego.MaxJugadores);
//}

//Console.WriteLine("Skip");
//var Consulta9 = (from j in juegos select j).Skip(2);
//foreach (var juego in Consulta8)
//{
//    Console.WriteLine("Nombre: {0}, Id: {1}, MinJug: {2}, MaxJug: {3}", juego.Nombre, juego.Id, juego.MinJugadores, juego.MaxJugadores);
//}

//Console.WriteLine("Lambda");
//var consulta10 = juegos.Skip(2);
//foreach (var juego in consulta10)
//{
//    Console.WriteLine("Nombre: {0}, Id: {1}, MinJug: {2}, MaxJug: {3}", juego.Nombre, juego.Id, juego.MinJugadores, juego.MaxJugadores);
//}

//var consulta11 = juegos.Where(j => j.MaxJugadores > 4);
//foreach (var juego in consulta11)
//{
//    Console.WriteLine("Nombre: {0}, Id: {1}, MinJug: {2}, MaxJug: {3}", juego.Nombre, juego.Id, juego.MinJugadores, juego.MaxJugadores);
//}

//Console.WriteLine("Count");
//var Consulta12 = juegos.Count();
//Console.WriteLine(Consulta12);


//Console.WriteLine("Distinct().Count()"); // te cuanta los valores que no son repetidos
//var Consulta13 = juegos.Distinct().Count();
//Console.WriteLine(Consulta13);

//Console.WriteLine("Consulta");
//var Consulta14 = from j in juegos select j.Nombre;
//foreach (var juego in Consulta14)
//{
//    Console.WriteLine("Nombre: {0}", juego);
//}

//Console.WriteLine("Lambda");
//var consultaLambda = juegos.Select(j => j.Nombre);
//foreach (var juego in consultaLambda)
//{
//    Console.WriteLine("Nombre: {0}", juego);
//}

//Console.WriteLine("Max");
//int Consulta15 = (from j in juegos select j.Id).Max();
//Console.WriteLine("El maximo Id de Juegos es: {0}", Consulta15);

//var conLambda1 = juegos.Select(j => j.Id).Max();
//Console.WriteLine("El maximo Id de Juegos es: {0}", conLambda1);

//var conLambda2 = juegos.Max(j => j.Id);
//Console.WriteLine("El maximo Id de Juegos es: {0}", conLambda1);


//Console.WriteLine("Min");
//int Consulta16 = (from j in juegos select j.Id).Min();
//Console.WriteLine("El minimo Id de Juegos es: {0}", Consulta16);

//var conLambda3 = juegos.Select(j => j.Id).Min();
//Console.WriteLine("El minimo Id de Juegos es: {0}", conLambda3);

//var conLambda4 = juegos.Min(j => j.Id);
//Console.WriteLine("El minimo Id de Juegos es: {0}", conLambda4);

Console.WriteLine("Promedio");

var Consulta17 = (from j in juegos select j.Id).Average();
Console.WriteLine("El promedio Id de Juegos es: {0}", Consulta17);

var conLambda5 = juegos.Average(j => j.Id);
Console.WriteLine("El promedio Id de Juegos es: {0}", conLambda5);

Console.WriteLine("OrderBy");

var consulta18 = from j in juegos orderby j.Nombre select j.Nombre;
var conLambda6 = juegos.OrderBy(j => j.Nombre);

foreach (var juego in conLambda6)
{
    Console.WriteLine("Lambda... Nombre: {0}", juego);
}

foreach (var juego in consulta18)
{
    Console.WriteLine("Tradicional... Nombre: {0}", juego);
}

Console.WriteLine("OrderByDescending");

var consulta19 = from j in juegos orderby j.Nombre descending select j.Nombre;
var conLambda7 = juegos.OrderByDescending(j => j.Nombre);

foreach (var juego in conLambda7)
{
    Console.WriteLine("Lambda... Nombre: {0}", juego.Nombre);
}

foreach (var juego in consulta19)
{
    Console.WriteLine("Tradicional... Nombre: {0}", juego);
}


public class Juego
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public int MinJugadores { get; set; }
    public int MaxJugadores { get; set; }
}

public class Consola
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public int IdJuego { get; set; }
}





