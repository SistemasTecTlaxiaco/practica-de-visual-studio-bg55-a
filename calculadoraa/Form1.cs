using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool secuencia = true;
        string operacion, borrado;
        double numero1, numero2, resultado;

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = pantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            pantalla.Text = borrado;
            if (pantalla.Text==""){
                pantalla.Text = "0";
                secuencia = true;

            }
            if (pantalla.Text == "-") {
                pantalla.Text = "0";
                secuencia = true;

            }

        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "1";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "1";
            }
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "2";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "2";
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "3";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "3";
            }
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "4";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "4";
            }
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "5";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "5";
            }
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "6";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "6";
            }
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "7";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "7";
            }
        }

        private void suma_Click(object sender, EventArgs e)
        {
            operacion = "+";
            numero1 = double.Parse(pantalla.Text);
            secuencia = true;
        }

        private void resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numero1 = double.Parse(pantalla.Text);
            secuencia = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = double.Parse(pantalla.Text);
            secuencia = true;
        }

        private void multiplicaion_Click(object sender, EventArgs e)
        {
            operacion = "*";
            numero1 = double.Parse(pantalla.Text);
            secuencia = true;
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(pantalla.Text);
            resultado = Math.Sqrt(numero1);
            pantalla.Text = resultado.ToString();
            secuencia = true;
        }

        private void elevar_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(pantalla.Text);
            resultado = numero1 * numero1;
            pantalla.Text = resultado.ToString();
            secuencia = true;
        }

        private void punto_Click(object sender, EventArgs e)
        {

        }

        private void igual_Click(object sender, EventArgs e)
        {
            numero2 = double.Parse(pantalla.Text);
            if (operacion == "+")
            {
                resultado = numero1 + numero2;
                pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "-")
            {
                resultado = numero1 - numero2;
                pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "*")
            {
                resultado = numero1 * numero2;
                pantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "/")
            {
                resultado = numero1 / numero2;
                pantalla.Text = resultado.ToString();
                secuencia = true;
            }
        }

        private void c_Click(object sender, EventArgs e)
        {
            pantalla.Text = "0";
            numero1 = 0;
            numero2 = 0;
            secuencia = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "8";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "8";
            }
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                pantalla.Text = "";
                pantalla.Text = "9";
                secuencia = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "9";
            }
        }

        private void but0_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                return;
            }
            else
            {
                pantalla.Text = pantalla.Text + "0";
            }
        }
    }
}

