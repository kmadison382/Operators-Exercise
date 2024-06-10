namespace OperatorExercise
{
    public class Program
    { 
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }


        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int diff = a - b;
            int prod = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}+{b} is {sum}.");
            Console.WriteLine($"{a}-{b} is {diff}.");
            Console.WriteLine($"{a}*{b} is {prod}.");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius {radius} is {area}");

            //Thought exercise: The value of k is 16

            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine($"k equals {k}");
        }
    }
}
