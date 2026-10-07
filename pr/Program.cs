using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    internal class Program
    {
        static University uni = new University();
        static void Main(string[] args)
        {
            var t1 = new Teacher("Хайретдинов С. Р.", 23, "DarkSayd@gmail.com", "Музыка");
            var t2 = new Teacher("Аришевский И. С.", 67, "IlyaArish@mail.ru", "Рисование");
            uni.AddTeacher(t1);
            uni.AddTeacher(t2);

            var s1 = new Student("Абазян Г. А.", 18, "Gor@yandex.ru", "ИСИП-124");
            var s2 = new Student("Муравьев Н. С.", 18, "Patron@gmail.com", "ИСИП-324");
            var s3 = new Student("Студентов С. С.", 17, "StudenttovStudent@mail.ru", "ОИБАС-1424");
            uni.AddStudent(s1);
            uni.AddStudent(s2);
            uni.AddStudent(s3);

            var c1 = new Course("Музыка", t1);
            var c2 = new Course("Рисование", t2);

            uni.EnrollStudent(s1.Id, c1.Id);
            uni.EnrollStudent(s1.Id, c2.Id);
            uni.EnrollStudent(s2.Id, c1.Id);
            uni.EnrollStudent(s3.Id, c2.Id);

            bool exit = false;

        }
    }
}
