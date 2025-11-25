using System;

namespace Task3B
{
    // creating base class Teacher
    class Teacher
    {
        // making Name property
        public string Name { get; set; }

        // creating Teaching method (virtual so child can override)
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // salary method that child cannot override
        public void SalaryInfo()
        {
            Console.WriteLine("Salary info cannot be overridden");
        }
    }

    // creating NepaliTeacher and overriding Teaching
    class NepaliTeacher : Teacher
    {
        public override void Teaching()
        {
            Console.WriteLine("Teacher teaches in Nepali");
        }
    }

    // creating EnglishTeacher but not overriding anything
    class EnglishTeacher : Teacher
    {
        // using the parent's Teaching method
    }

    class Program
    {
        static void Main(string[] args)
        {
            // creating NepaliTeacher object
            NepaliTeacher nt = new NepaliTeacher();
            nt.Name = "Ram";         // setting name
            nt.Teaching();           // calling overridden method
            nt.SalaryInfo();         // calling parent method

            // creating EnglishTeacher object
            EnglishTeacher et = new EnglishTeacher();
            et.Name = "John";        // setting name
            et.Teaching();           // this uses the parent method
            et.SalaryInfo();         // calling parent method
        }
    }
}