using System.Data;

namespace Task8Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[0];
            int studentCount = 0;
            do
            {
                Console.WriteLine("Enter the student information:");

                Console.Write("Name:");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    break;

                Console.Write("Surname:");
                string surname = Console.ReadLine();

                Console.Write("Date of birth (MM/dd/yyyy): ");
                string input = Console.ReadLine();

                DateTime dateOfBirth;
                if (DateTime.TryParse(input, out dateOfBirth))
                {
                    Array.Resize(ref students, studentCount + 1);
                    students[studentCount] = new Student { Name = name, Surname = surname, DateOfBirth = dateOfBirth };
                    
                    studentCount++;
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect date.");
                }

                foreach (var student in students)
                {
                    if (student != null)
                    {
                        Console.WriteLine(student);
                    }
                }

                Console.WriteLine("Press Enter to continue");

            } while (Console.ReadKey().Key == ConsoleKey.Enter);

            Console.WriteLine("\nAll the students that you inputed: ");

            foreach (var student in students)
            {
                if (student != null)
                {
                    Console.WriteLine(student);

                }
            }

        }
    }
}
