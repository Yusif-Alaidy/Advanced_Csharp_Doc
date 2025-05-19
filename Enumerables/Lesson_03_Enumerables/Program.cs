namespace Lesson_03_Enumerables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new();

            employee1.AddName("yusif");
            employee1.AddName("ali");
            employee1.AddName("mohsen");
            employee1.AddName("mena");

            foreach (var emp in employee1)
            {
                Console.WriteLine($"name is: {emp}");
            }
        }
    }
}
