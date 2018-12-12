using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TcpClient("192.168.1.161", 8585);
            using (var sw = new StreamWriter(client.GetStream()))
            {
                sw.Write(System.DateTime.Now);
            }
        }
    }
}
