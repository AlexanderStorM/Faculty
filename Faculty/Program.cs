﻿using System;
using System.Collections.Generic;
using Faculty.Model;

namespace Faculty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Professor reactProfessor = new Professor("Pera", "Peric", new DateTime(1958, 12, 2));
            Professor angularProfessor = new Professor("Mika", "Lazic", new DateTime(1976, 11, 13));

            Course reactCourse = new Course("Hooked on React", "Basic course for React developers", reactProfessor);
            Course angularCourse = new Course("Angular 4", "Angular fundamentals for beginners", angularProfessor);

            Exam reactExam = new Exam(reactCourse, new DateTime(2019, 5, 1));
            Exam angularExam = new Exam(angularCourse, new DateTime(2019, 6, 18));

            Console.WriteLine("1. Show all students \n" +
                              "2. Add new student \n" +
                              "3. Delete student \n" +
                              "4. Get passed exams \n" +
                              "5. Exit program \n" +
                              "Choose from 1 to 5...");

            var input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    ShowAllStudentsDetails();                    
                    break;
                case 2:
                    AddNewStudent();
                    break;
                case 3:
                    Console.WriteLine("Test two!");
                    break;
                case 4:
                    Console.WriteLine("Vulvulin!");
                    break;
                case 5:
                    Console.WriteLine("Sandwich!");
                    break;                   
            }

            Console.ReadLine();

        }

        public static List<Student> students = new List<Student>();

        public static void ShowAllStudentsDetails()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("The list of students is empty!");
            }

            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public static void AddNewStudent()
        {
            Console.WriteLine("--- Adding new student ---");

            Student student = new Student();

            Console.WriteLine("First name: ");
            student.FirstName = Console.ReadLine();

            Console.WriteLine("Last name: ");
            student.LastName = Console.ReadLine();

            Console.WriteLine("Date of birth: ");
            var dateString = Console.ReadLine();

            Console.WriteLine("Index number: ");
            student.IndexNumber = Console.ReadLine();

            student.DateOfBirth = Convert.ToDateTime(dateString);

            if (student.IsValid())
            {
                students.Add(student);
                Console.WriteLine("Student has been successfully added.");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
