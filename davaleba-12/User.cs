using System;
using System.Collections.Generic;
using System.Text;

namespace davaleba_12
{
    public abstract class User
    {
        public string Username { get; set; }
        public string Email { get; set; }

        
        protected User(string username, string email)
        {
            Username = username;
            Email = email;
        }

        
        public void ShowInfo()
        {
            Console.WriteLine($"[Role: {GetRole()}] User: {Username} | Email: {Email}");
        }

        public abstract void AccessContent();
        
        public virtual string GetRole()
        {
            return "User";
        }
    }
}
