using System;
using System.Collections.Generic;
using System.Text;
using static davaleba_12.Program;

namespace davaleba_12
{
    internal class Student : User
    {
        public Student(string username, string email) : base(username, email) { }

        public override void AccessContent()
        {
            Console.WriteLine("Accessing video lessons and quizzes");
        }

        public override string GetRole()
        {
            return "Student";
        }

    }
}
