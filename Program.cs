namespace Area_Of_Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Side of Square:");
            float x = Single.Parse(Console.ReadLine()); 
            float result = x * x;
            Console.WriteLine("The Area of Square:"+result);
            
        }
    }
}