using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03_Enumerables
{
    public class Employee
    {
        private readonly List<string> names = new();
        public void AddName(string name)
        {
            names.Add(name);
            return;
        }

    public IEnumerator<string> GetEnumerator()
        {
            return names.GetEnumerator();
        }
    }
}
