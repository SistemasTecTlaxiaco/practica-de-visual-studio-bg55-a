using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Grafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
          restaurar.Visible = true;
        }

        private void minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void restaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }

        private void cerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsesion_Click(object sender, EventArgs e)
        {
            submenu.Visible = true;
        }

        private void iniciarsesion_Click(object sender, EventArgs e)
        {
            submenu.Visible = false;
        }

        private void crear_Click(object sender, EventArgs e)
        {
            submenu.Visible = false;
        }

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            submenu.Visible = false;
        }
    }
}
