using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbolExpresion
{
    public partial class Form1 : Form
    {
        private ArbolBinario arbolBinario;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdGenerarArbol_Click(object sender, EventArgs e)
        {
            arbolBinario = new ArbolBinario(txtExpresion.Text);
            txtPre.Text = arbolBinario.preOrden();
            txtPost.Text = arbolBinario.postOrden();
        }

        private void cmdEvaluarPre_Click(object sender, EventArgs e)
        {
            Stack<string> info = arbolBinario.convertirAPilaConPreOrder();
            Stack<double> resultados = new Stack<double>();
            string dato;
            double num1, num2, resultado = 0;
            while(info.Count != 0)
            {
                dato = info.Pop();
                if(arbolBinario.tieneOperador(dato))
                {
                    num1 = resultados.Pop();
                    num2 = resultados.Pop();
                    switch (dato)
                    {
                        case "+":
                            resultado = num1 + num2;
                            break;
                        case "-":
                            resultado = num1 - num2;
                            break;
                        case "*":
                            resultado = num1 * num2;
                            break;
                        case "/":
                            resultado = num1 / num2;
                            break;
                    }
                    resultados.Push(resultado);

                }
                else
                {
                    resultados.Push(double.Parse(dato));
                }
            }

            txtResultadoPre.Text = resultados.Pop().ToString();
        }

        private void cmdEvaluarPost_Click(object sender, EventArgs e)
        {
            Queue<string> info = arbolBinario.convertirAColaConPostOrder();
            Stack<double> resultados = new Stack<double>();
            string dato;
            double num1, num2, resultado = 0;
            while (info.Count != 0)
            {
                dato = info.Dequeue();

                if (arbolBinario.tieneOperador(dato))
                {
                    num2 = resultados.Pop();
                    num1 = resultados.Pop();
                    switch (dato)
                    {
                        case "+":
                            resultado = num1 + num2;
                            break;
                        case "-":
                            resultado = num1 - num2;
                            break;
                        case "*":
                            resultado = num1 * num2;
                            break;
                        case "/":
                            resultado = num1 / num2;
                            break;
                    }
                    resultados.Push(resultado);
                }
                else
                {
                    resultados.Push(double.Parse(dato));
                }
            }

            txtResultadoPost.Text = resultados.Pop().ToString();
        }

    }
}
