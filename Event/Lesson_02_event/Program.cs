namespace Lesson_02_event
{


    class Program
    {
        static void Main()
        {
            LoginClass yusifEmail = new LoginClass();

            // Event subscriptions
            yusifEmail.EmailIsloggedIn += (email,pass) => Console.WriteLine($"Login is sucssful \nyour email is: {email}\npass is: {pass}");
            yusifEmail.WrongPass += (email) => Console.WriteLine($"Hello {email} your password is not correct pleas try again");
            yusifEmail.EmailNotFound += () => Console.WriteLine("This Email is not fount !!");

            // Trigger login process
            yusifEmail.loginProcess("yusif@gmail.com","124");


        }

    }
}