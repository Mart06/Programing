internal class Program
{
    private static void Main(string[] args)
    {
        Student s1 = new Student("Iorgovani", 69, 6, 5, 6);
        s1.CalculateAverageGrade();
    }
    public class Student
    {
        public string name;
        public int nubmer;
        private double mathGrade;
        private double engGrade;
        private double bgGrade;

        public Student(string name, int num, double math, double eng, double bg)
        {
            this.name = name;
            this.nubmer = num;
            this.MathGrade = math;
            this.engGrade = eng;
            this.bgGrade = bg;

        }

        public double MathGrade
        {
            get { return mathGrade; }
            set
            {
                if (value > 1 && value <= 6)
                {
                    mathGrade = value;
                }
                else
                {
                    Console.WriteLine($"Incorrect grade");
                }

            }
        }


        public void CalculateAverageGrade()
        {
            double avgGrade = (mathGrade + engGrade + bgGrade) / 3;
            Console.WriteLine($"Average grade is {avgGrade}");
        }

    } 
               
}