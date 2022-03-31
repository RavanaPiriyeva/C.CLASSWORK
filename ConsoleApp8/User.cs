using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class User: IAccount
    {

        public User(string fullname , string email)
        {
            this.FullName = fullname;
            this.Email = email;
        }
        public string FullName { get; set; }
        

        public string Email { get; set; }
        private string _password;
        public string Password { get { return _password; } 
        set
            {
                if (PasswordChecker(value) == true)
                {
                    _password = value;
                }
            }
        }

        public bool PasswordChecker(string pasword)
        {
           if (pasword.Length >= 8)
            {
                bool check1 = false;
                bool check2 = false;
                bool check3 = false;
                foreach (var item in pasword)
                {
                    if (char.IsDigit(item))
                    {
                       check1 = true;
                    }
                    if (char.IsLetter(item))
                    {
                         check2 = true;
                    }
                    if (char.IsUpper(item))
                    {
                        check3 = true;
                    }


                }
                if (check1==true && check2==true && check3==true)
                {
                    return true;
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname:{FullName} Email:{Email} Pasword:{Password}");
        }
    }
}
