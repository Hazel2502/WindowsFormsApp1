using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, este es mi primera calculadora");
        }

        private void comboOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Num1 = double.Parse(txtNum1.Text);
            double Num2 = double.Parse(txtNum2.Text);

            string ItemSelected = comboOperaciones.Text;

            switch (ItemSelected)
            {
                case "Suma":
                    var Suma = Num1 + Num2;
                    MessageBox.Show(Suma.ToString());
                    break;

                case "Resta":
                    var Resta = Num1 - Num2;
                    MessageBox.Show(Resta.ToString());
                    break;

                case "Multiplicación":
                    var Multiplicación = Num1 * Num2;
                    MessageBox.Show(Multiplicación.ToString());
                    break;

                case "División":
                    var Divisición = Num1 / Num2;
                    MessageBox.Show(Divisición.ToString());
                    break;
            }
        }
    }
}
