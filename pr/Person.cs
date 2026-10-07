using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    public abstract class Person
    {
        private static int _counter = 0;

        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        protected Person(string name, int age, string email)
        {
            _counter++;
            Id = _counter;
            Name = name;
            Age = age;
            Email = email;
        }

        public virtual void Info()
        {
            Console.WriteLine($"ID: {Id}, Имя: {Name}, Возраст: {Age}, Почта: {Email} ");
        }
    }
}
