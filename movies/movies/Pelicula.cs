using System;
namespace movies
{
	[Serializable]
    public class Pelicula
    {
		public string Nombre;
		public Director Director;
		public string Fecha;
		public string Descripcion;
		public int Presupuesto;
		public Estudio Estudio;
		public Pelicula(string nombre, Director director, string fecha, string descripcion, int presupuesto, Estudio estudio)
        {
			Nombre = nombre;
			Director = director;
			Fecha = fecha;
			Descripcion = descripcion;
			Presupuesto = presupuesto;
			Estudio = estudio;
        }
    }

	[Serializable]
    public class Persona
	{
		public string Nombre;
		public string Apellido;
		public string Nacimiento;
		public string Biografia;

		public Persona( string nombre, string apellido, string nacimiento, string biografia)
		{
			Nombre = nombre;
			Apellido = apellido;
			Nacimiento = nacimiento;
			Biografia = biografia;
		}
	}

	[Serializable]
	public class Actor : Persona
	{
		public Actor(string nombre, string apellido, string nacimiento, string biografia) : base(nombre, apellido, nacimiento, biografia)
        {

        }
	}
	[Serializable]
	public class Director : Persona
    {
        public Director(string nombre, string apellido, string nacimiento, string biografia) : base(nombre, apellido, nacimiento, biografia)
        {
            
        }
    }
	[Serializable]
	public class Productor : Persona
    {
        public Productor(string nombre, string apellido, string nacimiento, string biografia) : base(nombre, apellido, nacimiento, biografia)
        {

        }
    }
    
	[Serializable]
	public class PeliculaActor
	{
		public Pelicula Pelicula;
		public Actor Actor;
		public PeliculaActor( Pelicula pelicula, Actor actor)
		{
			Pelicula = pelicula;
			Actor = actor;
		}
	}

	[Serializable]
	public class PeliculaProductor
    {
		public Pelicula Pelicula;
		public Productor Productor;
		public PeliculaProductor(Pelicula pelicula, Productor productor)
        {
            Pelicula = pelicula;
			Productor = productor;
        }
    }

	[Serializable]
	public class Estudio
	{
		public string Nombre;
		public string Direccion;
		public string Fecha;

		public Estudio(string nombre, string direccion, string fecha)
		{
			Nombre = nombre;
			Direccion = direccion;
			Fecha = fecha;
		}
	}

	[Serializable]
	public class Critica
	{
		public Pelicula Pelicula;
		public string mensaje;
		public Persona Persona;

		public Critica(Pelicula pelicula, string m, Persona p)
		{
			Pelicula = pelicula;
			mensaje = m;
			Persona = p;
		}


	}

}
