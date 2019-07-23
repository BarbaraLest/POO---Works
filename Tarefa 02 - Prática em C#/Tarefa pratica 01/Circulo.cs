using System;
using System.Collections.Generic;
using System.Text;

namespace Tarefa_pratica_01
{
    class Circulo
    {
        public double raio { get; set; }
        public  double area { get; set; }
        public  double comprimento { get; set; }
        private double pi = 3.14;

        public double Area(double r)
        {
           
            
            area = r * r * pi;
            return area;


        }

        public double Comprimento(double r)
        {
           
            comprimento = 2 * pi * r;

            return comprimento;

        }


    }


}
