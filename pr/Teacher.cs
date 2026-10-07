using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher (string name, int age, string email, string subject)
            :base(name, age, email)
        {
            Subject = subject;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Предмет: {Subject}");
        }
    }
}
