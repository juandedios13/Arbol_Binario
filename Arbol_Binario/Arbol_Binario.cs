using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace arbol
{
    class Arbol_Binario
    {

        public Nodo_Arbol Raiz;
        public Nodo_Arbol aux;
        // Constructor por defecto
        public Arbol_Binario()
        {
            aux = new Nodo_Arbol();
        }

        // Constructor con parámetros
        public Arbol_Binario(Nodo_Arbol nueva_raiz)
        {
            Raiz = nueva_raiz;
        }
        // Función para agregar un nuevo nodo (valor) al Árbol Binario.
        public void Insertar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
            }
            else
                
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
        }
        // Función para eliminar un nodo (valor) del Árbol Binario.
        public void Eliminar(int x)
        {
            if (Raiz == null)
                Raiz = new Nodo_Arbol(x, null, null, null);
            else
                Raiz.Eliminar(x, ref Raiz);
        }

        

        //Funcion para buscar un nodo
        public void Buscar(int x )
        {
            if (Raiz != null) { 
                Raiz.buscar(x, Raiz);
            }
        }

        public Nodo_Arbol menor()
        {
            Nodo_Arbol t = Raiz;
            if (Raiz != null) {  
                t = Raiz.Menor(Raiz);
            }
            return t;
        }

        public Nodo_Arbol padre(Nodo_Arbol t)
        {
            if (t != null)
            {
                t = Raiz.Padre;
            }
            return t;
        }

        public Nodo_Arbol mayor()
        {
            Nodo_Arbol t = Raiz;
            if (Raiz != null)
            {
                t = Raiz.mayor(Raiz);
            }
            return t;
        }

        public ArrayList sumar()
        {
            ArrayList lista = new ArrayList();
            lista = Raiz.recorrer(Raiz, lista);
            return lista;
        }

        public ArrayList PreOrden()
        {
            ArrayList lista = new ArrayList();
            lista = Raiz.PreOrden(Raiz, lista);
            return lista;
        }

        public ArrayList PostOrden()
        {
            ArrayList lista = new ArrayList();
            lista = Raiz.PostOrden(Raiz, lista);
            return lista;
        }

        public int altura()
        {
            int x = 0;
            Nodo_Arbol t = Raiz;
            if (Raiz != null)
            {
               x = Raiz.Alturas(Raiz);
            }
            return x;
        }

        public int Nsiguiente(int x)
        {
            Nodo_Arbol t = Raiz;

            if (Raiz != null)
            {
                x = Raiz.Nsiguiente(Raiz,x);
            }
            return x;
        }

        // ******** Funciones para el dibujo del Árbol Binario en el Formulario **************
        // Función que dibuja el Árbol Binario
        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush
        RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            int x = 400; // Posiciones de la raíz del árbol
            int y = 75;
            if (Raiz == null) return;
            Raiz.PosicionNodo(ref x, y); //Posicion de todos los Nodos
            Raiz.DibujarRamas(grafo, Lapiz); //Dibuja los Enlaces entre nodos
                                             //Dibuja todos los Nodos

            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }

        


        public int x1 = 400; // Posiciones iniciales de la raíz del árbol
        public int y2 = 75;


        // Función para Colorear los nodos
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente,
        Pen Lapiz, Nodo_Arbol Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;
            if (inor == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor,
                    preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor,
                    preor);
                }
            }
            else if (preor == true)
            {
                if (Raiz != null)
                {
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post,
                    inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post,
                    inor, preor);
                }
            }
            else if (post == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post,
                    inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post,
                    inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                }
            }
        }

        string Orden;
        public void recorrerEnOrden()
        {
            Orden = "Orden: ";
            if (Raiz != null)
            {
                enOrden(Raiz);
                MessageBox.Show(Orden);
            }
        }

        public void enOrden(Nodo_Arbol nodo)
        {
            if (nodo != null)
            {
                enOrden(nodo.Izquierdo);
                Orden += nodo.info + ", ";
                enOrden(nodo.Derecho);
            }
        }

        string postOrden;
        public void recorrerpostOrden()
        {
            postOrden = "postOrden: ";
            if (Raiz != null)
            {
                enPostOrden(Raiz);
                MessageBox.Show(postOrden);
            }
        }

        public void enPostOrden(Nodo_Arbol nodo)
        {
            if (nodo != null)
            {
                enPostOrden(nodo.Izquierdo);
                enPostOrden(nodo.Derecho);
                postOrden += nodo.info + ", ";
            }
        }

        string preOrden;
        public void recorrerPreOrden()
        {
            preOrden = "preOrden: ";
            if (Raiz != null)
            {
                enPreOrden(Raiz);
                MessageBox.Show(preOrden);
            }
        }

        public void enPreOrden(Nodo_Arbol nodo)
        {
            if (nodo != null)
            {
                preOrden += nodo.info + ", ";
                enPreOrden(nodo.Izquierdo);
                enPreOrden(nodo.Derecho);
            }
        }

    }

}
