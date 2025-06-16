namespace Shape_control_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle("blue circle", "blue", 5),
                new Circle("red circle", "red", 3),
                new Rectangle("gray rec", "gray", 3, 4),
                new Rectangle("green rec", "green", 4, 4),
                new Triangle("pink triangle", "pink", 8, 3),
                new Triangle("purple triangle", "purple", 3, 10)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
