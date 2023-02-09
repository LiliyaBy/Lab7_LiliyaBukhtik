namespace Lab7_LiliyaBukhtik
{
    internal class Program
    {
        static void Main()
        {
            Figures [] figures = { new Triangle(), new Rectangle(), new Circle() };

            foreach (var figure in figures) 
            {
                Console.WriteLine($"Perimeter {figure.GetType().Name} = {figure.CalculatePerimeter()}");
                Console.WriteLine($"Area {figure.GetType().Name} = {figure.CalculateArea()}");
            }

        }
    }
}