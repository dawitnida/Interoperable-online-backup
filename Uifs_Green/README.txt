The following examples were posted with the original JSch java library,
and were translated to C#
====================================================================

- Shell.cs
  This program enables you to connect to sshd server and get the shell prompt.
  You will be asked username, hostname and passwd. 
  If everything works fine, you will get the shell prompt. Output will
  be ugly because of lacks of terminal-emulation, but you can issue commands.

  http://www.tamirgal.com/blog/page/SharpSSH.aspx

  SharpSSH - A Secure Shell (SSH) library for .NET  Copyright (c) 2008 TamirGal.com 

SharpSSH is a pure .NET implementation of the SSH2 client protocol suite. It provides an API for communication with SSH servers and can be integrated into any .NET application.

The library is a C# port of the JSch project from JCraft Inc. and is released under BSD style license.

SharpSSH allows you to read/write data and transfer files over SSH channels using an API similar to JSch's API. In addition, it provides some additional wrapper classes which offer even simpler abstraction for SSH communication.

SharpSSH is hosted on sourceforge, please check out its project page.
Feaure List
SharpSSH is not yet a full port of JSch. The following list summarizes the features currently supported by SharpSSH:

    * SharpSSH is pure .NET, but it depends on Mentalis.org Crypto Library for encryption and integrity functions.
    * SSH2 protocol support
    * SSH File Transfer Protocol (SFTP)
    * Secure Copy (SCP)
    * Key exchange: diffie-hellman-group-exchange-sha1, diffie-hellman-group1-sha1
    * Cipher: 3des-cbc, aes128-cbc
    * MAC: hmac-md5
    * Host key type: ssh-rsa, ssh-dss
    * Userauth: password, publickey (RSA, DSA)
    * Port Forwarding
    * Stream Forwarding
    * Remote Exec
    * Generating DSA and RSA key pairs
    * Changing the passphrase for a private key

	public string RePasswd
        {
            get
            {
                return _repasswd;
            }
            set
            {
                if (value != null)
                    _repasswd = value;
                else
                    _repasswd = string.Empty;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                if (value != null)
                    _firstname = value;
                else
                    _firstname = string.Empty;
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                if (value != null)
                    _lastname = value;
                else
                    _lastname = string.Empty;
            }
        }
        public string EmailAdd
        {
            get
            {
                return _email;
            }
            set
            {
                if (value != null)
                    _email = value;
                else
                    _email = string.Empty;
            }
        }
