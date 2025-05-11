namespace Lesson_01_delegates
{
    // Delegates Documentation in Microsoft
    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
    internal class Program
    {
        // Single-cast Delegate =============================╗
        delegate void PrintMessage();                      //║
        static void Hello() => Console.WriteLine("Hello"); //║
        // ==================================================╝
        
        // Multi-cast Delegate ===================================╗
        delegate void Notify();                                // ║
        static void Msg1() => Console.WriteLine("Message 1");  // ║
        static void Msg2() => Console.WriteLine("Message 2");  // ║
        // =======================================================╝

        static void Main(string[] args)  
        {
            // Single-cast Delegate ======╗
            PrintMessage msg = Hello;  // ║
            msg();  // يطبع Hello      // ║
            // ===========================╝

            // Multi-cast Delegate ========╗
            Notify notify = Msg1;       // ║
            notify += Msg2;             // ║
            notify();                   // ║
            // ============================╝


        }
    }
}
