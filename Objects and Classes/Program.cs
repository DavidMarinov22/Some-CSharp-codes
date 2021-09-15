using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Family
    {
        public Family()
        {
            familiq = new List<Person>();
        }
        public List<Person> familiq { get; set; }
        public void AddMember(Person member)
        {
            familiq.Add(member);
        }
        public Person GetOldestMember()
        {
            Person oldestPerson = familiq.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestPerson;
        }
    }
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family() { };

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(' ');
                Person person = new Person(info[0], int.Parse(info[1]));
                family.AddMember(person);
            }

            if (family.familiq.Count > 0)
            {
                Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
            }
        }
    }
}
