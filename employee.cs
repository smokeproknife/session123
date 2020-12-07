using System;

namespace _7
{
    enum Position
    {
        Junior, Middle, Senior
    }
    class Employee
    {
        private string name;
        private string surname;
        private Position position;
        private int exp;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public Position Position
        {
            get { return position; }
            set { position = value; }
        }
        public int Exp
        {
            get { return exp; }
            set { exp = value; }
        }

        public Employee() { }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void CalculateSalary()
        {
            switch(position) {
                case Position.Junior:
                    Console.WriteLine($"{exp}-year Junior's salary:\n10 000 * {exp} * 0.85 = {10000  * 0.85 * exp} (Tax 15% = {10000 * exp / 2 * 0.15}");
                    break;
                case Position.Middle:
                    Console.WriteLine($"{exp}-year Middle's salary:\n20 000 * {exp} * 0.85 = {20000 * exp * 0.85} (Tax 15% = {20000 * exp / 2 * 0.15}");
                    break;
                case Position.Senior:
                    Console.WriteLine($"{exp}-year Senior's salary:\n30 000 * {exp} * 0.85 = {30000 * exp * 0.85} (Tax 15% = {30000 * exp / 2 * 0.15}");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Bill", "Gates");
            employee.Position = Position.Middle;
            employee.Exp = 13;

            Console.WriteLine($"Name: {employee.Name}\nSurname: {employee.Surname}\nPosition: {employee.Position}");
            employee.CalculateSalary();

            Console.ReadLine();
        }
    }
}
