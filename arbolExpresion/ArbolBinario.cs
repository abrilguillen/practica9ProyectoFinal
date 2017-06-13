using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolExpresion
{
    class ArbolBinario
    {
        private Nodo _raiz;

        public ArbolBinario(string expresion)
        {
            iniciarParseo(expresion);
        }

        public void iniciarParseo(string ecuacion)
        {
            _raiz = new Nodo();

            if(tieneOperador(ecuacion))
            {
                string[] info = new string[3];//se guardan las tres cadenas
                //en la posicion 1 el operador,2, la parte izq, 3la parte derecha
                //se valida si la ecuacion tiene una suma o una resta
                if(tieneSumaResta(ecuacion))
                {
                    //-1 por la posicion de la cadena que empieza desde 0
                    //va detras para adelante
                    for(int i = ecuacion.Length -1; i >= 0; i--)
                    {
                        //se evalua 
                        if(ecuacion[i] == '+' || ecuacion[i] == '-')
                        {
                            info[0] = ecuacion.Substring(i, 1);
                            info[1] = ecuacion.Substring(0, i);//en la parta izq
                            info[2] = ecuacion.Substring(i + 1, ecuacion.Length - 1 - i);//parte derecha
                            //"3*5+6*2*1"
                      //pos // 012345678
                            //info[0] = encuentra el +
                            //info[1] = la parte izq
                            //info[3] = (+ +6), ecuacion.Length - 1(9-1 = 8), -i (8-3=5)*2*1
                            break; 
                        }
                    }
                }
                else // Si es multiplicacion o division
                {
                    for (int i = ecuacion.Length - 1; i >= 0; i--)
                    {
                        if (ecuacion[i] == '*' || ecuacion[i] == '/')
                        {
                            info[0] = ecuacion.Substring(i, 1);
                            info[1] = ecuacion.Substring(0, i);
                            info[2] = ecuacion.Substring(i + 1, ecuacion.Length - 1 - i);
                            break;
                        }
                    }
                }

                // continua el algoritmo
                _raiz.expresion = info[0]; // el operador

                _raiz.izquierda = new Nodo();
                _raiz.derecha = new Nodo();

                parse(_raiz.izquierda, info[1]);
                parse(_raiz.derecha, info[2]);
            }
            else
            {
                _raiz.expresion = ecuacion;
            }
        }

        public void parse(Nodo nodo, string ecuacion)
        {
            if (tieneOperador(ecuacion))
            {
                string[] info = new string[3];//se guardan las tres cadenas
                //en la posicion 1 el operador,2, la parte izq, 3la parte derecha
                //se valida si la ecuacion tiene una suma o una resta
                if (tieneSumaResta(ecuacion))
                {
                    //-1 por la posicion de la cadena que empieza desde 0
                    //va detras para adelante
                    for (int i = ecuacion.Length - 1; i >= 0; i--)
                    {
                        //se evalua 
                        if (ecuacion[i] == '+' || ecuacion[i] == '-')
                        {
                            info[0] = ecuacion.Substring(i, 1);
                            info[1] = ecuacion.Substring(0, i);//en la parta izq
                            info[2] = ecuacion.Substring(i + 1, ecuacion.Length - 1 - i);//parte derecha
                            break;
                        }
                    }
                }
                else // Si es multiplicacion o division
                {
                    for (int i = ecuacion.Length - 1; i >= 0; i--)
                    {
                        if (ecuacion[i] == '*' || ecuacion[i] == '/')
                        {
                            info[0] = ecuacion.Substring(i, 1);
                            info[1] = ecuacion.Substring(0, i);
                            info[2] = ecuacion.Substring(i + 1, ecuacion.Length - 1 - i);
                            break;
                        }
                    }
                }

                // continua el algoritmo
                nodo.expresion = info[0]; // el operador

                nodo.izquierda = new Nodo();
                nodo.derecha = new Nodo();

                parse(nodo.izquierda, info[1]);
                parse(nodo.derecha, info[2]);
            }
            else
            {
                nodo.expresion = ecuacion;
            }
        }

        public bool tieneSumaResta(string str)
        {
            str = str.ToLower();

            if(str.Contains("+") || str.Contains("-"))
            {
                return true;
            }
            return false;
        }

        public bool tieneMultDivision(string str)
        {
            str = str.ToLower();

            if( str.Contains("*") || str.Contains("/"))
            {
                return true;
            }
            return false;
        }

        public bool tieneOperador(string str)
        {
            if (tieneSumaResta(str) || tieneMultDivision(str))
            {
                return true;
            }

            return false;
        }

        public string preOrden()//raiz-der-izq
        {
            if (_raiz != null)
            {
                return _preOrden(_raiz);
            }
            return "no hay nada";
        }

        private string _preOrden(Nodo padre)
        {
            string numerosPre = " ";

            numerosPre += padre.expresion + ",";

            if (padre.izquierda != null)//va recorriendo todos los izquierdos
            {
                numerosPre += _preOrden(padre.izquierda);
            }

            if (padre.derecha != null)//aqui ya está en los de la derecha
            {
                numerosPre += _preOrden(padre.derecha);
            }
            return numerosPre;
        }

        public string postOrden()//izq- der - raiz
        {
            if (_raiz != null)
            {
                return _postOrden(_raiz);
            }
            return "no hay nada";
        }

        private string _postOrden(Nodo padre)
        {
            string numerosPost = " ";

            if (padre.izquierda != null)//va recorriendo todos los izquierdos
            {
                numerosPost += _postOrden(padre.izquierda);
            }

            if (padre.derecha != null)//aqui ya está en los de la derecha
            {
                numerosPost += _postOrden(padre.derecha);
            }

            numerosPost += padre.expresion + ",";//aqui ya llegó a la raíz

            return numerosPost;
        }

        public Stack<string> convertirAPilaConPreOrder()
        {
            Stack<string> pila = new Stack<string>();

            _convertirPreOrden(_raiz, pila);

            return pila;
        }

        private void _convertirPreOrden(Nodo nodo, Stack<string> pila)
        {
            pila.Push(nodo.expresion);

            if(nodo.izquierda != null)
            {
                _convertirPreOrden(nodo.izquierda, pila);
            }

            if(nodo.derecha != null)
            {
                _convertirPreOrden(nodo.derecha, pila);
            }
        }

        public Queue<string> convertirAColaConPostOrder()
        {
            Queue<string> cola = new Queue<string>();

            _convertirPostOrden(_raiz, cola);

            return cola;
        }

        private void _convertirPostOrden(Nodo nodo, Queue<string> cola)
        {
            if(nodo.izquierda != null)
            {
                _convertirPostOrden(nodo.izquierda, cola);
            }
            if(nodo.derecha != null)
            {
                _convertirPostOrden(nodo.derecha, cola);
            }

            cola.Enqueue(nodo.expresion);
        }
    }
}
