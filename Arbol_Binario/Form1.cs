using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaración de variables a utilizar
        int Dato = 0;
        int cont = 0;
        Nodo_Arbol aux;
        Arbol_Binario mi_Arbol = new Arbol_Binario(null); // Creación del objeto Árbol
        Graphics g;


        private void Form1_Load(object sender, EventArgs e)
        {

        } 
        

        // Evento que permitirá insertar un nodo al Árbol (código del botón “Insertar Nodo” del
        //formulario mostrado en la figura

        private void Form1_Paint_1(object sender, PaintEventArgs en)
        {
            en.Graphics.Clear(this.BackColor);
            en.Graphics.TextRenderingHint =
            System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = en.Graphics;

                mi_Arbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black,
                Brushes.White);
            
            
            
        }

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            if (txtDatoEliminar.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtDatoEliminar.Text);
                if (Dato <= 0 || Dato >= 100)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso");
                else
                {
                    
                    mi_Arbol.Eliminar(Dato);
                    txtDato.Clear();
                    txtDato.Focus();
                    Refresh();
                    Refresh();
                }
            }
        }

        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            if (txtDatoBuscar.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtDatoBuscar.Text);
                if (Dato <= 0 || Dato >= 100)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso");
                else
                {
                    mi_Arbol.Buscar(Dato);
                    txtDato.Clear();
                    txtDato.Focus();
                }
            }
        }

        private void Menor_Click(object sender, EventArgs e)
        {
            aux = mi_Arbol.menor();
            MessageBox.Show("El nodo menor es: " + aux.info);
        }

        private void Mayor_Click(object sender, EventArgs e)
        {
            aux = mi_Arbol.mayor();
            MessageBox.Show("El nodo mayor es: " + aux.info);
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            lista = mi_Arbol.sumar();
            int suma = 0;
            foreach (var nodos in lista)
            {
                suma = suma + Convert.ToInt32(nodos);
            }

            sumatoria.Text = suma.ToString();
        }

        private void m2_Click(object sender, EventArgs e)
        {
            
        }

        private void Altura_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = mi_Arbol.altura();
            textbox5.Text = a.ToString();
        }

        int m, mx, my;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            if (txtDato.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtDato.Text);
                if (Dato <= 0 || Dato >= 100)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso");
                else
                {
                    mi_Arbol.Insertar(Dato);
                    txtDato.Clear();
                    txtDato.Focus();
                    cont++;
                    Refresh();
                    Refresh();
                }
            }
        }

        private void Orden(object sender, EventArgs e)
        {
            mi_Arbol.recorrerEnOrden();
        }

        private void postOrden(object sender, EventArgs e)
        {
            mi_Arbol.recorrerpostOrden();
        }

        private void preOrden(object sender, EventArgs e)
        {
            mi_Arbol.recorrerPreOrden();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            lista = mi_Arbol.sumar();
            int suma = 0;
            int dato = int.Parse(comboBox1.SelectedItem.ToString());
            foreach (var nodos in lista)
            {
                if (Convert.ToInt32(nodos) % dato == 0)
                {
                    suma = suma + Convert.ToInt32(nodos);
                }
            }
            MessageBox.Show("Los sumatoria de los multiplos de " + dato + " en el árbol es: " + suma.ToString());
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
    }
}
