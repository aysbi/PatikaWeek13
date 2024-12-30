
using DependencyInjection;

ITeacher teacher = new Teacher("Aysel", "Bilmez");

Classroom classroom = new Classroom(teacher);

Console.WriteLine(classroom.GetTeacherInfo());
