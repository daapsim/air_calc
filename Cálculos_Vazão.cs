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
    public partial class Cálculos_Vazão : Toolbox
    {
        public Cálculos_Vazão()
        {
            InitializeComponent();
            //Cancela o fechamento da janela e só "esconde"
            FormClosing += new FormClosingEventHandler(CancelaX);
        }

        //declaração de variáveis
        double Tt, Ts, SomaQc, Qefet, K, I, V0_res, Pa0, V1_res, Pa1, Prel;

        #region limpa_botoes
        private void txtV0_Click(object sender, EventArgs e)
        {
            txtV0.Text = null;
        }

        private void txtPa0_Click(object sender, EventArgs e)
        {
            txtPa0.Text = null;
        }

        private void txtV1_Click(object sender, EventArgs e)
        {
            txtV1.Text = null;
        }

        private void txtPa1_Click(object sender, EventArgs e)
        {
            txtPa1.Text = null;
        }

        private void txt_K_Click(object sender, EventArgs e)
        {
            txt_K.Text = null;
        }

        private void txtSomaQc_Click(object sender, EventArgs e)
        {
            txtSomaQc.Text = null;
        }

        private void txt_Ts_Click(object sender, EventArgs e)
        {
            txt_Ts.Text = null;
        }

        private void txt_Tt_Click(object sender, EventArgs e)
        {
            txt_Tt.Text = null;
        }
        #endregion
        // evento Click nos botões para realizar os cálculos
        #region
        public void btnCalc_Pa1_Click(object sender, EventArgs e)
        {
            try
            {
                V1_res = Convert.ToDouble(txtV1.Text.Trim());
                V0_res = Convert.ToDouble(txtV0.Text.Trim());
                Pa0 = Convert.ToDouble(txtPa0.Text.Trim());
                // cálculo
                Pa1 = ((V0_res * Pa0) / V1_res);
                // txt.box -> label
                lbl_Pa1.Text = "Pa1 = " + Math.Round(Pa1, 3).ToString() + " MPa";
                lbl_Pa0.Text = "Pa0 = " + Convert.ToDouble(txtPa0.Text) + " MPa";
                lbl_V0.Text = "V0 = " + Convert.ToDouble(txtV0.Text) + " m3";
                lbl_V1.Text = "V1 = " + Convert.ToDouble(txtV1.Text) + " m3";
            }
            catch
            {
                MessageBox.Show("Confira os campos. Apenas números são aceitos ");
            }
        }

        public void btnCalc_V1_Click(object sender, EventArgs e)
        {
            try
            {
                V0_res = Convert.ToDouble(txtV0.Text.Trim());
                Pa0 = Convert.ToDouble(txtPa0.Text.Trim());
                Prel = Convert.ToDouble(txtPa1.Text.Trim());
                // cálculo
                Pa1 = (Pa0 + Prel);
                V1_res = ((V0_res * Pa0) / Pa1);
                // text.box -> label
                lbl_V1.Text = "V1 = " + Math.Round(V1_res, 3).ToString() + " m3";
                lbl_V0.Text = "V0 = " + Convert.ToDouble(txtV0.Text) + " m3";
                lbl_Pa0.Text = "Pa0 = " + Convert.ToDouble(txtPa0.Text) + " MPa";
                lbl_Pa1.Text = "Pa1 = " + (Pa0 + Prel) + " MPa";
            }
            catch
            {
                MessageBox.Show("Confira os campos. Apenas números são aceitos ");
            }
        }

        public void btnCalcPa0_Click(object sender, EventArgs e)
        {
            try
            {
                V0_res = Convert.ToDouble(txtV0.Text.Trim());
                V1_res = Convert.ToDouble(txtV1.Text.Trim());
                Prel = Convert.ToDouble(txtPa1.Text.Trim());
                // cálculo
                Pa1 = (Pa0 + Prel);
                Pa0 = ((V1_res * Pa1) / V0_res);
                // text.box -> label
                lbl_Pa0.Text = "Pa0 = " + Math.Round(Pa0, 3).ToString() + " MPa";
                lbl_Pa1.Text = "Pa1 = " + (Pa0 + Prel) + " MPa";
                lbl_V1.Text = "V1 = " + Convert.ToDouble(txtV1.Text) + " m3";
                lbl_V0.Text = "V0 = " + Convert.ToDouble(txtV0.Text) + " m3";
            }
            catch
            {
                MessageBox.Show("Confira os campos. Apenas números são aceitos ");
            }
        }

        public void btnCalcV0_Click(object sender, EventArgs e)
        {
            try
            {
                Pa0 = Convert.ToDouble(txtPa0.Text.Trim());
                V1_res = Convert.ToDouble(txtV1.Text.Trim());
                Prel = Convert.ToDouble(txtPa1.Text.Trim());
                // cálculo
                Pa1 = (Pa0 + Prel);
                V0_res = ((V1_res * Pa1) / Pa0);
                // text.box -> label
                lbl_V0.Text = "V0 = " + Math.Round(V0_res, 3).ToString() + " m3";
                lbl_Pa0.Text = "Pa0 = " + Convert.ToDouble(txtPa0.Text) + " MPa";
                lbl_Pa1.Text = "Pa1 = " + (Pa0 + Prel) + " MPa";
                lbl_V1.Text = "V1 = " + Convert.ToDouble(txtV1.Text) + " m3";
            }
            catch
            {
                MessageBox.Show("Confira os campos. Apenas números são aceitos ");
            }
        }

        public void btn_CalcQeft_Click(object sender, EventArgs e)
        {
            try
            {
                SomaQc = Convert.ToDouble(txtSomaQc.Text.Trim());
                K = Convert.ToDouble(txt_K.Text.Trim());
                // cálculo
                Qefet = (SomaQc * 100 * (K / I));
                // text.box -> label
                lblQeft.Text = "Qe = " + Math.Round(Qefet, 4).ToString() + " m3/h";
            }
            catch
            {
                MessageBox.Show("Confira os campos. Apenas números são aceitos ");
            }
        }

        public void btn_CalcIns_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                Tt = Convert.ToDouble(txt_Tt.Text.Trim());
                Ts = Convert.ToDouble(txt_Ts.Text.Trim());
                // cálculo
                I = (Tt / (Tt + Ts)) * 100;
                // text.box -> label
                lbl_CoefIns.Text = "I = " + Math.Round(I, 6).ToString() + " %";
            }
            catch
            {
                MessageBox.Show("Confira os campos. Apenas números são aceitos ");
            }
        }
        #endregion
    }
}
