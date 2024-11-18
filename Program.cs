namespace Assignment_3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Input the value for X coordinate: "); 
            int x = int.Parse(Console.ReadLine()); 
            // Input the value for Y coordinate
            Console.Write("Input the value for Y coordinate: "); 
            int y = int.Parse(Console.ReadLine()); 
            string quadrant = FindQuadrant(x, y); 
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the {quadrant}."); 
        } 
        static string FindQuadrant(int x, int y) 
        { 
            if (x > 0 && y > 0) 
            { 
                return "First quadrant"; 
            } 
            else if (x < 0 && y > 0) 
            { 
                return "Second quadrant"; 
            } 
            else if (x < 0 && y < 0) 
            { 
                return "Third quadrant"; 
            } 
            else if (x > 0 && y < 0) 
            { 
                return "Fourth quadrant"; 
            } 
            else if (x == 0 && y != 0) 
            { 
                return "Y-axis"; 
            } 
            else if (y == 0 && x != 0) 
            { 
                return "X-axis"; 
            } 
            else 
            { 
                return "Origin"; 
            }
		}
    }
}
