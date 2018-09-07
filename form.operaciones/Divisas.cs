using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form.operaciones
{
    public partial class Divisas : Form
    {
        public Divisas() => InitializeComponent();
        /*Declaracion de Variables*/
        double a, b, c, 
            resulta1, resulta2, resulta3,
            resultb1, resultb2, resultb3,
            resultc1, resultc2, resultc3;

        private void btnMain_Click(object sender, EventArgs e)
        {
            /*Volver a nuestra pagina principal*/
            this.Hide();
            main main = new main();
            main.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDed51.Text = "";
            txtDed52.Text = "";
            txtDed53.Text = "";
            txtDed71.Text = "";
            txtDed72.Text = "";
            txtDed73.Text = "";
            txtDed61.Text = "";
            txtDed62.Text = "";
            txtDed63.Text = "";
            txtTotal51.Text = "";
            txtTotal52.Text = "";
            txtTotal53.Text = "";
            txtTotal71.Text = "";
            txtTotal72.Text = "";
            txtTotal73.Text = "";
            txtTotal51.Text = "";
            txtTotal52.Text = "";
            txtTotal53.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*Convertir el string a numero de los datos ingresados por el usuario*/
            a = Convert.ToDouble(txtDivisa1.Text);
            b = Convert.ToDouble(txtDivisa2.Text);
            c = Convert.ToDouble(txtDivisa3.Text);

            /*Deduccion del 5% = 0.05*/
            resulta1 = a * 0.05;
            resultb1 = b * 0.05;
            resultc1 = c * 0.05;

            /*Deduccion del 7% = 0.07*/
            resulta2 = a * 0.07;
            resultb2 = b * 0.07;
            resultc2 = c * 0.07;

            /*Deduccion del 6% = 0.06*/
            resulta3 = a * 0.07;
            resultb3 = b * 0.07;
            resultc3 = c * 0.07;

            /*Mostrar resultado de la deduccion 5%*/
            txtDed51.Text = Convert.ToString(resulta1);
            txtDed52.Text = Convert.ToString(resultb1);
            txtDed53.Text = Convert.ToString(resultc1);

            /*Mostrar resultado de la deduccion 7%*/
            txtDed71.Text = Convert.ToString(resulta2);
            txtDed72.Text = Convert.ToString(resultb2);
            txtDed73.Text = Convert.ToString(resultc2);

            /*Mostrar resultado de la deduccion 6%*/
            txtDed61.Text = Convert.ToString(resulta3);
            txtDed62.Text = Convert.ToString(resultb3);
            txtDed63.Text = Convert.ToString(resultc3);

            /*Mostrar el total menos las deducciones*/

            /*5%*/
            txtTotal51.Text = Convert.ToString(a -resulta1);
            txtTotal52.Text = Convert.ToString(a - resulta2);
            txtTotal53.Text = Convert.ToString(a - resulta3);

            /*7%*/
            txtTotal71.Text = Convert.ToString(b - resultb1);
            txtTotal72.Text = Convert.ToString(b - resultb2);
            txtTotal73.Text = Convert.ToString(b - resultb3);

            /*6%*/
            txtTotal61.Text = Convert.ToString(c - resultc1);
            txtTotal62.Text = Convert.ToString(c - resultc2);
            txtTotal63.Text = Convert.ToString(c - resultc3);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

      
    }
}
