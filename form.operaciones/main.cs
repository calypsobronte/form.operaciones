using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace form.operaciones
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblAutor_Click(object sender, EventArgs e)
        {

        }

        private void btnFormGrl_Click(object sender, EventArgs e)
        {
            /*Ir al Form de Formula General*/
            this.Hide();
            formulaGeneral formGrl = new formulaGeneral();
            formGrl.Show();
        }

        private void btnArriendo_Click(object sender, EventArgs e)
        {
            /*Ir al Form de Arriendos calculandole el 8% de aumento*/
            this.Hide();
            Arriendos Arriendos = new Arriendos();
            Arriendos.Show();
        }

        private void btnDivisas_Click(object sender, EventArgs e)
        {
            /*Ir al Form de Arriendos calculandole el 8% de aumento*/
            this.Hide();
            Divisas Divisas = new Divisas();
            Divisas.Show();
        }
    }
}
