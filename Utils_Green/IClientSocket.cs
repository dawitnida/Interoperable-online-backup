using System;
using System.Net;
using System.Net.Sockets;

namespace Utils_Green
{
    interface IClientSocket
    {
        IPAddress IP { get; }
        int Port { get; }
        IPEndPoint Endpoint { get; }
        Socket EstablishClientSock();
    }
}
