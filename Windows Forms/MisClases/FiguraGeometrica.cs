using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms.MisClases
{
    public class FiguraGeometrica
    {
        public string nombre;
    }
    public class Triangulo : Poligono
    {
        double Poligono.area(double valor1, double valor2)
        {
            throw new NotImplementedException();
        }
    }
    public class Rectangulo : Poligono
    {
        double Poligono.area(double valor1, double valor2)
        {
            throw new NotImplementedException();
        }
    }
    public class Paralelogramo : Poligono
    {
        double Poligono.area(double valor1, double valor2)
        {
            throw new NotImplementedException();
        }
    }
}
