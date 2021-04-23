using System;
using System.Threading;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Utils_Green
{
    //[Serializable]
    public class AsynchronousNetStreamIO : ClientSocket
    {
        private NetworkStream netStream = null;
        private const int BufferSize = 256;
        private Socket tempClientSock = null;
        private string serverCall = null;
        private int i;

        public AsynchronousNetStreamIO(Socket tempClientSock, User user)
            : base(tempClientSock, user)
        {
        }
        public void SendFileTo(string filePath)
        {
            tempClientSock = base.EstablishClientSock();

            if (tempClientSock != null)
            {
                if (tempClientSock.Connected == true)
                {
                    // clientSock = tempClientSock.Client;
                    byte[] bytesWrite = Encoding.ASCII.GetBytes(filePath);
                    byte[] bytesRead = new byte[BufferSize];
                    try
                    {
                        // Networkstream write on the server 
                        netStream = new NetworkStream(tempClientSock, true);
                        tempClientSock.Send(bytesWrite, 0, bytesWrite.Length, SocketFlags.None);

                        //  netStream.Write(bytesWrite, 0, bytesWrite.Length);
                        //netStream.Close();

                        // Networkstream recieve/read from the server                    
                        //  netStream = tempClientSock.GetStream();
                        netStream = new NetworkStream(tempClientSock, true);

                        while ((i = tempClientSock.Receive(bytesRead, 0, tempClientSock.Available, SocketFlags.None)) != 0)
                        {
                            serverCall = System.Text.Encoding.ASCII.GetString(bytesRead, 0, i);
                            MessageBox.Show(String.Format("Server message : {0}", serverCall), " Server Message Info");
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(" File Streaming Error. \n" + ex.ToString(), "Network Stream Info");
                        //clientSock.Close();
                    }
                    finally
                    {
                        if (tempClientSock != null)
                            MessageBox.Show("File Streaming Stopped!", "Network Stream Info");
                        netStream.Close();
                        tempClientSock.Close();
                    }
                }
            }
        }

        public void RecieveMessage()
        {

            Socket tempTcpClient = EstablishClientSock();
            string servResponse = string.Empty;

            byte[] bytesRead = new byte[BufferSize];

            if (tempClientSock.Connected)
            {
                try
                {
                    // Networkstream read from the server                  

                    netStream = new NetworkStream(tempClientSock, true);
                    netStream.Read(bytesRead, 0, bytesRead.Length);
                    MessageBox.Show(" Recieved from Server {0}", servResponse);
                    netStream.Close();

                }
                catch (Exception)
                {
                    return;
                }
            }
        }
    }
}


