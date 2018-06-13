using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace movies
{
	[Serializable]
    public class BD
    {
		public List<Estudio> estudios = new List<Estudio>();
		public List<Actor> actores = new List<Actor>();
		public List<Productor> productores = new List<Productor>();
		public List<Director> directores = new List<Director>();
		public List<Pelicula> peliculas = new List<Pelicula>();
		public List<PeliculaActor> PeliculaActors = new List<PeliculaActor>();
		public List<PeliculaProductor> PeliculaProductors = new List<PeliculaProductor>();
		public List<Critica> criticas = new List<Critica>();

        public BD()
        {
        }
		public void SerializableCritica(List<Critica> criticas)
        {
            try
            {
                using (Stream st = File.Open("../../criticas.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(st, criticas);
                }
            }
            catch (Exception ex)
            {
                Stream st = File.Create("../../criticas.bin");
                {
                    BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(st, criticas);
                }
            }
        }
		public List<Critica> DeserealizarCriticas()
        {
			List<Critica> c;
            try
            {
                using (Stream st = File.Open("../../criticas.bin", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					c = (List<Critica>)bf.Deserialize(st);
                }
                return c;

            }
            catch (Exception ex)
            {
                c = new List<Critica>();
                return c;
            }
        }
        
		public List<PeliculaProductor> DeserealizarPeliculaProductor()
        {
			List<PeliculaProductor> pp;
            try
            {
                using (Stream st = File.Open("../../peliculaproductors.bin", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					pp = (List<PeliculaProductor>)bf.Deserialize(st);
                }
                return pp;

            }
            catch (Exception ex)
            {
				pp = new List<PeliculaProductor>();
                return pp;
            }
        }
		public List<PeliculaActor> DeserealizarPeliculaActor()
        {
            List<PeliculaActor> pa;
            try
            {
                using (Stream st = File.Open("../../peliculaactors.bin", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					pa = (List<PeliculaActor>)bf.Deserialize(st);
                }
                return pa;

            }
            catch (Exception ex)
            {
                pa = new List<PeliculaActor>();
                return pa;
            }
        }

		public List<Pelicula> DeserealizarPelicula()
        {
			List<Pelicula> peliculas;
            try
            {
                using (Stream st = File.Open("../../peliculas.bin", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					peliculas = (List<Pelicula>)bf.Deserialize(st);
                }
				return peliculas;

            }
            catch (Exception ex)
            {
				peliculas = new List<Pelicula>();
				return peliculas;
            }
        }
		public List<Director> DeserealizarDirector()
        {
			List<Director> director;
            try
            {
                using (Stream st = File.Open("../../directores.bin", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					director = (List<Director>)bf.Deserialize(st);
                }
				return director;
                
            }
            catch (Exception ex)
            {
				director = new List<Director>();
				return director;
            }
        }

		public List<Productor> DeserealizarProductor()
        {
			List<Productor> productors;
            try
            {
                using (Stream st = File.Open("../../productores.bin", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					productors = (List<Productor>)bf.Deserialize(st);
                }
				return productors;
                
            }
            catch (Exception ex)
            {
				productors = new List<Productor>();
				return productors;
            }
        }

		public List<Actor> DeserealizarActor()
        {
			List<Actor> actor;
            try
            {
                using (Stream st = File.Open("../../actores.bin", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					actor = (List<Actor>)bf.Deserialize(st);
                }
				return actor;

            }
            catch (Exception ex)
            {
				actor = new List<Actor>();
                return actor;
            }
        }
        
		public List<Estudio> DeserealizarEstudio()
        {
			List<Estudio> estudios;
            try
            {
                using (Stream st = File.Open("../../estudios.bin", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					estudios = (List<Estudio>)bf.Deserialize(st);
                }
				return estudios;

            }
            catch (Exception ex)
            {
				estudios = new List<Estudio>();
				return estudios;
            }
        }

        
		public void SerializableProductoresPelicula(List<PeliculaProductor> peliculaProductors)
        {
            try
            {
                using (Stream st = File.Open("../../peliculaproductors.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(st, peliculaProductors);
                }
            }
            catch (Exception ex)
            {
                Stream st = File.Create("../../peliculaproductors.bin");
                {
                    BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(st, peliculaProductors);
                }
            }
        }
		public void SerializablePeliculaActor(List<PeliculaActor> peliculaActors)
        {
            try
            {
                using (Stream st = File.Open("../../peliculaactors.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(st, peliculaActors);
                }
            }
            catch (Exception ex)
            {
                Stream st = File.Create("../../peliculaactors.bin");
                {
                    BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(st, peliculaActors);
                }
            }
        }

		public void SerializablePeliculas(List<Pelicula> peliculas)
        {
            try
            {
                using (Stream st = File.Open("../../peliculas.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(st, peliculas);
                }
            }
            catch (Exception ex)
            {
                Stream st = File.Create("../../peliculas.bin");
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(st, peliculas);
                }
            }
        }
		public void SerializableDirectores(List<Director> directores)
        {
            try
            {
                using (Stream st = File.Open("../../directores.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(st, directores);
                }
            }
            catch (Exception ex)
            {
                Stream st = File.Create("../../directores.bin");
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(st, directores);
                }
            }
        }
		public void SerializableProductores(List<Productor> productores)
        {
            try
            {
                using (Stream st = File.Open("../../productores.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(st, productores);
                }
            }
            catch (Exception ex)
            {
                Stream st = File.Create("../../productores.bin");
                {
                    BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(st, productores);
                }
            }
        }
		public void SerializableEstudios(List<Estudio> estudios)
        {
            try
            {
                using (Stream st = File.Open("../../estudios.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(st, estudios);
                }
            }
            catch (Exception ex)
            {

				Stream st = File.Create("../../estudios.bin");
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(st, estudios);
                }
            }
        }

		public void SerializableActores(List<Actor> actores)
        {
            try
            {
                using (Stream st = File.Open("../../actores.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(st, actores);
                }
            }
            catch (Exception ex)
            {
                Stream st = File.Create("../../actores.bin");
                {
                    BinaryFormatter bf = new BinaryFormatter();
					bf.Serialize(st, actores);
                }
            }
        }


	}
}
