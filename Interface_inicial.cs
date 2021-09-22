using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APH_e_PV
{
    public partial class Interface_inicial : Form
    {
        CalculadoraTrans obj_CalculadoraTrans = new CalculadoraTrans();
        Cálculos_Vazão obj_Cálculos_Vazão = new Cálculos_Vazão();
        Singularidades obj_Singularidades = new Singularidades();
        public Dimensionamento_Linha obj_dimLinha = new Dimensionamento_Linha();
        Sobre obj_sobre = new Sobre();
        feedbackemail obj_avalia = new feedbackemail();
        public Interface_inicial()
        {
            InitializeComponent();
           
        }

        private void btnLeisTransformacao_Click(object sender, EventArgs e)
        {
            obj_CalculadoraTrans.Show();
        }

        private void btnCalcVazao_Click(object sender, EventArgs e)
        {
            obj_Cálculos_Vazão.Show();
        }

        private void btnSing_Click(object sender, EventArgs e)
        {
            obj_Singularidades.Show();
        }

        private void btnLinhaPrinc_Click(object sender, EventArgs e)
        {
            obj_dimLinha.Show();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            obj_sobre.Show();
        }

        private void btnAvalia_Click(object sender, EventArgs e)
        {
            obj_avalia.Show();
        }
    }
}
