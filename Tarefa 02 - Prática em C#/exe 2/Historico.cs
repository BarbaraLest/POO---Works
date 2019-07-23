using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_2
{
    class Historico
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }
        public double media { get; set; }
        public string aprovacao { get; set; }


        public double Media(double n1, double n2, double n3, double n4)
        {
            media = (n1 + n2 + n3 + n4) / 4;


            return media;
        }

        public string Aprovacao(double media)
        {
            if(media>=7.0)
            { aprovacao = "aprovado"; }
            else { aprovacao = "reprovado"; }

            return aprovacao;
        }
        

    }

   
}
