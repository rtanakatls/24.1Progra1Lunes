using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1
{
    internal class ShapeController
    {
        public void Execute()
        {
            Menu();
        }

        private void Menu()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Shape shape = null;

                Console.WriteLine("Introduce el número de la figura que quieres calcular el área: ");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Triángulo");
                Console.WriteLine("3. Rectángulo");
                Console.WriteLine("4. Cuadrado");
                Console.WriteLine("5. Salir");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        shape = GetCircle();
                        break;
                    case "2":
                        shape = GetTriangle();
                        break;
                    case "3":
                        shape = GetRectangle();
                        break;
                    case "4":
                        shape = GetSquare();
                        break;
                    case "5":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                if (shape != null)
                {
                    Console.WriteLine($"El área del {shape.Type} es: {shape.GetArea()}");
                }
            }
        }

        private Shape GetTriangle()
        {
            float b;
            float h;

            Console.WriteLine("Introduce el valor de la base del triángulo:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el valor de la altura del triángulo:");
            h = float.Parse(Console.ReadLine());
            Triangle rectangle = new Triangle(b, h);
            return rectangle;
        }

        private Shape GetRectangle()
        {
            float b;
            float h;

            Console.WriteLine("Introduce el valor de la base del rectángulo:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el valor de la altura del rectángulo:");
            h = float.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(b, h);
            return rectangle;
        }

        private Shape GetSquare()
        {
            float l;

            Console.WriteLine("Introduce el valor del lado del cuadrado:");
            l = float.Parse(Console.ReadLine());
            Square square = new Square(l);
            return square;
        }

        private Shape GetCircle()
        {
            float r;

            Console.WriteLine("Introduce el valor del radio del círculo:");
            r = float.Parse(Console.ReadLine());
            Circle circle = new Circle(r);
            return circle;
        }

    }
}
