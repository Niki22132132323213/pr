using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    public class Student : Person
    {
        public string Group { get; set; }
        public Student(string name, int age, string email, string group)
            : base(name, age, email)
        {
            Group = group;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Группа: {Group}");
        }
    }

}
