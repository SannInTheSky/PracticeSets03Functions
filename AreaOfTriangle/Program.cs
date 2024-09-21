namespace AreaOfTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //perimeter
            Console.WriteLine("Length of A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Length of B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Length of C: ");
            double c = Convert.ToDouble(Console.ReadLine());


            //half of perimeter
            double s = (a+b+c)/2;
            Console.WriteLine("Half of Perimeter: "+s);

            //area
            double area = Math.Sqrt(s*(s-a)*(s-b)*(s-c));

            Console.WriteLine("This is the Area of the Triangle: "+area);
        }
    }
}
