using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace SocketDataTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new TcpListener(IPAddress.Parse("192.168.1.161"), 8585);
            server.Start();
            while (true)
            {
                var client = server.AcceptTcpClient();
                using (var sr = new StreamReader(client.GetStream()))
                {
                    Console.WriteLine("Data received : " + sr.ReadToEnd());
                }
            }
        }
    }
}
