using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4
{
    internal class Connector
    {
        private string? ip;
        private int port;
        public string Ip { get; set; }
        public int Port { get; set; }

        private static Connector? instance;
        public static Connector? Instance
        {
            get
            {
                if (instance == null)
                {
                    Console.WriteLine("Please initialize connector first");
                }
                return instance;
            }
        }
        public static void Initialize(string ip, int port)
        {
            if (instance == null)
            {
                instance = new Connector(ip, port);
            }
        }

        private Connector(string ip, int port)
        {
            Ip = ip;
            Port = port;
            Console.WriteLine("Connected");
        }
        public override string ToString()
        {
            return $"ip: {Ip}, port: {Port}";
        }
    }
}
