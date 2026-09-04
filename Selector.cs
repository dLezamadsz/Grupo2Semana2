using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo2Semana2
{
    internal class Selector
    {

        private List<Shape> shapes;


        public void Seleccionar()
        {


            bool loop = true;

            shapes = new List<Shape>();

            while (loop)
            {

                Console.WriteLine("1 - Area Rectangulo");
                Console.WriteLine("2 - Area Cuadrado");
                Console.WriteLine("3 - Area Circulo");
                Console.WriteLine("4 - Area triangulo");
                Console.WriteLine("5 - Ver figuras");
                Console.WriteLine("Ingrese un numero del 1 al 5: ");

                int numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Elegiste el valor de la altura");

                        float al = float.Parse(Console.ReadLine());

                        Console.WriteLine("Elegiste el valor de la base");

                        float b = float.Parse(Console.ReadLine());

                        Rectangulo r = new Rectangulo(b, al);
                        Console.WriteLine($"Rectangulo: {r.GetArea()}");
                        shapes.Add(r);

                        break;
                    case 2:
                        Console.WriteLine("Elige un valor para obtener el area");

                        float aC = float.Parse(Console.ReadLine());

                        Circulo cu = new Circulo(aC);
                        Console.WriteLine($"Circulo: {cu.GetArea()}");
                        shapes.Add(cu);

                        break;
                    case 3:
                        Console.WriteLine("Elige un valor del radio");

                        float a = float.Parse(Console.ReadLine());

                        Circulo c = new Circulo(a);
                        Console.WriteLine($"Circulo: {c.GetArea()}");
                        shapes.Add(c);
                        break;
                    case 4:
                        Console.WriteLine("Elegiste el valor de la altura");

                        float alT = float.Parse(Console.ReadLine());

                        Console.WriteLine("Elegiste el valor de la base");

                        float bT = float.Parse(Console.ReadLine());

                        Triangulo T = new Triangulo(bT, alT);
                        Console.WriteLine($"Triangulo: {T.GetArea()}");
                        shapes.Add(T);

                        break;
                    case 5:
                        Console.WriteLine("Mostrando Lista: ");

                        for (int i = 0; i < shapes.Count; i++)
                        {
                            Shape s = shapes[i];

                            if (s is Rectangulo)
                            {
                                Console.WriteLine($"Rectangulo: {s.GetArea()}");
                            }
                            else if (s is Cuadrado)
                            {
                                Console.WriteLine($"Cuadrado: {s.GetArea()}");
                            }
                            else if (s is Circulo)
                            {
                                Console.WriteLine($"Circulo: {s.GetArea()}");
                            }
                            else if (s is Triangulo)
                            {
                                Console.WriteLine($"Triangulo: {s.GetArea()}");
                            }
                        }

                        break;
                    default:

                        loop = false;
                        Console.WriteLine("Termino");
                        break;

                }

                Console.WriteLine("Seguir? Y/N");

                string S = Console.ReadLine();

                if (S == "N" || S == "n")
                {
                    loop = false;
                }

            }






        }


    }
}
