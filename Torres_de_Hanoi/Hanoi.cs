using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if(b.isEmpty(){
                b[0]=a[a.getSize()-1];
                a.pop();
            }

            else if(a[a.getSize()-1].getValor() < b[b.getSize()-1].getValor(){
                b[b.getSize()-1]=a[a.getSize()-1];
                a.pop();
            }

            else{
                return 0;
            }
        }

        public int iterativo(Pila ini, Pila fin, Pila aux)
        {
            int numMov = 0;

            if(ini.getSize()%2 == 0){
                for(int i=0; i=(2^ini.getSize())-1; i++){
                    Hanoi.mover_disco(ini,aux);
                    Hanoi.mover_disco(ini,fin);
                    Hanoi.mover_disco(aux,fin);
                    numMov += 3;
                }

            }
            else{
                for(int i=0; i=(2^ini.getSize())-1; i++){
                    Hanoi.mover_disco(ini,fin);
                    Hanoi.mover_disco(ini,aux);
                    Hanoi.mover_disco(aux,fin);
                    numMov += 3;
                }
            }

            return numMov;
        }

    }
}
