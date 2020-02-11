using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EchoServer
{
    public class Server
    {
        public void Start()
        {
            TcpListener listener = new TcpListener(IPAddress.Loopback,7);
            listener.Start();
            var socket = listener.AcceptTcpClient();
            var ns = socket.GetStream();
            var reader = new StreamReader(ns);
            var writer = new StreamWriter(ns);
            string line = reader.ReadLine();
            writer.WriteLine(line);
            writer.Flush();

        }
    }
}
