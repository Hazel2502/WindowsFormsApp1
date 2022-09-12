using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, si desea hacer el calculo de intereses; seleccione aceptar.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Capital = double.Parse(txtCapital.Text);
            double TDI = double.Parse(txtTDI.Text);
            double Tiempo = double.Parse(txtTiempo.Text);

            string ItemSelected = comboBox1.Text;

            switch (ItemSelected)
            {
                case "Anual":
                    var Anual = Capital * TDI * Tiempo;
                    MessageBox.Show(Anual.ToString());
                    break;
                case "Mensual":
                    var Mensual = Capital * TDI * Tiempo / 12;
                    MessageBox.Show(Mensual.ToString());
                    break;
                case "Diario":
                    var Diario = Capital * TDI * Tiempo / 360;
                    MessageBox.Show(Diario.ToString());
                    break;
            }
        }
    }
}
