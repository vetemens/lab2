public class Employee
{
    string name;
    string lastname;
    DateTime experience;
    double salary;
    public string Name { get; set; }
    public string Surname { get; set; }
    public enum Position
    {
        Worker = 10000,
        Secretary = 20000,
        Chief = 50000,
    }
    public DateTime Experience
    {
        get
        {
            return experience;
        }
        set
        {
            if (experience.Date < DateTime.Parse("01.01.1995"))
            {
                experience = value;
            }
            else
            {
                Console.WriteLine("Date before times!");
            }

        }
    }

    public Employee(string name, string lastname, DateTime experience)
    {
        Name = name;
        Surname = lastname;
        Experience = experience;
    }

    public double DiscoverGrade(DateTime experience)
   
    {
        double ValueOfExperience = (DateTime.Now - experience).TotalDays;

        if (ValueOfExperience >= 2920 && ValueOfExperience < 3650)
            return 1.3;
        else if (ValueOfExperience >= 3650 )
            return 1.6;
        else
            return 1.0;
    }

    public double Calculation(Position position)
    
    {
        double grade = DiscoverGrade(experience);
        switch (position)
        {
            case Position.Worker:
                salary = 10000 * grade;
                return salary;
            case Position.Secretary:
                salary = 20000 * grade;
                return salary;
            case Position.Chief:
                salary = 50000 * grade;
                return salary;
                

        }
        return 0.0;
    }
}
class Employee
{
    static void Main(string[] args)
    {
        Employee one = new Employee("Daniel", "Backham", DateTime.Parse("01.02.2020"));
        Console.WriteLine("Name is {0}, Surname is {1}. Position is {2}.", one.Name, one.Surname, Employee.Position.Chief);
        double salary = one.Calculation(Employee.Position.Chief);
        Console.WriteLine("Salary is {0}, tax is {1}", salary, salary * 0.18);
    }
}
