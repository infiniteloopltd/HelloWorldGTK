using System;
using System.Net;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        WebClient wc = new WebClient();
        var strIP = wc.DownloadString("http://icanhazip.com");
        label2.Text = strIP;

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
