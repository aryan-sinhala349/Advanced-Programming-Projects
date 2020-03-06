using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People
{
    class Person
    {
        protected string name;
        protected int age;

        protected static Exception empty = new Exception("The given name was empty!");
        protected static Exception zero = new Exception("The given age was 0!");

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "") throw empty;
                name = value;
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
                if (value == 0) throw zero;
                age = value;
            }
        }

        public Person(string name = "Bob", int age = 10)
        {
            Name = name;
            Age = age;
        }

        public void ShowInfo()
        {
            MessageBox.Show(Age.ToString(), name);
        }
    }

    class Worker : Person
    {
        protected float income;

        public float Income
        {
            get
            {
                return income;
            }

            set
            {
                if (value == 0) throw zero;
                income = value;
            }
        }

        public Worker(string name = "Bob", int age = 10, float income = 20000.00f) : base(name, age)
        {
            Income = income;
        }

        public new void ShowInfo()
        {
            MessageBox.Show("Aged " + Age + ", with a yearly income of $" + Income, Name);
        }
    }

    class Politician : Worker, IPolitician
    {
        protected string party;

        public string Party
        {
            get
            {
                return party;
            }

            set
            {
                if (value == "") throw empty;
                party = value;
            }
        }

        //The default party is the None party... because I don't want to reveal my political biases.
        public Politician(string name = "Bob", int age = 30, float income = 20000.00f, string party = "None") : base(name, age, income)
        {
            Party = party;
        }

        public new void ShowInfo()
        {
            MessageBox.Show(Age + " years old, " + Party + " party, makes $" + Income, Name);
        }

        public void Advertise()
        {
            ShowInfo();
            MessageBox.Show("Vote for " + Name + "!", Party + " Party Advertisement");
        }
    }

    interface IPolitician
    {
        void Advertise();
    }
}
