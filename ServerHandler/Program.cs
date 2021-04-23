using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace ServerNetStream
{
    class ServtSocketListener
    {
        static void Main(string[] args)
        {
            /// create TcpListener object
            TcpListener listener = new TcpListener(IPAddress.Any, 20011);
            /// accept client request

            /// start listening
            listener.Start();

            Console.WriteLine(" ....Server Listening state!");
            Socket sock = null;
            NetworkStream newStream = null;
            bool success = true;
            byte[] byteRead = new Byte[256];
            string clientCall = null;
            string serverResponse = "Checking user";
            byte[] bytesWrite = Encoding.ASCII.GetBytes(serverResponse);
            int i;
            //keep listening until file transfer is done

            try
            {

                while (success)
                {
                    sock = listener.AcceptSocket();
                    //          sock.Listen(10);
                    if (sock.Connected)
                    {
                        IPEndPoint remoteIP = sock.RemoteEndPoint as IPEndPoint;
                        Console.WriteLine(".....Successful connection");

                        // Networkstream writer to write a string on the server
                        newStream = new NetworkStream(sock); ;
                        Console.WriteLine("  Reading file from client");
                        newStream.Write(bytesWrite, 0, bytesWrite.Length);

                        // loop to receive all the data sent by the client
                        while ((i = newStream.Read(byteRead, 0, byteRead.Length)) != 0)
                        {
                            clientCall = System.Text.Encoding.ASCII.GetString(byteRead, 0, i);
                            Console.WriteLine(String.Format("Call from : {0} {1}", remoteIP.Address, clientCall));

                            FileStreamIO fileStreamIO = new FileStreamIO();
                            if (fileStreamIO.CreateDirectory(clientCall) == true)
                            {
                                Console.WriteLine("Directory Successfully Created!");
                            }

                        }
                        newStream.Close();
                    }
                    else
                        throw new Exception();
                    newStream.Close();
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("...connection failed");
                // Console.ReadLine();
                success = false;
            }
            finally
            {
                if (sock != null)
                    Console.WriteLine("Connection Closed ! \n Goodbye!");
                success = false;
                newStream.Close();
                sock.Close();
            }
            Console.ReadLine();

        }
    }
    public class FileStreamIO
    {
        public bool CreateDirectory(string dirName)
        {
            string username = Environment.UserName;
            if (Directory.Exists(dirName))
            {
                //shows message if testdir1 exist
                Console.WriteLine("Directory '" + dirName + "' Exist ");
                return true;
            }
            else
            {
                //create the directory testDir1
                Directory.CreateDirectory(dirName);
                Console.WriteLine("User '{0}' Created '{1}'  Directory ", username, dirName);
                return false;
            }
        }
    }
}
