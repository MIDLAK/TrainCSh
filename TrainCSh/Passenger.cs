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
            if (IsValidAge(age) && IsValidName(ref name) && IsValidFirstName(ref firstName))
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
                if (IsValidName(ref value))
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
                if (IsValidFirstName(ref value))
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
                OneTwoThree(out age);
                //throw new Exception("Возраст должен быть введён цифрой!");
            }

            if (IsValidName(ref name) && IsValidFirstName(ref firstName) && IsValidAge(age))
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

        private void OneTwoThree(out int age)
        {
            Random randomAge = new Random();
            age = randomAge.Next(1, 100);   //задаётся случайное значение возраста от 1 до 100 лет
        }

        private bool IsValidAge(int age)
        {
            return age > 0;
        }

        private bool IsValidName(ref string name)
        {
            name = name.Trim();
            return name.Length > 0;
        }

        private bool IsValidFirstName(ref string firstName)
        {
            firstName = firstName.Trim();
            return firstName.Length > 0;
        }

    }
}
