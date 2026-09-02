using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.AcceptDetails();
            s1.CheckScholarshipEligibility();
            s1.DisplayDetails();

            Console.ReadKey();
        }
    }

    public class Student
    {
        public int AdmissionNumber;
        public string Name;
        public int Semester;
        public string Course;
        private double fees;
        private double netfees;
        private bool isScholarshipEligible;
        private const double ScholarshipRate = 0.10;
        public void student()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Enter Details of students");
            Console.WriteLine("------------------------------");
        }

        public void AcceptDetails()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Admission Number: ");
            AdmissionNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter semester: ");
            Semester = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course: ");
            Course = Console.ReadLine();

            Console.Write("Enter fees: ");
            fees = Convert.ToDouble(Console.ReadLine());
        }

        public void CheckScholarshipEligibility()
        {
            if (fees >= 60000)
            {
                isScholarshipEligible = true;
                netfees = fees - (fees * ScholarshipRate);
                Console.WriteLine("The fees is: " + netfees);

            }
            else
            {
                isScholarshipEligible = false;
                netfees = fees;
                Console.WriteLine("The fees is: " + netfees);
            }
        }

        public void DisplayDetails()
        {
            Console.Write("\n");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("STUDENT ADMISSION DETAILS");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Student Object Is Created Sucessfully");
            Console.WriteLine("");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Admission Number: " + AdmissionNumber);
            Console.WriteLine("Semester: " + Semester);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("Admission Fees: " + fees);
            Console.WriteLine("Eligible for Scholarship: " + isScholarshipEligible);
            Console.WriteLine("Final fees: " + netfees);
        }
    }
}
