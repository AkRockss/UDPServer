using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UDP Server!");


           using ( UdpClient socket = new UdpClient())
            { 

                socket.Client.Bind(new IPEndPoint(IPAddress.Any, 5006));
            
                while (true)
                {
                    IPEndPoint clientEndPoint = null;
                    byte[] received = socket.Receive(ref clientEndPoint);
                    Console.WriteLine("Client connected: " + clientEndPoint.Address);
                    Console.WriteLine("Data: " + Encoding.UTF8.GetString(received));

                }

            }
        }
    }
}
