using System;
namespace Utils_Green
{
    //credentials interface to be implemented 
	public interface IUser
	{       
		string Username { get; }
		string Userpass { get; }
        string Host { get; }
	}  	
}
