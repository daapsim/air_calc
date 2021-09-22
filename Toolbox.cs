using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APH_e_PV
{
    public class Toolbox : Form
    {

        //Cancela o fechamento da janela e só "esconde"
        public void CancelaX(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        // retorna se é número ou não
        public string IsNumber(string texto)
        {
            try
            {
                double numero;
                numero = Convert.ToDouble(texto);
                return texto;
            }
            catch
            {
                return "INVÁLIDO";
            }
        }

        // retorna  mensagem de erro quando inválido
        public void InvalidOrNo()
        {
            MessageBox.Show("Entrada(s) inválida(s). \nUtilize apenas números!");
        }

    }
}
