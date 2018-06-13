using System;
using System.Threading;
namespace movies
{
    public partial class Window2 : Gtk.Window
    {
		BD bD;
		public Window2(BD bd) :
                base(Gtk.WindowType.Toplevel)
        {
			bD = bd;
            this.Build();
         
        }
    }
}
