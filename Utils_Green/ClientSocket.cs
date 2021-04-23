using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Utils_Green
{
    public class ClientSocket : SSHConnector, IClientSocket
    {
        private IPEndPoint _endIP;
        private IPAddress _address = IPAddress.Parse("83.143.217.188");
        private int _portNumber = 20011;
        private Socket clientSock;
        private User loggedUser;

        /// <summary>
        /// constructor for ClientSocket Class
        /// </summary>
        /// <param name="clientSock"></param>
        /// <param name="user"></param>
        protected ClientSocket(Socket clientSock, User user)
            : base(user)
        {
            // member initialization 
            _address = IP;
            _portNumber = Port;
            _endIP = new IPEndPoint(_address, _portNumber);
        }
        /// <summary>
        /// ClientSocket constructor overloaded 
        /// </summary>
        /// <param name="onlineUser"></param>
        public ClientSocket(User onlineUser)
            : base(onlineUser)
        {
            loggedUser = onlineUser;
        }

        #region IClientSocket Members
        public IPAddress IP
        {
            get { return _address; }
        }
        public int Port
        {
            get { return _portNumber; }

        }
        public IPEndPoint Endpoint
        {
            get { return _endIP; }
            set
            {
                _endIP = value;
            }
        }

        #endregion
        /// <summary>
        /// Get the host IP address from the list 
        /// </summary>
        /// <returns>IP address</returns>
        private IPAddress hostIP()
        {
            string host = Dns.GetHostName();
            IPHostEntry hostEntry = Dns.GetHostEntry(host);
            IPAddress loopback = IPAddress.Parse("127.0.0.1");
            foreach (IPAddress ip in hostEntry.AddressList)
            {
                return ip;
            }
            return loopback;
        }
        /// <summary>
        /// try to connect to the remote server using ip and port number 
        /// </summary>
        /// <returns>Socket</returns>
        public Socket EstablishClientSock()
        {
            try
            {
                Endpoint = new IPEndPoint(IP, Port);
                clientSock = new Socket(AddressFamily.InterNetwork,
                                    SocketType.Stream, ProtocolType.Tcp);
                clientSock.Connect(Endpoint);
                //test case
                MessageBox.Show(" Socket Connection Successful!", "Socket Connection Info");
                return clientSock;
            }
            catch (SocketException e)
            {
                //test Connection
                MessageBox.Show(" Socket Connection Refused: Check Firewall Rules \n Closing Socket Connection"
                                + e.ToString(), " Socket Connection Info");
                return null;
            }
            finally
            {
                if (clientSock != null)
                    clientSock.Close();
            }
        }
    }
}

