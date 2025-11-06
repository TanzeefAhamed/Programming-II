namespace InheritanceShapesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = 2;
            double width = 3;
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Square($"square - length: {length}", length));
            shapes.Add(new Circle($"circle - radian: {length}", length));
            shapes.Add(new Rectangle($"rectangle - width: {length}, length: {width}", length, width));
            shapes.Add(new Triangle($"triangle - base: {length}, height: {width}", length, width));

            length *= 2;
            width *= 2;

            shapes.Add(new Triangle($"triangle - base: {length}, height: {width}", length, width));
            shapes.Add(new Square($"square - length: {length}", length));
            shapes.Add(new Circle($"circle - radian: {length}", length));
            shapes.Add(new Rectangle($"rectangle - width: {length}, length: {width}", length, width));
            shapes.Add(new Ellipse($"ellipse - miA: {length}, mjA: {width}", length, width));
            shapes.Add(new Diamond($"diamond - miA: {length}, mjA: {width}", length, width));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }

            Console.ReadKey();
        }
    }

    abstract class Shape
    {
        private string name;
        protected Shape(string name) { this.name = name; }
        public abstract double Area { get; }
        public override string ToString() => $"\n{name}: {Area:F2}\n";
    }

    class Square : Shape
    {
        public double Length { get; }
        public Square(string name, double length) : base(name) { Length = length; }
        public override double Area => Length * Length;
    }

    class Circle : Square
    {
        public Circle(string name, double length) : base(name, length) { }
        public override double Area => Math.PI * Length * Length;
    }

    class Rectangle : Shape
    {
        public double Width { get; }
        public double Length { get; }
        public Rectangle(string name, double length, double width) : base(name)
        {
            Length = length;
            Width = width;
        }
        public override double Area => Width * Length;
    }

    class Ellipse : Rectangle
    {
        public Ellipse(string name, double length, double width) : base(name, length, width) { }
        public override double Area => Math.PI * Width * Length;
    }

    class Triangle : Rectangle
    {
        public Triangle(string name, double length, double width) : base(name, length, width) { }
        public override double Area => 0.5 * Width * Length;
    }

    class Diamond : Rectangle
    {
        public Diamond(string name, double length, double width) : base(name, length, width) { }
        public override double Area => Width * Length;
    }
}
