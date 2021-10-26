using System;
using System.Collections.Generic;
using System.Text;

namespace TrainCSh
{
    class Passenger
    {
        private string name;
        private string firstName;
        private int age;

        public Passenger() : this("-", "-", 1) { }

        public Passenger(string name, string firstName, int age)
        {
            if (IsValidAge(age) && IsValidName(name) && IsValidFirstName(firstName))
            {
                this.Name = name;
                this.FirstName = firstName;
                this.Age = age;
            } else
            {
                this.Name = "-";
                this.FirstName = "-";
                this.Age = 1;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (IsValidName(value))
                {
                    name = value;
                }
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (IsValidFirstName(value))
                {
                    firstName = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (IsValidAge(value))
                {
                    age = value;
                }
            }

        }

        public void Print()
        {
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nВозраст: {2}", Name, FirstName, Age);
        }

        public void UserInput()
        {
            Console.WriteLine("Введите...");

            Console.WriteLine("Имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Фамилию: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Возраст: ");
            int age;
            try
            {
                age = int.Parse(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Возраст должен быть введён цифрой!");
            }

            if (IsValidName(name) && IsValidFirstName(firstName) && IsValidAge(age))
            {
                this.name = name;
                this.firstName = firstName;
                this.age = age;
            }
            else
            {
                throw new Exception("Ошибка ввода!");
            }
        }

        private bool IsValidAge(int age)
        {
            return age > 0;
        }

        private bool IsValidName(string name)
        {
            return name.Trim().Length > 0;
        }

        private bool IsValidFirstName(string firstName)
        {
            return firstName.Trim().Length > 0;
        }

    }
}
