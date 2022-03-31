using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    interface IAccount
    {
        bool PasswordChecker (string pasword);
        void ShowInfo();
    }
}
