namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;


            Console.WriteLine($"A: 17");
            Console.WriteLine($"B: 4");

            Console.WriteLine($"A plus B = {a + b}.");

            Console.WriteLine($"A minus B = {a - b}.");

            Console.WriteLine($"A times B = {a * b}.");

            Console.WriteLine($"A ({a}) divided by B ({4}) = {a / b} with remainder of {a % b}.");
            Console.WriteLine();
           
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            
            double areaOfCircle = Math.PI * Math.Pow(radius , 2);
            Console.WriteLine($"The area of your circle with a radius of {radius} is {areaOfCircle}");

        }
    }
}
