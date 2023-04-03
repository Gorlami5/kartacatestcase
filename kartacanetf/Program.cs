using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Interop;
using Websocket.Client;

namespace kartacanetf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var url = new Uri("wss://cekirdektenyetisenler.kartaca.com/ws");
            var exitEvent = new ManualResetEvent(false);
           
            


            using (var client = new WebsocketClient(url))
            {
                client.ReconnectTimeout = TimeSpan.FromSeconds(500);
                client.MessageReceived.Subscribe(msg => Console.WriteLine($"Message: {msg}"));
                client.Start();
                string nvhhztv = Console.ReadLine();


                
                // client.Send("{\"type\":\"REGISTER\",\"name\":\"Muhammet\",\"surname\":\"Yonkuc\",\"email\":\"muhammetyonkuc99@gmail.com\",\"registrationKey\":\"6253u3vx0y93y2782x20347xzuzv3ywx6w8yx8wz7u9v0301755v9x9392854937w\"}");
                Task.Run(() => client.Send(nvhhztv));

                exitEvent.WaitOne();
               

            }

            Console.ReadLine();

        }

        
    }
}
