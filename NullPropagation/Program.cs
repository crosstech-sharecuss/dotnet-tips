using System;

namespace NullPropagation
{
	class Program
	{
		static void Main(string[] args)
		{
			Student student = null;
			WriteStudentName(student);

			student = new Student() { NameSurname = "John Doe" };
			WriteStudentName(student);
		}

		static void WriteStudentName(Student student)
		{
			// Not Best Approach
			// var nameSurname = student != null ? student.NameSurname : "Object is null, please send student object";

			// Best Approach: Null Propagation
			var nameSurname = student?.NameSurname ?? "Object is null, please send student object";

			System.Console.WriteLine(nameSurname);
		}
	}
}
