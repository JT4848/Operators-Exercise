namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            int y = 20;
            x += y;
            Console.WriteLine(x);

            x = 15;
            y = 10;
            x -= y;
            Console.WriteLine(x);

            int a = 17;
            int b = 4;
            int q = a / b;
            
            
            Console.WriteLine(x);

            x = 50;
            y = 80;
            x *= y;
            Console.WriteLine(x);



            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The radius of the circle is {radius} {Math.Round (area,2)}");






        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
