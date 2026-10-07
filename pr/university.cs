using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    public class University
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Course> Courses { get; set; }

        public void AddStudent(Student s) => Students.Add(s);
        public void AddTeacher(Teacher t) => Teachers.Add(t);  
        public void AddCourse(Course c) => Courses.Add(c);

        public Student FindStudent(int id) => Students.FirstOrDefault(s => s.Id == id);
        public Teacher FindTeacher (int id) => Teachers.FirstOrDefault(t => t.Id == id);
        public Course FindCourse (int id) => Courses.FirstOrDefault(c => c.Id == id);

        public void ShowAllStudents()
        {
            if (Students.Count == 0) { Console.WriteLine("Студентов нет"); return; }
            foreach (var s in Students) s.Info();
        }

        public void ShowAllTeachers()
        {
            if (Teachers.Count == 0) { Console.WriteLine("Препод. нет"); return; }
            foreach (var t in Students) t.Info();
        }
        public void ShowAllCourses()
        {
            if (Courses.Count == 0) { Console.WriteLine("Курсов нет"); return; }
            foreach (var c in Students) c.Info();
        }

        public void EnrollStudent(int studentId, int courseId)
        {
            var student = FindStudent(studentId);
            var course = FindCourse(courseId);

            if (student == null) { Console.WriteLine("Студент не найден"); return; }
            if (course == null) { Console.WriteLine("Курс не найден"); return; }

            if (course.Students.Contains(student))
            {
                Console.WriteLine($"Студент {student.Name} уже записан на курс {course.Title}");
                return;
            }

            course.Students.Add(student);
            Console.WriteLine($"Студент {student.Name} записан на курс {course.Title}");
        }

        public void ShowStudentCourses(int studentId)
        {
            var student = FindStudent(studentId);
            if (student == null) { Console.WriteLine("Студент не найден"); return; }
            Console.WriteLine($"\nКурсы студента {student.Name}");
            bool found = false;
            foreach (var course in Courses)
            {
                if (course.Students.Contains(student))
                {
                    Console.WriteLine($"{course.Title} Преподаватель: {course.Teacher.Name}");
                    found = true;
                }
            }
            if (!found) Console.WriteLine("Студент не записан на курсы");
        }
        public void ShowCoursesStudents(int courseId)
        {
            var course = FindCourse(courseId);
            if (course == null) { Console.WriteLine("Курс не найден"); return; }

            Console.WriteLine($"\nСтуденты курса: {course.Title}");
            if (course.Students.Count == 0) { Console.WriteLine("список пуст"); return; }
            foreach (var s in course.Students) Console.WriteLine($"{s.Name} группа {s.Group}");
        }
    }
}
