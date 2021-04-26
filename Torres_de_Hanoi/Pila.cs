using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public Disco [] pila;

        public Disco getDiscoAt(pos){
            return (*this).pila[pos];
        }

        public int getSize(){
            return (*this).Length; 
        }


        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        /* TODO: Implementar métodos */
        public Pila()
        {
        
        }

        public Pila(Disco[] nuevaPilaDiscos)
        {
            for(int i=0; i<nuevaPilaDiscos.Length;i++){
                pila[i] = nuevaPilaDiscos[i];
            }
        }

        public void push(Disco d)
        {
            (*this).pila[(*this).pila.Length] = d;
        }

        public void pop()
        {
            Array.Clear((*this).pila, (*this).pila[(*this).pila.Length-2], 1;
        }                

        public bool isEmpty()
        {
            if((*this).pila.Length == 0){ 
            return true;
            }
            else{
            return false;
            }
        }

    }
}
