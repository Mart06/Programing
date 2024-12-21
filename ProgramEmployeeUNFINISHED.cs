internal class Program
{
    private static void Main(string[] args)
    {

    }
    public class Employee 
    {
        public string name;
        public string position;
        public double salary;

        public Employee(string name, string position, double salary)
        {
            this.name = name;
            this.position = position;   
            this.salary = salary;   
        }

        public void Info()
        {
            Console.WriteLine($"Employee's name: {name} \n Possition: {position} \n Salary: {salary}");
        }

        public class Manager : Employee
        {
            public string team;
        }
    }

}