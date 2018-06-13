using System;
using Gtk;
using System.Windows;

using System.Threading;

public partial class MainWindow : Gtk.Window
{
	

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

      
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
		
        Application.Quit();
        a.RetVal = true;
    }
}
