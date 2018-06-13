using System;
using System.Threading;
using Gtk;

namespace movies
{
    public partial class Window : Gtk.Window
    {
		BD bD;
		public Window( BD bd) :
                base(Gtk.WindowType.Toplevel)
        {
			bD = bd;
            this.Build();
            
        }

		protected void OnPeliculasClicked(object sender, EventArgs e)
		{
			string t = entrada.Text;
            string s = "";
            textview1.Buffer.Text = "";
            textview1.Editable = false;

			s += "Peliculas \n---------------------------------------\n";
            foreach (Pelicula p in bD.peliculas)
            {
                if (p.Nombre.Contains(t) || p.Descripcion.Contains(t))
                {
                    s += "Nombre: " + p.Nombre + "\nDirector : " + p.Director.Nombre + " " + p.Director.Apellido +
                         "\nFecha: " + p.Fecha
                        + "\nDescripcion: " + p.Descripcion +
                        "\nPresupuesto: " + p.Presupuesto.ToString() + "\nEstudio: " + p.Estudio.Nombre + "\n";
					s += "Acotores: \n";
					foreach (PeliculaActor r in bD.PeliculaActors)
                    {
                        
						if (p == r.Pelicula)
                        {
							s += r.Actor.Nombre + " " + r.Actor.Apellido + "\n";
                        }
                    }
					s += "Productores: \n";
					foreach (PeliculaProductor r in bD.PeliculaProductors)
                    {
                        
						if (p == r.Pelicula)
                        {
							s += r.Productor.Nombre + " " + r.Productor.Apellido + "\n";
                        }
                    }
                    
                    //Se muestras tambien las criticas
                    
                    s += "Criticas: \n";
                    foreach (Critica r in bD.criticas)
                    {

                        if (p == r.Pelicula)
                        {
                            s += r.Persona.Nombre + " " + r.Persona.Apellido + "\nCritica: " + r.mensaje + "\n";
                        }
                    }



                }


            }
            textview1.Buffer.Text = s;

			
		}

		protected void OnActoresClicked(object sender, EventArgs e)
		{
			string t = entrada.Text;
            string s = "";
            textview1.Buffer.Text = "";
            textview1.Editable = false;
			s += "Actores \n---------------------------------------\n";
            foreach (Actor p in bD.actores)
            {
                if (p.Nombre.Contains(t) || p.Apellido.Contains(t))
                {
                    s += "Nombre: " + p.Nombre + "\nApellido: " + p.Apellido
                        + "\nFecha de nacimiento: " + p.Nacimiento
                        + "\nBiografia: " + p.Biografia + "\n";
					
					s += "Peliculas: \n";
					foreach (PeliculaActor r in bD.PeliculaActors)
					{

						if (p == r.Actor)
						{
							s += r.Pelicula.Nombre + "\n";
						}
					}
                    

                }
                
            }
            textview1.Buffer.Text = s;

		}

		protected void OnDirectoresClicked(object sender, EventArgs e)
		{
			string t = entrada.Text;
            string s = "";
            textview1.Buffer.Text = "";
            textview1.Editable = false;

			s += "Directores \n---------------------------------------\n";
            foreach (Director p in bD.directores)
            {
                if (p.Nombre.Contains(t) || p.Apellido.Contains(t))
                {
                    s += "Nombre: " + p.Nombre + "\nApellido: " + p.Apellido
                        + "\nFecha de nacimiento: " + p.Nacimiento
                        + "\nBiografia: " + p.Biografia + "\n";

                }

            }
            textview1.Buffer.Text = s;

		}

		protected void OnProductoresClicked(object sender, EventArgs e)
		{
			string t = entrada.Text;
            string s = "";
            textview1.Buffer.Text = "";
            textview1.Editable = false;

			s += "Productores \n---------------------------------------\n";
			foreach (Productor p in bD.productores)
			{
				if (p.Nombre.Contains(t) || p.Apellido.Contains(t))
				{
					s += "Nombre: " + p.Nombre + "\nApellido: " + p.Apellido
						+ "\nFecha de nacimiento: " + p.Nacimiento
						+ "\nBiografia: " + p.Biografia + "\n";

					s += "Peliculas: \n";
					foreach (PeliculaProductor r in bD.PeliculaProductors)
                    {

						if (p == r.Productor)
                        {
                            s += r.Pelicula.Nombre + "\n";
                        }
                    }
				}

                
			}
            textview1.Buffer.Text = s;


		}

