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
    public partial class formulaGeneral : Form
    {
        public formulaGeneral()
        {
            InitializeComponent();
        }

        double a1, b1, c1, result;

        private void clear_Click(object sender, EventArgs e)
        {
            txtbA.Text = "";
            txtbB.Text = "";
            txtbC.Text = "";
            txtResult.Text = "";
        }

        private void main_Click(object sender, EventArgs e)
        {
            /*Volver a nuestra pagina principal*/
            this.Hide();
            main main = new main();
            main.Show();
        }

        private void btnCalOpe_Click(object sender, EventArgs e)
        {
            /*Ingreso de Datos*/
            a1 = Convert.ToDouble(txtbA.Text);
            b1 = Convert.ToDouble(txtbB.Text);
            c1 = Convert.ToDouble(txtbC.Text);

            /*Condicional para no tener errores al hacer la division*/
            if (4 * a1 * c1 > b1 * b1)
            {
                MessageBox.Show("No tiene solucion, ya que, 4ac es mayor que b*b");
            }
            else
            {
                if (a1 ==0){
                    MessageBox.Show("La division por Cero(0) no se puede realizar. Ingrese otro valor.");
                }
                else
                {
                    result = (-b1 + Math.Sqrt((b1 * b1)-(4*a1*c1)))/(2/a1);
                    txtResult.Text = Convert.ToString(result);
                }
            }
        }
    }
}
