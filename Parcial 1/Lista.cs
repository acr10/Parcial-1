using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_1
{
    class Lista
    {
        public nodo inicio;
        public nodo final;

        public Lista()
        {
            inicio = null;
            final = null;
        }

        public void Insertar()
        {
            
               

        }
          
            
        
        public void Mostrar()
        {
           Console.WriteLine();
            }
           
        }
       
       = act.info;
                            act.info = siguiente.info;
                            siguiente.info = temp;
                            act = act.sig;
                            siguiente = siguiente.sig;
                        }
                        else
                        {

                            act = act.sig;
                            siguiente = siguiente.sig;

                        }
                    }
                    t++;
                } while (t <= Cantidad());

            }

        }

        public void Sumatoria()
        {
            nodo actual = new nodo();
            int cantidad = 0;
            actual = inicio;
            while(actual != null)
            {
                cantidad = cantidad + actual.info;
                actual = actual.sig;
            }
            Console.WriteLine("La suma total de los valores de los nodos es: {0}", cantidad);
        }
        public void BorrarPorPosicion(int pos)
        {
            if(inicio == null)
            {
                Console.WriteLine("LA LISTA ESTA VACIA");

            }
            else
            {

                if (pos <= Cantidad())
                {
                    if (pos == 1)
                    {
                        inicio = inicio.sig;
                        if (inicio != null)
                        {
                            inicio.ant = null;
                        }
                        Console.WriteLine("Posicion borrada");
                    }
                    else
                    {
                        nodo actual = new nodo();
                        actual = inicio;
                        for (int f = 1; f <= pos - 2; f++)
                        {
                            actual = actual.sig;
                        }

                        nodo prox = actual.sig;
                        prox = prox.sig;
                        actual.sig = prox;

                        if (prox != null)
                        {
                            prox.ant = actual;
                        }
                        Console.WriteLine("Posicion borrada");
                    }
                }
                else
                {
                    nodo ant = new nodo();
                    nodo post = new nodo();
                    post = inicio;
                    ant = inicio;
                    while (post.sig != null)
                    {
                        ant = post;
                        post = post.sig;
                    }
                    ant.sig = null;
                    final = ant;
                    Console.WriteLine("Posicion no encontrada, se elimino la posicion final");
                }
            }
            
            
           
        }

        public int Cantidad() //metodo que cuenta la cantidad de nodos que hay
        {
            int cant = 0;
            nodo cuenta = inicio;
            while (cuenta != null)
            {
                cuenta = cuenta.sig;
                cant++;
            }
            return cant;
        }
    }
}
