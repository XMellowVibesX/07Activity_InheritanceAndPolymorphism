using UserNamespace;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Administrator admin = new Administrator("admin_JD001", "AJD-001", "Jane Doe");

            Console.WriteLine("""
                Logging in...
                Name: Jane Doe
                Password: AJD-001
                ID: admin_JD001
                Please wait...

                """);
            
            if (admin.verifyLogin("admin_JD001", "AJD-001"))
            {
                Console.WriteLine("""
                    =====================================

                    Login Successful! Welcome Jane Doe!
                    
                    =====================================
                    """);
            } else { Console.WriteLine("Login failed! Try Again!"); }

            Console.WriteLine("""

                Updating Username and Password...
                New username: Janie123
                New password: JD123
                Please wait...
                """);

            admin.updateAdminName("Janie123");
            admin.updatePassword("JD123");

            Console.WriteLine("\nUpdate successful! Please check to see if its correct:");
            Console.WriteLine("New name: " + admin.getUsername());
            Console.WriteLine("New password: " + admin.getPassword());
        }
    }
    
}