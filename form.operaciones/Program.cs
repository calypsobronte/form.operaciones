using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form.operaciones
{
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// Nombres: Lina Maria Montaño Ramirez, Wilmar, 
    ///FECHA (DD/MM/AAAA): 06/09/2018
    /// FUNCIÓN: Realizar el cálculo del aumento en los arriendos, la deducción en las divisas y la operación indicada.
    /// </summary>
    static class Program
    {
        /*Entrada principal de nuestra aplicacion*/
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}
