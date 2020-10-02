using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UTAS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ScanNetButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.TextColor = Color.FromHex("#00BFFF");
            btn.Text = "Сканирую";
            //TODO: Scan Local Net here
            //Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //Костыльный коннект к лок серверу
            TcpClient client = new TcpClient();
            client.Connect("192.168.0.103", 8080);
            client.Close();


        }

        
    }
}
