using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
         private int valor = 0;

        public Disco(int valNuevoDisco){
            valor = valNuevoDisco;
        }
       
        /*TODO: 
        Decidir tipo de Valor
        public int Valor { get; set; }
        public String Valor { get; set; }
        */
        public void setValor(int n){
            (*this).valor = n;
        }
        public int getValor(){
            return (*this).valor;
        }


    }
}