		protected void OnEstudiosClicked(object sender, EventArgs e)
		{
			string t = entrada.Text;
            string s = "";
            textview1.Buffer.Text = "";
            textview1.Editable = false;

			s += "Estudios \n---------------------------------------\n";
            foreach (Estudio p in bD.estudios)
            {
                if (p.Nombre.Contains(t) || p.Direccion.Contains(t))
                {
                    s += "Nombre: " + p.Nombre + "\nDireccion: " + p.Direccion
                                       + "\nFecha de apertura: " + p.Fecha
                        + "\n";

                }

            }
            textview1.Buffer.Text = s;

		}

		protected void OnSearchClicked(object sender, EventArgs e)
		{
			string t = entrada.Text;
			string s = "";
			textview1.Buffer.Text = "";
			textview1.Editable = false;
			int contador = 1;

			s += "Actores \n---------------------------------------\n";
            foreach (Actor p in bD.actores)
            {
                if (p.Nombre.Contains(t) || p.Apellido.Contains(t))
                {
                    s += "Nombre: " + p.Nombre + "\nApellido: " + p.Apellido
                        + "\nFecha de nacimiento: " + p.Nacimiento
                        + "\nBiografia: " + p.Biografia + "\n";

                }
                
            }

            if (t.Length >= 3)
			{
				
				s += "Productores \n---------------------------------------\n";
				foreach( Productor p in bD.productores)
				{
					if (p.Nombre.Contains(t) || p.Apellido.Contains(t))
					{
						s += "Nombre: " + p.Nombre + "\nApellido: " + p.Apellido
                            + "\nFecha de nacimiento: " + p.Nacimiento
                            + "\nBiografia: " + p.Biografia + "\n";
                        contador += 1;
					}
					if (contador == 50)
					{
						break;
					}

				}
                if (contador < 50)
				{
					s += "Directores \n---------------------------------------\n";
                    foreach (Director p in bD.directores)
                    {
                        if (p.Nombre.Contains(t) || p.Apellido.Contains(t))
                        {
                            s += "Nombre: " + p.Nombre + "\nApellido: " + p.Apellido
                                + "\nFecha de nacimiento: " + p.Nacimiento
                                + "\nBiografia: " + p.Biografia + "\n";
                            contador += 1;
                        }
						if (contador == 50)
                        {
                            break;
                        }
                    }
				}

				if (contador < 50)
				{
					s += "Actores \n---------------------------------------\n";
                    foreach (Actor p in bD.actores)
                    {
                        if (p.Nombre.Contains(t) || p.Apellido.Contains(t))
                        {
                            s += "Nombre: " + p.Nombre + "\nApellido: " + p.Apellido
                                + "\nFecha de nacimiento: " + p.Nacimiento
                                + "\nBiografia: " + p.Biografia + "\n";
                            contador += 1;
                        }

                        if (contador == 50)
                        {
                            break;
                        }
                    }
				}

				if (contador < 50)
				{
					s += "Peliculas \n---------------------------------------\n";
					foreach (Pelicula p in bD.peliculas)
                    {
						if (p.Nombre.Contains(t) || p.Descripcion.Contains(t))
                        {
							s += "Nombre: " + p.Nombre + "\nDirector : " + p.Director.Nombre + " " + p.Director.Apellido +
                                 "\nFecha: " + p.Fecha
		                        + "\nDescripcion: " + p.Descripcion +
			                    "\nPresupuesto: " + p.Presupuesto.ToString() +  "\nEstudio: " + p.Estudio.Nombre + "\n";
                            contador += 1;
                        }

                        if (contador == 50)
                        {
                            break;
                        }
                    }
				}

				if (contador < 50)
                {
                    s += "Estudios \n---------------------------------------\n";
					foreach (Estudio p in bD.estudios)
					{
						if (p.Nombre.Contains(t) || p.Direccion.Contains(t))
                        {
							s += "Nombre: " + p.Nombre + "\nDireccion: " + p.Direccion
							                   + "\nFecha de apertura: " + p.Fecha
                                + "\n";
                            contador += 1;
                        }

                        if (contador == 50)
                        {
                            break;
                        }
                    }
                }

				textview1.Buffer.Text = s;

			}
		}

        protected void OnButton13Clicked(object sender, EventArgs e)
        {
            bD.SerializableActores(bD.actores);
            bD.SerializableEstudios(bD.estudios);
            bD.SerializablePeliculas(bD.peliculas);
            bD.SerializableDirectores(bD.directores);
            bD.SerializableProductores(bD.productores);
            bD.SerializablePeliculaActor(bD.PeliculaActors);
            bD.SerializableProductoresPelicula(bD.PeliculaProductors);
            bD.SerializableCritica(bD.criticas);
            Application.Quit();
                      
         
            
        }
	}
}
