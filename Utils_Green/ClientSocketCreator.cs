using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace Utils_Green
{
    public class ClientSocketCreator
    {
        public IPAddress host_ip = IPAddress.None;
        //  IPAddress host_ip = IPAddress.Parse("83.143.217.188");
        public IPEndPoint host_EndPoint = new IPEndPoint(0,0);

        //constructor
        public ClientSocketCreator() 
        {
        }

        //properties.....try{}catch complaining about static key word and
        //requires property
        public IPAddress IP { get; set; }
        public IPEndPoint HOST { get; set; }


        public static bool createSock() 
        {
            IPAddress host_ip = IPAddress.Parse("83.143.217.188");
            //IPEndPoint class takes two arguments: ip address and port name
            IPEndPoint hostIp = new IPEndPoint(host_ip, 2011);
            TcpClient client = new TcpClient();

            try
            {
                //Connect to the remote host using ip and port
                client.Connect(hostIp);
                return true;
            }
            catch (SocketException e)
            {
                //Test case
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                client.Close();
                return false;
            }
        }                     
    }
 }

