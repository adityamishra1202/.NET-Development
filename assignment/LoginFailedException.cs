using System;

class LoginFailedException : Exception
{
    public LoginFailedException()
        : base("Invalid Login. Account Locked")
    {

    }
}