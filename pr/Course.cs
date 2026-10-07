using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    public class Course
    {
        private static int _counter = 0;
        public int Id { get; }
        public string Title { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public Course(string title, Teacher teacher)
        {
            _counter++;
            Id = _counter;
            Title = title;
            Teacher = teacher;
            Students = new List<Student>();
        }
        public void Info()
        {
            Console.WriteLine($"ID курса: {Id}, Навзание: {Title}");
            Console.WriteLine($"Преподаватель: {(Teacher != null ? Teacher.Name : "не назначен")}");
            Console.WriteLine($"Студентов: {Students.Count}");
        }
    }
}
