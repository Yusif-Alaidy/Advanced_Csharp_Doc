using System.Data.SqlTypes;
using System.Numerics;

namespace Genaric
{
    internal class Program
    {
        public static T add<T>(T a,T b) where T : INumber<T>
        {

            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(add(5.5,6.1));
        }
    }
}
