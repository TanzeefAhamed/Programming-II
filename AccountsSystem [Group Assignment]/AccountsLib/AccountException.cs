using AccountsLib;
using System;

public class AccountException : Exception
{
    public AccountException(AccountExceptionType reason)
        : base(reason.ToString())
    {
    }
}
