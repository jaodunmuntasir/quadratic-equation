namespace quadratic_equation_solver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In the equation a*x^2 + b*x + c = 0");
            Console.Write("the value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("the value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("the value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = Convert.ToDouble((Math.Pow(b, 2)) - (4 * a * c));

            if (discriminant < 0)
            {
                Console.WriteLine("The equation has no solution.");
            }
            else if (discriminant == 0)
            {
                double x = ((-b) + (Math.Sqrt(discriminant))) / (2 * a);  //(Math.Pow(b, 2)) - (4 * a * c))
                Console.WriteLine("The equation has a solution, x = {0}", x);
            }
            else if (discriminant > 0)
            {
                double x1 = ((-b) + (Math.Sqrt(discriminant))) / (2 * a);
                double x2 = ((-b) - (Math.Sqrt(discriminant))) / (2 * a);
                Console.WriteLine("The equation has 2 solutions, x1 = {0} and x2 = {1}", x1, x2);
            }
        }
    }
}
