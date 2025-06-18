namespace Shape_control_system
{
    internal class Program
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

        static void Main(string[] args)
        {
            Program program = new Program(); 

            foreach (Shape shape in program.shapes)
            {
                Console.WriteLine(shape);
            }

            Console.WriteLine($"Total area : {TotalArea(program)} cm²");

            ListAfterArea(program);
            foreach (Shape shape in program.shapes)
            {
                Console.WriteLine(shape);
            }

            ListAfterColor(program);
            foreach (Shape shape in program.shapes)
            {
                Console.WriteLine(shape);
            }
        }

        static int TotalArea(Program program)
        {
            int area = 0;

            foreach (var shape in program.shapes)
            {
                area += shape.BeregnAreal();
            }

            return area;
        }

        static void ListAfterArea(Program program)
        {
            program.shapes.Sort((a,b)=> a.Area.CompareTo(b.Area));
        }

        static void ListAfterColor(Program program)
        {
            program.shapes.Sort((a,b)=> a.Color.CompareTo(b.Color));
        }


    }
}
