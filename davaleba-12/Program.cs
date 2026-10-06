namespace davaleba_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User studentUser = new Student("giorgi_99", "giorgi@univ.edu");
            User teacherUser = new Teacher("prof_nino", "nino.t@school.ge");
            User guestUser = new Guest("anonymous_guest", "guest@temporary.com");

            
            Console.WriteLine("--- Student Info ---");
            studentUser.ShowInfo();
            studentUser.AccessContent();

            Console.WriteLine("\n--- Teacher Info ---");
            teacherUser.ShowInfo();
            teacherUser.AccessContent();

            Console.WriteLine("\n--- Guest Info ---");
            guestUser.ShowInfo();
            guestUser.AccessContent();
        }


    }
}
 

