using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra1
{
    internal class Controller
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
                Console.WriteLine("3. Salir");
                string option= Console.ReadLine();
                switch (option)
                {
                    case "1":
                        shape = GetCircle();
                        break;
                    case "2":
                        shape = GetTriangle();
                        break;
                    case "3":
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

        private Circle GetCircle()
        {
            float r;

            Console.WriteLine("Introduce el valor del radio del círculo:");
            r = float.Parse(Console.ReadLine());
            Circle circle = new Circle(r);
            return circle;
        }

        private Triangle GetTriangle()
        {
            float b;
            float h;
            Console.WriteLine("Introduce el valor de la base del triángulo:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el valor de la altura del triángulo:");
            h = float.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(b, h);
            return triangle;
        }
    }
}
