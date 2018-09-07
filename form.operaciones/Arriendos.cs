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
    public partial class Arriendos : Form
    {
        public Arriendos()
        {
            InitializeComponent();
        }
        double a,b,c, result1, result2, result3;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1Arriendo.Text = "";
            txt1AumArri.Text = "";
            txt2Arriendo.Text = "";
            txt2AumArri.Text = "";
            txt3Arriendo.Text = "";
            txt3AumArri.Text = "";
            txtTotal1.Text = "";
            txtTotal2.Text = "";
            txtTotal3.Text = "";
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            /*Volver a nuestra pagina principal*/
            this.Hide();
            main main = new main();
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*Ingreso de datos sobre valores de arriendos*/
            a = Convert.ToDouble(txt1Arriendo.Text);
            b = Convert.ToDouble(txt2Arriendo.Text);
            c = Convert.ToDouble(txt3Arriendo.Text);

            /*Calculemos el aunmento que tendran los arriendos que es de un 8% = 0.08*/
            result1 = a * 0.08;
            result2 = b * 0.08;
            result3 = c * 0.08;

            /*Mostramos el total de los arriendos con el aunmento del 8%*/
            txt1AumArri.Text = Convert.ToString(result1);
            txt2AumArri.Text = Convert.ToString(result2);
            txt3AumArri.Text = Convert.ToString(result3);

            /*Mostramos el Total a pagar juntando nuestro resultado del aunmento + en valor del arriendo*/
            txtTotal1.Text = Convert.ToString(result1 + a);
            txtTotal2.Text = Convert.ToString(result2 + b);
            txtTotal3.Text = Convert.ToString(result3 + c);
        }
    }
}
