using System;
using Gtk;
using System.Threading;
using System.Windows;


namespace movies
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			
			BD bD = new BD();
			bD.actores = bD.DeserealizarActor();
			bD.directores = bD.DeserealizarDirector();
			bD.estudios = bD.DeserealizarEstudio();
			bD.peliculas = bD.DeserealizarPelicula();
			bD.PeliculaActors = bD.DeserealizarPeliculaActor();
			bD.PeliculaProductors = bD.DeserealizarPeliculaProductor();
			bD.productores = bD.DeserealizarProductor();
			bD.criticas = bD.DeserealizarCriticas();
				
            Application.Init();
            //MainWindow win = new MainWindow();
			//win.Show(); 
			//Thread.Sleep(5000);
			//win.Hide();
			Window2 window2 = new Window2(bD);
			window2.Show();
            Thread.Sleep(5000);
            window2.Hide();
            Window window = new Window(bD);
            window.Show();
			Application.Run();
			Application.Quit();
			Thread.Sleep(5000);

        }
    }
}
