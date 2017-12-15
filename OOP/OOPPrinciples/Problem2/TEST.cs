using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem2
{
    public class TEST
    {
        public static List<Student> GenerateStudents(int numberOfStudents)
        {
            List<Student> students = new List<Student>();

            string infoFilePath = "../../StudentsInfo.txt";

            for (int i = 0; i < (numberOfStudents * 3) - 2; i += 3)
            {
                string firstName = File.ReadLines(infoFilePath).Skip(i).Take(1).First();

                string lastName = File.ReadLines(infoFilePath).Skip(i + 1).Take(1).First();

                int grade = int.Parse(File.ReadLines(infoFilePath).Skip(i + 2).Take(1).First());

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);
            }
            return students;
        }

        public static List<Worker> GenerateWorker(int numberOfWorkers)
        {
            List<Worker> workers = new List<Worker>();

            string infoFilePath = "../../WorkersInfo.txt";

            for (int i = 0; i < (numberOfWorkers * 4) - 3; i += 4)
            {
                string firstName = File.ReadLines(infoFilePath).Skip(i).Take(1).First();

                string lastName = File.ReadLines(infoFilePath).Skip(i + 1).Take(1).First();

                decimal weekSalary = decimal.Parse(File.ReadLines(infoFilePath).Skip(i + 2).Take(1).First());

                int workHoursPerDay = int.Parse(File.ReadLines(infoFilePath).Skip(i + 3).Take(1).First());

                Worker worker = new Worker(firstName, lastName, weekSalary, workHoursPerDay);

                worker.MoneyPerHour = worker.MoneyEarnedPerHour(weekSalary, workHoursPerDay);

                workers.Add(worker);
            }

            return workers;
        }

        public static void Main()
        {
            List<Student> students = GenerateStudents(10);

            List<Worker> workers = GenerateWorker(10);

            foreach (var student in (students.OrderBy((x) => x.Grade))) //sorted by grade in a ascending order
            {
                Console.WriteLine(student);
            }

            foreach (var worker in (workers.OrderByDescending((x) => x.MoneyPerHour))) //sorted by money per hour earned in a descending order
            {
                Console.WriteLine(worker);
            }
        }
    }

}



