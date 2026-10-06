using System;
using System.Collections.Generic;
using System.Text;
using static davaleba_12.Program;

namespace davaleba_12
{
    internal class Guest : User
    {
        public Guest(string username, string email) : base(username, email) { }

        public override void AccessContent()
        {
            Console.WriteLine("Limited access to demo content");
        }

        public override string GetRole()
        {
            return "Guest";
        }
    }
}
