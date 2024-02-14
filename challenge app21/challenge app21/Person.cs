

namespace challenge_app21
{
    public abstract class Person
    {
        public Person(string name, string surname, string sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }

        
        public Person (string name)
            :this (name, "empty", "empty", -1)
        {

        }

        public Person(string name, string surname)
            : this(name, surname, "empty", -1)
        {

        }

        public Person(string name, string surname, string sex)
            : this(name, surname, sex, -1)
        {
            
        }
        

        public string Name { get; private set; }
        public string Surname { get;  private set; }
        public string Sex { get; private set; }
        public int Age { get; private set; }
    }
}
