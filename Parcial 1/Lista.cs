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
            
                nodo auxiliar = new nodo();
                Console.Write("Digite  el valor a ingresar: ");
                int elemento = int.Parse(Console.ReadLine());
                auxiliar.info = elemento;
                auxiliar.sig = null;
                if (inicio == null)
                {
                    inicio = auxiliar;
                    inicio.sig = null;
                    inicio.ant = null;
                    final = inicio;
                    Console.WriteLine("Valor ingresado");
                }
                else
                {
                    if (elemento < inicio.info)
                    {
                        auxiliar.sig = inicio;
                        inicio = auxiliar;
                    }
                    else
                    {
                        nodo aux = inicio;
                        nodo aux2 = null;
                        while (aux.sig != null && aux.sig.info < elemento)
                        {
                            aux = aux.sig;
                        }
                        //if(aux.sig != null)
                        //{
                        //    auxiliar.sig = aux.sig;
                        //}
                        //aux.sig = auxiliar;
                        if (aux.sig == null)
                        {
                            aux.sig = auxiliar;
                            final = auxiliar;

                        }
                        else if (aux.sig.info >= elemento)
                        {
                            aux2 = aux.sig;
                            auxiliar.sig = aux2;
                            aux2.ant = auxiliar;
                            auxiliar.ant = aux;/*aux.sig;*/
                            aux.sig = auxiliar;
                        }
                    }
                    //final.sig = auxiliar;
                    //auxiliar.ant = final;
                    //final = auxiliar;
                }

        }
          
            
        
        public void Mostrar()
        {
            if(inicio == null)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                nodo actual = new nodo();
                actual = inicio;
                while (actual != null)
                {
                    Console.Write(actual.info + "-");
                    actual = actual.sig;
                }
                Console.WriteLine();
            }
           
        }
        public void MostrarAscendente()
        {
            if(inicio == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                int t = 1;
                nodo act = inicio;//Definimos que el apuntador act esta en el primer nodo//

                // guarda el varlor temporal mente
                int temp = 0;
                do
                {
                    act = inicio;//aux esta en el primer nodo
                    nodo siguiente = act.sig;//esta en el siguiente nodo 
                    while (act.sig != null)
                    {
                        if (act.info > siguiente.info) // Compara para luego ordenar
                        {
                            temp = act.info;
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
        public void MostrarDescendente()
        {
            if(inicio == null)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                int t = 1;
                nodo act = new nodo();
                act = inicio;//Definimos que el apuntador act esta en el primer nodo//     

                // guarda el varlor temporal mente
                int temp = 0;
                do
                {
                    act = inicio;//aux esta en el primer nodo
                    nodo siguiente = act.sig;//esta en el siguiente nodo 
                    while (act.sig != null)
                    {
                        if (act.info < siguiente.info) // Compara para luego ordenar
                        {
                            temp = act.info;
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
