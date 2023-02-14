using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Pr2
{
    class  Vector
    {
        Punto origen;
        Punto fin;
        double magnitud;

        public Vector()
        {
            origen = new Punto(0, 0);
            fin = new Punto(1, 1);
            calcular_magnitud();
        }
        public Vector(Punto _origen, Punto _fin)
        {
            origen = new Punto(_origen.GetX(), _origen.GetY());
            fin = new Punto(_fin.GetX(), _fin.GetY());
            calcular_magnitud();
        }
        public Vector(float x_origen, float y_origen, float x_fin, float y_fin)
        {
            origen = new Punto(x_origen, y_origen);
            fin = new Punto(x_fin, y_fin);
            calcular_magnitud();
        }
        private void calcular_magnitud()
        {
            magnitud = Math.Sqrt(Math.Pow((fin.GetX() - origen.GetX()), 2) + Math.Pow((fin.GetY() - origen.GetY()), 2));
        }
        public double get_magnitud()
        {
            return magnitud;
        }

        public void set_fin(Punto _fin)
        {
            fin = new Punto(_fin.GetX(), _fin.GetY());
            calcular_magnitud();
        }
        public void set_fin(float x, float y)
        {
            fin = new Punto(x, y);
            calcular_magnitud();
        }

        public static Vector operator -(Vector minuendo, Vector sustraendo)
        {
            Punto nuevo_origen = new Punto(minuendo.origen.GetX() - sustraendo.origen.GetX(),
                                 minuendo.origen.GetY() - sustraendo.origen.GetY());

            Punto nuevo_fin = new Punto(minuendo.fin.GetX() - sustraendo.fin.GetX(),
                                minuendo.fin.GetY() - sustraendo.fin.GetY());


            return new Vector(nuevo_origen, nuevo_fin);
        }
    }
}
