namespace Lesson_Linq
{
    internal class Program
    {
        // Linq is Deferred Execution
        static void Main(string[] args)
        {
            List<int> myList = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            // Query expression basics (Query syntax)
            var Query = from item in myList where item > 5 select item; // output: 6, 7, 8, 9, 10

            // Method syntax 
            var QuaryMethod = myList.Where(x => x > 5); // output: 6, 7, 8, 9, 10

            // Sorting: OrderBy, OrderByDescending, ThenBy, ThenByDescendingm reverse
            // https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/sorting-data

            // Quantifiers: all, any, contains
            // https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/quantifier-operations

            // partitioning: Take, TakeWhile, Skip, SkipWhile, chunk
            // https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/partitioning-data

            // Set Operations: distinct, union, intersect, except, concat 
            // https://learn.microsoft.com/en-us/dotnet/csharp/linq/standard-query-operators/set-operations

        }
    }
}
