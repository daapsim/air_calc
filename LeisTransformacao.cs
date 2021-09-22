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
    public partial class CalculadoraTrans : Toolbox
    {
        
        public CalculadoraTrans()
        {
            InitializeComponent();
            //Cancela o fechamento da janela e só "esconde"
            FormClosing += new FormClosingEventHandler(CancelaX);
        }

        // declaração de  variáveis
        double P1, P2, T1, T2, V1, V2;


        // cálculos específicos de cada botão
        #region
        private void btnCalcTer1_Click(object sender, EventArgs e)
        {
            
            try
            {
                // conversão para linguagem do VS
                P2 = Convert.ToDouble(txtP2Ter.Text.Trim());
                V1 = Convert.ToDouble(txtV1Ter.Text.Trim());
                V2 = Convert.ToDouble(txtV2Ter.Text.Trim());
                //cálculo
                P1 = ((P2 * V2) / V1);

                // saída ao usuário
                this.txtP1Ter.Text = Math.Round(P1, 4).ToString();
                lblP1Ter.Text = "P1 = " + Math.Round(P1, 4).ToString() + " bar";
                lblP2Ter.Text = "P2 = " + Convert.ToDouble(txtP2Ter.Text) + " bar";
                lblV1Ter.Text = "V1 = " + Convert.ToDouble(txtV1Ter.Text) + " m3";
                lblV2Ter.Text = "V2 = " + Convert.ToDouble(txtV2Ter.Text) + " m3";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcTer2_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                P1 = Convert.ToDouble(txtP1Ter.Text.Trim());
                V2 = Convert.ToDouble(txtV2Ter.Text.Trim());
                P2 = Convert.ToDouble(txtP2Ter.Text.Trim());
                //cálculo
                V1 = ((P2 * V2) / P1);
                // saída ao usuário
                this.txtV1Ter.Text = Math.Round(V1, 4).ToString();
                lblV1Ter.Text = "V1 = " + Math.Round(V1, 4).ToString() + " m3";
                lblP1Ter.Text = "P1 = " + Convert.ToDouble(txtP1Ter.Text) + " bar";
                lblV2Ter.Text = "V2 = " + Convert.ToDouble(txtV2Ter.Text) + " m3";
                lblP2Ter.Text = "P2 = " + Convert.ToDouble(txtP2Ter.Text) + " bar";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcTer3_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                P1 = Convert.ToDouble(txtP1Ter.Text.Trim());
                V1 = Convert.ToDouble(txtV1Ter.Text.Trim());
                V2 = Convert.ToDouble(txtV2Ter.Text.Trim());
                //cálculo
                P2 = ((P1 * V1) / V2);
                // saída ao usuário
                this.txtP2Ter.Text = Math.Round(P2, 4).ToString();
                lblP2Ter.Text = "P2 = " + Math.Round(P2, 4).ToString() + " bar";
                lblP1Ter.Text = "P1 = " + Convert.ToDouble(txtP1Ter.Text) + " bar";
                lblV1Ter.Text = "V1 = " + Convert.ToDouble(txtV1Ter.Text) + " m3";
                lblV2Ter.Text = "V2 = " + Convert.ToDouble(txtV2Ter.Text) + " m3";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcTer4_Click(object sender, EventArgs e)
        {

            try
            {
                // conversão para linguagem do VS
                P1 = Convert.ToDouble(txtP1Ter.Text.Trim());
                V1 = Convert.ToDouble(txtV1Ter.Text.Trim());
                P2 = Convert.ToDouble(txtP2Ter.Text.Trim());
                //cálculo
                V2 = ((P1 * V1) / P2);
                // saída ao usuário
                this.txtV2Ter.Text = Math.Round(V2, 4).ToString();
                lblV2Ter.Text = "V2 = " + Math.Round(V2, 4).ToString() + " m3";
                lblP1Ter.Text = "P1 = " + Convert.ToDouble(txtP1Ter.Text) + " bar";
                lblV1Ter.Text = "V1 = " + Convert.ToDouble(txtV1Ter.Text) + " m3";
                lblP2Ter.Text = "P2 = " + Convert.ToDouble(txtP2Ter.Text) + " bar";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcVol1_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                P2 = Convert.ToDouble(txtP2Vol.Text.Trim());
                T1 = Convert.ToDouble(txtT1Vol.Text.Trim());
                T2 = Convert.ToDouble(txtT2Vol.Text.Trim());
                //cálculo
                P1 = ((P2 / T2) * T1);
                // saída ao usuário
                this.txtP1Vol.Text = Math.Round(P1, 4).ToString();
                lblP1Vol.Text = "P1 = " + Math.Round(P1, 4).ToString() + " bar";
                lblP2Vol.Text = "P2 = " + Convert.ToDouble(txtP2Vol.Text) + " bar";
                lblT1Vol.Text = "T1 = " + Convert.ToDouble(txtT1Vol.Text) + " K°";
                lblT2Vol.Text = "T2 = " + Convert.ToDouble(txtT2Vol.Text) + " K°";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcVol2_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                P1 = Convert.ToDouble(txtP1Vol.Text.Trim());
                T2 = Convert.ToDouble(txtT2Vol.Text.Trim());
                P2 = Convert.ToDouble(txtP2Vol.Text.Trim());
                //cálculo
                T1 = (P1 / (P2 / T2));
                // saída ao usuário
                this.txtT1Vol.Text = Math.Round(T1, 4).ToString();
                lblT1Vol.Text = "T1 = " + Math.Round(T1, 4).ToString() + " K°";
                lblP2Vol.Text = "P2 = " + Convert.ToDouble(txtP2Vol.Text) + " bar";
                lblP1Vol.Text = "P1 = " + Convert.ToDouble(txtP1Vol.Text) + " bar";
                lblT2Vol.Text = "T2 = " + Convert.ToDouble(txtT2Vol.Text) + " K°";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcVol3_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                P1 = Convert.ToDouble(txtP1Vol.Text.Trim());
                T1 = Convert.ToDouble(txtT1Vol.Text.Trim());
                T2 = Convert.ToDouble(txtT2Vol.Text.Trim());
                //cálculo
                P2 = ((P1 / T1) * T2);
                // saída ao usuário
                this.txtP2Vol.Text = Math.Round(P2, 4).ToString();
                lblP2Vol.Text = "P2 = " + Math.Round(P2, 4).ToString() + " bar";
                lblP1Vol.Text = "P1 = " + Convert.ToDouble(txtP1Vol.Text) + " bar";
                lblT1Vol.Text = "T1 = " + Convert.ToDouble(txtT1Vol.Text) + " K°";
                lblT2Vol.Text = "T2 = " + Convert.ToDouble(txtT2Vol.Text) + " K°";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcVol4_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                P1 = Convert.ToDouble(txtP1Vol.Text.Trim());
                T1 = Convert.ToDouble(txtT1Vol.Text.Trim());
                P2 = Convert.ToDouble(txtP2Vol.Text.Trim());
                //cálculo
                T2 = ((P2 * T1) / P1);
                // saída ao usuário
                this.txtT2Vol.Text = Math.Round(T2, 4).ToString();
                lblT2Vol.Text = "T2 = " + Math.Round(T2, 4).ToString() + " K°";
                lblP2Vol.Text = "P2 = " + Convert.ToDouble(txtP2Vol.Text) + " bar";
                lblP1Vol.Text = "P1 = " + Convert.ToDouble(txtP1Vol.Text) + " bar";
                lblT1Vol.Text = "T1 = " + Convert.ToDouble(txtT1Vol.Text) + " K°";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcBar_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                T1 = Convert.ToDouble(txtT1Bar.Text.Trim());
                V1 = Convert.ToDouble(txtV1Bar.Text.Trim());
                T2 = Convert.ToDouble(txtT2Bar.Text.Trim());
                //cálculo
                V1 = (T1 * (V2 / T2));
                // saída ao usuário
                this.txtV1Bar.Text = Math.Round(V1, 4).ToString();
                lblV1Bar.Text = "V1 = " + Math.Round(V1, 4).ToString() + " m3";
                lblT2Bar.Text = "T2 = " + Convert.ToDouble(txtT2Bar.Text) + " K°";
                lblT1Bar.Text = "T1 = " + Convert.ToDouble(txtT1Bar.Text) + " K°";
                lblV2Bar.Text = "V2 = " + Convert.ToDouble(txtV2Bar.Text) + " m3";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcBar2_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                V1 = Convert.ToDouble(txtV1Bar.Text.Trim());
                V2 = Convert.ToDouble(txtV2Bar.Text.Trim());
                T2 = Convert.ToDouble(txtT2Bar.Text.Trim());
                //cálculo
                T1 = (V1 / (V2 / T2));
                // saída ao usuário
                this.lblT1Bar.Text = Math.Round(T1, 4).ToString();
                lblT1Bar.Text = "T1 = " + Math.Round(T1, 4).ToString() + " K°";
                lblT2Bar.Text = "T2 = " + Convert.ToDouble(txtT2Bar.Text) + " K°";
                lblV1Bar.Text = "V1 = " + Convert.ToDouble(txtV1Bar.Text) + " m3";
                lblV2Bar.Text = "V2 = " + Convert.ToDouble(txtV2Bar.Text) + " m3";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcBar3_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                T1 = Convert.ToDouble(txtT1Bar.Text.Trim());
                T2 = Convert.ToDouble(txtT2Bar.Text.Trim());
                V1 = Convert.ToDouble(txtV1Bar.Text.Trim());
                //cálculo
                V2 = (T2 * (V1 / T1));
                // saída ao usuário
                this.txtV2Bar.Text = Math.Round(V2, 4).ToString();
                lblV2Bar.Text = "V2 = " + Math.Round(V2, 4).ToString() + " m3";
                lblT2Bar.Text = "T2 = " + Convert.ToDouble(txtT2Bar.Text) + " K°";
                lblV1Bar.Text = "V1 = " + Convert.ToDouble(txtV1Bar.Text) + " m3";
                lblT1Bar.Text = "T1 = " + Convert.ToDouble(txtT1Bar.Text) + " K°";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcBar4_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                V1 = Convert.ToDouble(txtV1Bar.Text.Trim());
                T1 = Convert.ToDouble(txtT1Bar.Text.Trim());
                V2 = Convert.ToDouble(txtV2Bar.Text.Trim());
                //cálculo
                T2 = (V2 / (V1 / T1));
                // saída ao usuário
                this.txtT2Bar.Text = Math.Round(T2, 4).ToString();
                lblT2Bar.Text = "T2 = " + Math.Round(T2, 4).ToString() + " K°";
                lblV2Bar.Text = "V2 = " + Convert.ToDouble(txtV2Bar.Text) + " m3";
                lblV1Bar.Text = "V1 = " + Convert.ToDouble(txtV1Bar.Text) + " m3";
                lblT1Bar.Text = "T1 = " + Convert.ToDouble(txtT1Bar.Text) + " K°";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcGases_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                V1 = Convert.ToDouble(txtV1Gases.Text.Trim());
                V2 = Convert.ToDouble(txtV2Gases.Text.Trim());
                T1 = Convert.ToDouble(txtT1Gases.Text.Trim());
                T2 = Convert.ToDouble(txtT2Gases.Text.Trim());
                P2 = Convert.ToDouble(txtP2Gases.Text.Trim());
                //cálculo
                P1 = (((P2 * V2) / T2) / (V1 / T1));
                // saída ao usuário
                this.lblP1Gases.Text = Math.Round(P1, 4).ToString();
                lblP1Gases.Text = "P1 = " + Math.Round(P1, 3).ToString() + " bar";
                lblV1Gases.Text = "V1 = " + Convert.ToDouble(txtV1Gases.Text) + " m3";
                lblV2Gases.Text = "V2 = " + Convert.ToDouble(txtV2Gases.Text) + " m3";
                lblT1Gases.Text = "T1 = " + Convert.ToDouble(txtT1Gases.Text) + " K°";
                lblT2Gases.Text = "T2 = " + Convert.ToDouble(txtT2Gases.Text) + " K°";
                lblP2Gases.Text = "P2 = " + Convert.ToDouble(txtP2Gases.Text) + " bar";
            }
            catch { 
                InvalidOrNo(); 
            }
        }
        #region limpa_botoes
        private void txtP1Ter_Click(object sender, EventArgs e)
        {
            txtP1Ter.Text = null;
        }

        private void txtV1Ter_Click(object sender, EventArgs e)
        {
            txtV1Ter.Text = null;
        }

        private void txtP2Ter_Click(object sender, EventArgs e)
        {
            txtP2Ter.Text = null;
        }

        private void txtV2Ter_Click(object sender, EventArgs e)
        {
            txtV2Ter.Text = null;
        }

        private void txtP1Ter_Click_1(object sender, EventArgs e)
        {
            txtP1Ter.Text = null;
        }

        private void txtP1Vol_Click(object sender, EventArgs e)
        {
            txtP1Vol.Text = null;
        }

        private void txtT1Vol_Click(object sender, EventArgs e)
        {
            txtT1Vol.Text = null;
        }

        private void txtP2Vol_Click(object sender, EventArgs e)
        {
            txtP2Vol.Text = null;
        }

        private void txtT2Vol_Click(object sender, EventArgs e)
        {
            txtT2Vol.Text = null;
        }

        private void txtV1Bar_Click(object sender, EventArgs e)
        {
            txtV1Bar.Text = null;
        }

        private void txtT1Bar_Click(object sender, EventArgs e)
        {
            txtT1Bar.Text = null;
        }

        private void txtV2Bar_Click(object sender, EventArgs e)
        {
            txtV2Bar.Text = null;
        }

        private void txtT2Bar_Click(object sender, EventArgs e)
        {
            txtT2Bar.Text = null;
        }

        private void txtP1Gases_Click(object sender, EventArgs e)
        {
            txtP1Gases.Text = null;
        }

        private void txtV1Gases_Click(object sender, EventArgs e)
        {
            txtV1Gases.Text = null;
        }

        private void txtT1Gases_Click(object sender, EventArgs e)
        {
            txtT1Gases.Text = null;
        }

        private void txtP2Gases_Click(object sender, EventArgs e)
        {
            txtP2Gases.Text = null;
        }

        private void txtV2Gases_Click(object sender, EventArgs e)
        {
            txtV2Gases.Text = null;
        }

        private void txtT2Gases_Click(object sender, EventArgs e)
        {
            txtT2Gases.Text = null;
        }
        #endregion
        private void btnCalcGases2_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                P1 = Convert.ToDouble(txtP1Gases.Text.Trim());
                V2 = Convert.ToDouble(txtV2Gases.Text.Trim());
                T1 = Convert.ToDouble(txtT1Gases.Text.Trim());
                T2 = Convert.ToDouble(txtT2Gases.Text.Trim());
                P2 = Convert.ToDouble(txtP2Gases.Text.Trim());
                //cálculo
                V1 = (((P2 * V2) / T2) / (P1 / T1));
                // saída ao usuário
                this.lblV1Gases.Text = Math.Round(V1, 4).ToString();
                lblV1Gases.Text = "V1 = " + Math.Round(V1, 3).ToString() + " m3";
                lblP1Gases.Text = "P1 = " + Convert.ToDouble(txtP1Gases.Text) + " bar";
                lblV2Gases.Text = "V2 = " + Convert.ToDouble(txtV2Gases.Text) + " m3";
                lblT1Gases.Text = "T1 = " + Convert.ToDouble(txtT1Gases.Text) + " K°";
                lblT2Gases.Text = "T2 = " + Convert.ToDouble(txtT2Gases.Text) + " K°";
                lblP2Gases.Text = "P2 = " + Convert.ToDouble(txtP2Gases.Text) + " bar";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcGases3_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                P1 = Convert.ToDouble(txtP1Gases.Text.Trim());
                V2 = Convert.ToDouble(txtV2Gases.Text.Trim());
                V1 = Convert.ToDouble(txtV1Gases.Text.Trim());
                T2 = Convert.ToDouble(txtT2Gases.Text.Trim());
                P2 = Convert.ToDouble(txtP2Gases.Text.Trim());
                //cálculo
                T1 = ((P1 * V1) / ((P2 * V2) / T2));
                // saída ao usuário
                this.lblT1Gases.Text = Math.Round(T1, 4).ToString();
                lblT1Gases.Text = "T1 = " + Math.Round(T1, 2).ToString() + " K°";
                lblP1Gases.Text = "P1 = " + Convert.ToDouble(txtP1Gases.Text) + " bar";
                lblV2Gases.Text = "V2 = " + Convert.ToDouble(txtV2Gases.Text) + " m3";
                lblV1Gases.Text = "V1 = " + Convert.ToDouble(txtV1Gases.Text) + " m3";
                lblT2Gases.Text = "T2 = " + Convert.ToDouble(txtT2Gases.Text) + " K°";
                lblP2Gases.Text = "P2 = " + Convert.ToDouble(txtP2Gases.Text) + " bar";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcGases4_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                P1 = Convert.ToDouble(txtP1Gases.Text.Trim());
                V2 = Convert.ToDouble(txtV2Gases.Text.Trim());
                V1 = Convert.ToDouble(txtV1Gases.Text.Trim());
                T2 = Convert.ToDouble(txtT2Gases.Text.Trim());
                T1 = Convert.ToDouble(txtT1Gases.Text.Trim());
                //cálculo
                P2 = (((P1 * V1) / T1) / (V2 / T2));
                // saída ao usuário
                this.lblP2Gases.Text = Math.Round(P2, 4).ToString();
                lblP2Gases.Text = "P2 = " + Math.Round(P2, 3).ToString() + " bar";
                lblP1Gases.Text = "P1 = " + Convert.ToDouble(txtP1Gases.Text) + " bar";
                lblV2Gases.Text = "V2 = " + Convert.ToDouble(txtV2Gases.Text) + " m3";
                lblV1Gases.Text = "V1 = " + Convert.ToDouble(txtV1Gases.Text) + " m3";
                lblT2Gases.Text = "T2 = " + Convert.ToDouble(txtT2Gases.Text) + " K°";
                lblT1Gases.Text = "T1 = " + Convert.ToDouble(txtT1Gases.Text) + " K°";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcGases5_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                P1 = Convert.ToDouble(txtP1Gases.Text.Trim());
                P2 = Convert.ToDouble(txtP2Gases.Text.Trim());
                V1 = Convert.ToDouble(txtV1Gases.Text.Trim());
                T2 = Convert.ToDouble(txtT2Gases.Text.Trim());
                T1 = Convert.ToDouble(txtT1Gases.Text.Trim());
                //cálculo
                V2 = (((P1 * V1) / T1) / (P2 / T2));
                // saída ao usuário
                this.lblV2Gases.Text = Math.Round(V2, 4).ToString();
                lblV2Gases.Text = "V2 = " + Math.Round(V2, 3).ToString() + " m3";
                lblP1Gases.Text = "P1 = " + Convert.ToDouble(txtP1Gases.Text) + " bar";
                lblP2Gases.Text = "P2 = " + Convert.ToDouble(txtP2Gases.Text) + " m3";
                lblV1Gases.Text = "V1 = " + Convert.ToDouble(txtV1Gases.Text) + " m3";
                lblT2Gases.Text = "T2 = " + Convert.ToDouble(txtT2Gases.Text) + " K°";
                lblT1Gases.Text = "T1 = " + Convert.ToDouble(txtT1Gases.Text) + " K°";
            }
            catch
            {
                InvalidOrNo();
            }
        }

        private void btnCalcGases6_Click(object sender, EventArgs e)
        {
            try
            {
                // conversão para linguagem do VS
                P1 = Convert.ToDouble(txtP1Gases.Text.Trim());
                P2 = Convert.ToDouble(txtP2Gases.Text.Trim());
                V1 = Convert.ToDouble(txtV1Gases.Text.Trim());
                V2 = Convert.ToDouble(txtV2Gases.Text.Trim());
                T1 = Convert.ToDouble(txtT1Gases.Text.Trim());
                //cálculo
                T2 = ((P2 * V2) / ((P1 * V1) / T1));
                // saída ao usuário
                this.lblT2Gases.Text = Math.Round(T2, 4).ToString();
                lblT2Gases.Text = "T2 = " + Math.Round(T2, 2).ToString() + " K°";
                lblP1Gases.Text = "P1 = " + Convert.ToDouble(txtP1Gases.Text) + " bar";
                lblP2Gases.Text = "P2 = " + Convert.ToDouble(txtP2Gases.Text) + " bar";
                lblV1Gases.Text = "V1 = " + Convert.ToDouble(txtV1Gases.Text) + " m3";
                lblV2Gases.Text = "V2 = " + Convert.ToDouble(txtV2Gases.Text) + " m3";
                lblT1Gases.Text = "T1 = " + Convert.ToDouble(txtT1Gases.Text) + " K°";
            }
            catch
            {
                InvalidOrNo();
            }
        }
        #endregion 

    }

}

