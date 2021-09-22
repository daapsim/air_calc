using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace APH_e_PV
{
    public partial class Dimensionamento_Linha : Toolbox
    {
        tabela2 obj_tabela2 = new tabela2() ;

        int i = 1;
        double diap, Qt, aumentocapacidade;
        public double perdacarga, ptrabalho;
        double L1, L2, L3, L4, L5;
        double Ltp, Lt1, Lt2, Lt3, Lt4, Lt5;
        double Q1, Q2, Q3, Q4, Q5;
        double Lsingu, L1singu, L2singu, L3singu, L4singu, L5singu;


        #region limpa_botoes
        private void txbSecSing2_Click(object sender, EventArgs e)
        {
            txbSecSing2.Text = null;
        }

        private void txbSecQtd3_Click(object sender, EventArgs e)
        {
            txbSecQtd3.Text = null;
        }

        private void txbSecSing3_Click(object sender, EventArgs e)
        {
            txbSecSing3.Text = null;
        }

        private void txbSecQtd4_Click(object sender, EventArgs e)
        {
            txbSecQtd4.Text = null;
        }

        private void txbSecSing4_Click(object sender, EventArgs e)
        {
            txbSecSing4.Text = null;
        }

        private void txbSecComp5_Click(object sender, EventArgs e)
        {
            txbSecComp5.Text = null;
        }

        private void txbSecQtd5_Click(object sender, EventArgs e)
        {
            txbSecQtd5.Text = null;
        }

        private void txbSecSing5_Click(object sender, EventArgs e)
        {
            txbSecSing5.Text = null;
        }

        private void txbAlimQtd1_Click(object sender, EventArgs e)
        {
            txbAlimQtd1.Text = null;
        }

        private void txbAlimSing1_Click(object sender, EventArgs e)
        {
            txbAlimSing1.Text = null;
        }

        private void txbAlimQtd2_Click(object sender, EventArgs e)
        {
            txbAlimQtd2.Text = null;
        }

        private void txbAlimSing2_Click(object sender, EventArgs e)
        {
            txbAlimSing2.Text = null;
        }

        private void txbAlimQtd3_Click(object sender, EventArgs e)
        {
            txbAlimQtd3.Text = null;
        }

        private void txbAlimSing3_Click(object sender, EventArgs e)
        {
            txbAlimSing3.Text = null;
        }

        private void txbAlimQtd4_Click(object sender, EventArgs e)
        {
            txbAlimQtd4.Text = null;
        }

        private void txbAlimSing4_Click(object sender, EventArgs e)
        {
            txbAlimSing4.Text = null;
        }

        private void txbAlimQtd5_Click(object sender, EventArgs e)
        {
            txbAlimQtd5.Text = null;
        }

        private void txbAlimSing5_Click(object sender, EventArgs e)
        {
            txbAlimSing5.Text = null;
        }

        private void txbSecQtd2_Click(object sender, EventArgs e)
        {
            txbSecQtd2.Text = null;
        }

        private void txbSecSing1_Click(object sender, EventArgs e)
        {
            txbSecSing1.Text = null;
        }

        private void txbSecQtd1_Click(object sender, EventArgs e)
        {
            txbSecQtd1.Text = null;
        }
        #endregion

        private void btnTabela2_Click(object sender, EventArgs e)
        {
            obj_tabela2.Show();
        }

        public Dimensionamento_Linha()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(CancelaX);
        }


        //função que calcula alimentação
        private string calculaAlim(string alimQtd, string secComp, double vazQx, string alimSing)
        {
            //declaração de variáveis iniciais
            double comp, alim, qtdLinha, alimDia, alimSingTot, compTot;

            qtdLinha = Convert.ToDouble(alimQtd.Trim());
            comp = Convert.ToDouble(secComp.Trim()) / qtdLinha;
            alim = vazQx / qtdLinha;

            alimSingTot = Convert.ToDouble(alimSing.Trim());

            compTot = comp + alimSingTot;
            alimDia = Math.Round(10 * (Math.Pow((((0.001663785 * Math.Pow(alim, 1.85) * compTot) / (perdacarga * ptrabalho))), 0.2)), 4);

            return alimDia.ToString();
        }

        // limpa text box clicados
        #region
        
        private void txbPress_Click(object sender, EventArgs e)
        {
            txbPress.Text = "";
        }

        private void txbAuCap_Click(object sender, EventArgs e)
        {
            txbAuCap.Text = "";
        }

        private void txbSecComp2_Click(object sender, EventArgs e)
        {
            txbSecComp2.Text = "";
        }

        private void txbSecComp1_Click(object sender, EventArgs e)
        {
            txbSecComp1.Text = "";
        }

        private void txbSecComp3_Click(object sender, EventArgs e)
        {
            txbSecComp3.Text = "";
        }

        private void txbSecComp4_Click(object sender, EventArgs e)
        {
            txbSecComp4.Text = "";
        }

        private void txbPerda_Click(object sender, EventArgs e)
        {
            txbPerda.Text = "";
        }

        private void txbVaz_Click(object sender, EventArgs e)
        {
            txbVaz.Text = "";
        }

        private void txbPriCompSingu_Click(object sender, EventArgs e)
        {
            txbPriCompSingu.Text = "";
        }

        private void txbComp_Click(object sender, EventArgs e)
        {
            txbComp.Text = "";
        }
        
        #endregion

        // calculo da linha de alimentação após clique no botão
        private void btnCalcAlim_Click(object sender, EventArgs e)
        {
            try
            {
                switch (i)
                {
                    case 1:
                        lblAlimDiaResp1.Text = calculaAlim(txbAlimQtd1.Text, txbSecComp1.Text, Q1, txbAlimSing1.Text) + " mm";
                        break;
                    case 2:
                        lblAlimDiaResp1.Text = calculaAlim(txbAlimQtd1.Text, txbSecComp1.Text, Q1, txbAlimSing1.Text) + " mm";
                        lblAlimDiaResp2.Text = calculaAlim(txbAlimQtd2.Text, txbSecComp2.Text, Q2, txbAlimSing2.Text) + " mm";
                        break;
                    case 3:
                        lblAlimDiaResp1.Text = calculaAlim(txbAlimQtd1.Text, txbSecComp1.Text, Q1, txbAlimSing1.Text) + " mm";
                        lblAlimDiaResp2.Text = calculaAlim(txbAlimQtd2.Text, txbSecComp2.Text, Q2, txbAlimSing2.Text) + " mm";
                        lblAlimDiaResp3.Text = calculaAlim(txbAlimQtd3.Text, txbSecComp3.Text, Q3, txbAlimSing3.Text) + " mm";
                        break;

                    case 4:
                        lblAlimDiaResp1.Text = calculaAlim(txbAlimQtd1.Text, txbSecComp1.Text, Q1, txbAlimSing1.Text) + " mm";
                        lblAlimDiaResp2.Text = calculaAlim(txbAlimQtd2.Text, txbSecComp2.Text, Q2, txbAlimSing2.Text) + " mm";
                        lblAlimDiaResp3.Text = calculaAlim(txbAlimQtd3.Text, txbSecComp3.Text, Q3, txbAlimSing3.Text) + " mm";
                        lblAlimDiaResp4.Text = calculaAlim(txbAlimQtd4.Text, txbSecComp4.Text, Q4, txbAlimSing4.Text) + " mm";
                        break;

                    case 5:
                        lblAlimDiaResp1.Text = calculaAlim(txbAlimQtd1.Text, txbSecComp1.Text, Q1, txbAlimSing1.Text) + " mm";
                        lblAlimDiaResp2.Text = calculaAlim(txbAlimQtd2.Text, txbSecComp2.Text, Q2, txbAlimSing2.Text) + " mm";
                        lblAlimDiaResp3.Text = calculaAlim(txbAlimQtd3.Text, txbSecComp3.Text, Q3, txbAlimSing3.Text) + " mm";
                        lblAlimDiaResp4.Text = calculaAlim(txbAlimQtd4.Text, txbSecComp4.Text, Q4, txbAlimSing4.Text) + " mm";
                        lblAlimDiaResp5.Text = calculaAlim(txbAlimQtd5.Text, txbSecComp5.Text, Q5, txbAlimSing5.Text) + " mm";
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Confira os campos. Apenas números são aceitos!");
            }
        }

        // adiciona linhas secundárias
        private void btnLinhaSecAdd_Click(object sender, EventArgs e)
        {
            //adiciona linha secundaria
            switch (i) {
                // mostra segundaa linha secundaria e alim
                case 1:
                    //sec
                    lblSecComp2.Visible = true;
                    lblSecQtd2.Visible = true;
                    lblSecSing2.Visible = true;
                    lblSecDia2.Visible = true;
                    txbSecComp2.Visible = true;
                    txbSecQtd2.Visible = true;
                    txbSecSing2.Visible = true;
                    lblSecDiaResp2.Visible = true;
                    // alim
                    lblAlimQtd2.Visible = true;
                    lblAlimSing2.Visible = true;
                    lblAlimDia2.Visible = true;
                    txbAlimQtd2.Visible = true;
                    txbAlimSing2.Visible = true;
                    lblAlimDiaResp2.Visible = true;

                    // adiciona 1 no i para ficar com 2
                    i += 1;
                    break;
                // mostra terceira linha secundaria 
                case 2:
                    lblSecComp3.Visible = true;
                    lblSecQtd3.Visible = true;
                    lblSecSing3.Visible = true;
                    lblSecDia3.Visible = true;
                    txbSecComp3.Visible = true;
                    txbSecQtd3.Visible = true;
                    txbSecSing3.Visible = true;
                    lblSecDiaResp3.Visible = true;

                    // alim
                    lblAlimQtd3.Visible = true;
                    lblAlimSing3.Visible = true;
                    lblAlimDia3.Visible = true;
                    txbAlimQtd3.Visible = true;
                    txbAlimSing3.Visible = true;
                    lblAlimDiaResp3.Visible = true;

                    i += 1;
                    break;
                // mostra quarta linha secundaria 
                case 3:
                    lblSecComp4.Visible = true;
                    lblSecQtd4.Visible = true;
                    lblSecSing4.Visible = true;
                    lblSecDia4.Visible = true;
                    txbSecComp4.Visible = true;
                    txbSecQtd4.Visible = true;
                    txbSecSing4.Visible = true;
                    lblSecDiaResp4.Visible = true;
                    // alim
                    lblAlimQtd4.Visible = true;
                    lblAlimSing4.Visible = true;
                    lblAlimDia4.Visible = true;
                    txbAlimQtd4.Visible = true;
                    txbAlimSing4.Visible = true;
                    lblAlimDiaResp4.Visible = true;

                    i += 1;
                    break;
                // mostra quinta linha secundaria 
                case 4:
                    lblSecComp5.Visible = true;
                    lblSecQtd5.Visible = true;
                    lblSecSing5.Visible = true;
                    lblSecDia5.Visible = true;
                    txbSecComp5.Visible = true;
                    txbSecQtd5.Visible = true;
                    txbSecSing5.Visible = true;
                    lblSecDiaResp5.Visible = true;

                    // alim
                    lblAlimQtd5.Visible = true;
                    lblAlimSing5.Visible = true;
                    lblAlimDia5.Visible = true;
                    txbAlimQtd5.Visible = true;
                    txbAlimSing5.Visible = true;
                    lblAlimDiaResp5.Visible = true;

                    i += 1;
                    break;
                }
            }

        // remove linhas secundárias
        private void btnLinhaSecDel_Click(object sender, EventArgs e)
        {
            //remove linhas secundarias
            switch (i)
            {
                // remove quinta linha secundaria 
                case 5:
                    lblSecComp5.Visible = false;
                    lblSecQtd5.Visible = false;
                    lblSecSing5.Visible = false;
                    lblSecDia5.Visible = false;
                    txbSecComp5.Visible = false;
                    txbSecQtd5.Visible = false;
                    txbSecSing5.Visible = false;
                    lblSecDiaResp5.Visible = false;
                    txbSecComp5.Text = null;
                    txbSecQtd5.Text = null;
                    txbSecSing5.Text = null;
                    lblSecDia5.Text = null;

                    // alim
                    lblAlimQtd5.Visible = false;
                    lblAlimSing5.Visible = false;
                    lblAlimDia5.Visible = false;
                    txbAlimQtd5.Visible = false;
                    txbAlimSing5.Visible = false;
                    lblAlimDiaResp5.Visible = false;
                    txbAlimQtd5.Text = null;
                    txbAlimSing5.Text = null;
                    lblAlimDia5.Text = null;

                    i -= 1;
                    break;

                // remove quarta linha secundaria 
                case 4:
                    lblSecComp4.Visible = false;
                    lblSecQtd4.Visible = false;
                    lblSecSing4.Visible = false;
                    lblSecDia4.Visible = false;
                    txbSecComp4.Visible = false;
                    txbSecQtd4.Visible = false;
                    txbSecSing4.Visible = false;
                    lblSecDiaResp4.Visible = false;
                    txbSecComp4.Text = null;
                    txbSecQtd4.Text = null;
                    txbSecSing4.Text = null;
                    lblSecDia4.Text = null;

                    // alim
                    lblAlimQtd4.Visible = false;
                    lblAlimSing4.Visible = false;
                    lblAlimDia4.Visible = false;
                    txbAlimQtd4.Visible = false;
                    txbAlimSing4.Visible = false;
                    lblAlimDiaResp4.Visible = false;
                    txbAlimQtd4.Text = null;
                    txbAlimSing4.Text = null;
                    lblAlimDia4.Text = null;

                    i -= 1;
                    break;
                // remove terceira linha secundaria
                case 3:
                    lblSecComp3.Visible = false;
                    lblSecQtd3.Visible = false;
                    lblSecSing3.Visible = false;
                    lblSecDia3.Visible = false;
                    txbSecComp3.Visible = false;
                    txbSecQtd3.Visible = false;
                    txbSecSing3.Visible = false;
                    lblSecDiaResp3.Visible = false;
                    txbSecComp3.Text = null;
                    txbSecQtd3.Text = null;
                    txbSecSing3.Text = null;
                    lblSecDia3.Text = null;

                    // alim
                    lblAlimQtd3.Visible = false;
                    lblAlimSing3.Visible = false;
                    lblAlimDia3.Visible = false;
                    txbAlimQtd3.Visible = false;
                    txbAlimSing3.Visible = false;
                    lblAlimDiaResp3.Visible = false;
                    txbAlimQtd3.Text = null;
                    txbAlimSing3.Text = null;
                    lblAlimDia3.Text = null;

                    i -= 1;
                    break;
                // remove segunda linha secundaria 
                case 2:
                    lblSecComp2.Visible = false;
                    lblSecQtd2.Visible = false;
                    lblSecSing2.Visible = false;
                    lblSecDia2.Visible = false;
                    txbSecComp2.Visible = false;
                    txbSecQtd2.Visible = false;
                    txbSecSing2.Visible = false;
                    lblSecDiaResp2.Visible = false;
                    txbSecComp2.Text = null;
                    txbSecQtd2.Text = null;
                    txbSecSing2.Text = null;
                    lblSecDia2.Text = null;

                    // alim
                    lblAlimQtd2.Visible = false;
                    lblAlimSing2.Visible = false;
                    lblAlimDia2.Visible = false;
                    txbAlimQtd2.Visible = false;
                    txbAlimSing2.Visible = false;
                    lblAlimDiaResp2.Visible = false;
                    txbAlimQtd2.Text = null;
                    txbAlimSing2.Text = null;
                    lblAlimDia2.Text = null;

                    i -= 1;
                    break;
            }
        }

        // calcula linha principal
        private void btnCalc1_Click(object sender, EventArgs e)
        {
            if (txbComp.Text == null || txbVaz.Text == null || txbPerda.Text == null || txbPress.Text == null || txbAuCap == null)
            {
                MessageBox.Show("Há campos nulos");
            }
            else
            {
                try
                {
                    // leitura e conversão de dados
                    Qt = Convert.ToDouble(txbVaz.Text.Trim());
                    perdacarga = Convert.ToDouble(txbPerda.Text.Trim());
                    ptrabalho = Convert.ToDouble(txbPress.Text.Trim());
                    Ltp = Convert.ToDouble(txbComp.Text.Trim());
                    aumentocapacidade = Convert.ToDouble(txbAuCap.Text.Trim());

                    Lsingu = Convert.ToDouble(txbPriCompSingu.Text.Trim());

                    // calculo
                    Qt += Qt * (aumentocapacidade / 100);
                    Ltp += Lsingu;


                    diap = (0.001663785 * Math.Pow(Qt, 1.85) * Ltp) / (perdacarga * ptrabalho);
                    diap = (Math.Pow(diap, 0.2)) * 10;

                    lblPriRes.Text ="D = " + Math.Round(diap, 4).ToString() + " mm";
                }
                catch
                {
                    MessageBox.Show("Confira os campos. Apenas números são aceitos!");
                }

            }
        }
        
        // calcula linhas secundárias
        private void btnCalcSec_Click(object sender, EventArgs e)
        {
            try
            {
                switch (i)
                {
                    // trabalhando com a primeira linha secundaria
                    case 1:
                        // lendo
                        Lt1 = (Convert.ToDouble(txbSecComp1.Text)) * (Convert.ToDouble(txbSecQtd1.Text));
                        L1 = (Convert.ToDouble(txbSecComp1.Text));


                        // lendo singularidades da linha secundaria
                        L1singu = Convert.ToDouble(txbSecSing1.Text.Trim());

                        //lendo valores
                        Qt = Convert.ToDouble(txbVaz.Text.Trim());
                        perdacarga = Convert.ToDouble(txbPerda.Text.Trim());
                        ptrabalho = Convert.ToDouble(txbPress.Text.Trim());
                        aumentocapacidade = Convert.ToDouble(txbAuCap.Text.Trim());

                        // pre- calculos
                        Qt = Qt + Qt * (aumentocapacidade / 100);
                        Ltp = Lt1;

                        // Calculos da primeira linha secundaria               L1
                        Q1 = (Qt * L1) / Ltp;
                        L1 += L1singu;
                        diap = (0.001663785 * (Math.Pow(Q1, 1.85)) * L1) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp1.Text = Math.Round(diap, 4).ToString() + " mm";
                        break;

                    case 2:
                        // lendo
                        Lt1 = (Convert.ToDouble(txbSecComp1.Text)) * (Convert.ToDouble(txbSecQtd1.Text));
                        Lt2 = (Convert.ToDouble(txbSecComp2.Text)) * (Convert.ToDouble(txbSecQtd2.Text));
                        L1 = (Convert.ToDouble(txbSecComp1.Text));
                        L2 = (Convert.ToDouble(txbSecComp2.Text));


                        // lendo singularidades da linha secundaria
                        L1singu = Convert.ToDouble(txbSecSing1.Text.Trim());
                        L2singu = Convert.ToDouble(txbSecSing2.Text.Trim());

                        //lendo valores
                        Qt = Convert.ToDouble(txbVaz.Text.Trim());
                        perdacarga = Convert.ToDouble(txbPerda.Text.Trim());
                        ptrabalho = Convert.ToDouble(txbPress.Text.Trim());
                        aumentocapacidade = Convert.ToDouble(txbAuCap.Text.Trim());

                        // pre- calculos
                        Qt = Qt + Qt * (aumentocapacidade / 100);
                        Ltp = Lt1 + Lt2;

                        // Calculos da primeira linha secundaria               L1
                        Q1 = (Qt * L1) / Ltp;
                        L1 += L1singu;
                        diap = (0.001663785 * (Math.Pow(Q1, 1.85)) * L1) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp1.Text = Math.Round(diap, 4).ToString() + " mm";

                        // Calculos da segunda linha secundaria               L2
                        Q2 = (Qt * L2) / Ltp;
                        L2 += L2singu;
                        diap = (0.001663785 * (Math.Pow(Q2, 1.85)) * L2) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp2.Text =  Math.Round(diap, 4).ToString() + " mm";
                        break;

                    case 3:
                        // lendo
                        Lt1 = (Convert.ToDouble(txbSecComp1.Text)) * (Convert.ToDouble(txbSecQtd1.Text));
                        Lt2 = (Convert.ToDouble(txbSecComp2.Text)) * (Convert.ToDouble(txbSecQtd2.Text));
                        Lt3 = (Convert.ToDouble(txbSecComp3.Text)) * (Convert.ToDouble(txbSecQtd3.Text));
                        L1 = (Convert.ToDouble(txbSecComp1.Text));
                        L2 = (Convert.ToDouble(txbSecComp2.Text));
                        L3 = (Convert.ToDouble(txbSecComp3.Text));


                        // lendo singularidades da linha secundaria
                        L1singu = Convert.ToDouble(txbSecSing1.Text.Trim());
                        L2singu = Convert.ToDouble(txbSecSing2.Text.Trim());
                        L3singu = Convert.ToDouble(txbSecSing3.Text.Trim());

                        //lendo valores
                        Qt = Convert.ToDouble(txbVaz.Text.Trim());
                        perdacarga = Convert.ToDouble(txbPerda.Text.Trim());
                        ptrabalho = Convert.ToDouble(txbPress.Text.Trim());
                        aumentocapacidade = Convert.ToDouble(txbAuCap.Text.Trim());

                        // pre- calculos
                        Qt = Qt + Qt * (aumentocapacidade / 100);
                        Ltp = Lt1 + Lt2 + Lt3;

                        // Calculos da primeira linha secundaria               L1
                        Q1 = (Qt * L1) / Ltp;
                        L1 += L1singu;
                        diap = (0.001663785 * (Math.Pow(Q1, 1.85)) * L1) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp1.Text = Math.Round(diap, 4).ToString() + " mm";

                        // Calculos da segunda linha secundaria               L2
                        Q2 = (Qt * L2) / Ltp;
                        L2 += L2singu;
                        diap = (0.001663785 * (Math.Pow(Q2, 1.85)) * L2) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp2.Text = Math.Round(diap, 4).ToString() + " mm";

                        // Calculos da terceira linha secundaria               L3
                        Q3 = (Qt * L3) / Ltp;
                        L3 += L3singu;
                        diap = (0.001663785 * (Math.Pow(Q3, 1.85)) * L3) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp3.Text =  Math.Round(diap, 4).ToString() + " mm";
                        break;

                    case 4:
                        // lendo
                        Lt1 = (Convert.ToDouble(txbSecComp1.Text)) * (Convert.ToDouble(txbSecQtd1.Text));
                        Lt2 = (Convert.ToDouble(txbSecComp2.Text)) * (Convert.ToDouble(txbSecQtd2.Text));
                        Lt3 = (Convert.ToDouble(txbSecComp3.Text)) * (Convert.ToDouble(txbSecQtd3.Text));
                        Lt4 = (Convert.ToDouble(txbSecComp4.Text)) * (Convert.ToDouble(txbSecQtd4.Text));
                        L1 = (Convert.ToDouble(txbSecComp1.Text));
                        L2 = (Convert.ToDouble(txbSecComp2.Text));
                        L3 = (Convert.ToDouble(txbSecComp3.Text));
                        L4 = (Convert.ToDouble(txbSecComp4.Text));

                        // lendo singularidades da linha secundaria
                        L1singu = Convert.ToDouble(txbSecSing1.Text.Trim());
                        L2singu = Convert.ToDouble(txbSecSing2.Text.Trim());
                        L3singu = Convert.ToDouble(txbSecSing3.Text.Trim());
                        L4singu = Convert.ToDouble(txbSecSing4.Text.Trim());

                        //lendo valores
                        Qt = Convert.ToDouble(txbVaz.Text.Trim());
                        perdacarga = Convert.ToDouble(txbPerda.Text.Trim());
                        ptrabalho = Convert.ToDouble(txbPress.Text.Trim());
                        aumentocapacidade = Convert.ToDouble(txbAuCap.Text.Trim());

                        // pre- calculos
                        Qt = Qt + Qt * (aumentocapacidade / 100);
                        Ltp = Lt1 + Lt2 + Lt3 + Lt4;

                        // Calculos da primeira linha secundaria               L1
                        Q1 = (Qt * L1) / Ltp;
                        L1 += L1singu;
                        diap = (0.001663785 * (Math.Pow(Q1, 1.85)) * L1) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp1.Text = Math.Round(diap, 4).ToString() + " mm";

                        // Calculos da segunda linha secundaria               L2
                        Q2 = (Qt * L2) / Ltp;
                        L2 += L2singu;
                        diap = (0.001663785 * (Math.Pow(Q2, 1.85)) * L2) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp2.Text =  Math.Round(diap, 4).ToString() + " mm";

                        // Calculos da terceira linha secundaria               L3
                        Q3 = (Qt * L3) / Ltp;
                        L3 += L3singu;
                        diap = (0.001663785 * (Math.Pow(Q3, 1.85)) * L3) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp3.Text =  Math.Round(diap, 4).ToString() + " mm";

                        // Calculos da quarta linha secundaria               L4
                        Q4 = (Qt * L4) / Ltp;
                        L4 += L4singu;
                        diap = (0.001663785 * (Math.Pow(Q4, 1.85)) * L4) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp4.Text = Math.Round(diap, 4).ToString() + " mm";

                        break;

                    case 5:
                        // lendo
                        Lt1 = (Convert.ToDouble(txbSecComp1.Text)) * (Convert.ToDouble(txbSecQtd1.Text));
                        Lt2 = (Convert.ToDouble(txbSecComp2.Text)) * (Convert.ToDouble(txbSecQtd2.Text));
                        Lt3 = (Convert.ToDouble(txbSecComp3.Text)) * (Convert.ToDouble(txbSecQtd3.Text));
                        Lt4 = (Convert.ToDouble(txbSecComp4.Text)) * (Convert.ToDouble(txbSecQtd4.Text));
                        Lt5 = (Convert.ToDouble(txbSecComp5.Text)) * (Convert.ToDouble(txbSecQtd5.Text));
                        L1 = (Convert.ToDouble(txbSecComp1.Text));
                        L2 = (Convert.ToDouble(txbSecComp2.Text));
                        L3 = (Convert.ToDouble(txbSecComp3.Text));
                        L4 = (Convert.ToDouble(txbSecComp4.Text));
                        L5 = (Convert.ToDouble(txbSecComp5.Text));

                        // lendo singularidades da linha secundaria
                        L1singu = Convert.ToDouble(txbSecSing1.Text.Trim());
                        L2singu = Convert.ToDouble(txbSecSing2.Text.Trim());
                        L3singu = Convert.ToDouble(txbSecSing3.Text.Trim());
                        L4singu = Convert.ToDouble(txbSecSing4.Text.Trim());
                        L5singu = Convert.ToDouble(txbSecSing5.Text.Trim());

                        //lendo valores
                        Qt = Convert.ToDouble(txbVaz.Text.Trim());
                        perdacarga = Convert.ToDouble(txbPerda.Text.Trim());
                        ptrabalho = Convert.ToDouble(txbPress.Text.Trim());
                        aumentocapacidade = Convert.ToDouble(txbAuCap.Text.Trim());

                        // pre- calculos
                        Qt = Qt + Qt * (aumentocapacidade / 100);
                        Ltp = Lt1 + Lt2 + Lt3 + Lt4 + Lt5;

                        // Calculos da primeira linha secundaria               L1
                        Q1 = (Qt * L1) / Ltp;
                        L1 += L1singu;
                        diap = (0.001663785 * (Math.Pow(Q1, 1.85)) * L1) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp1.Text = Math.Round(diap, 4).ToString() + " mm";

                        // Calculos da segunda linha secundaria               L2
                        Q2 = (Qt * L2) / Ltp;
                        L2 += L2singu;
                        diap = (0.001663785 * (Math.Pow(Q2, 1.85)) * L2) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp2.Text =  Math.Round(diap, 4).ToString() + " mm";

                        // Calculos da terceira linha secundaria               L3
                        Q3 = (Qt * L3) / Ltp;
                        L3 += L3singu;
                        diap = (0.001663785 * (Math.Pow(Q3, 1.85)) * L3) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp3.Text =  Math.Round(diap, 4).ToString() + " mm";

                        // Calculos da quarta linha secundaria               L4
                        Q4 = (Qt * L4) / Ltp;
                        L4 += L4singu;
                        diap = (0.001663785 * (Math.Pow(Q4, 1.85)) * L4) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp4.Text =  Math.Round(diap, 4).ToString() + " mm";

                        // Calculos da quinta linha secundaria               L5
                        Q5 = (Qt * L5) / Ltp;
                        L5 += L5singu;
                        diap = (0.001663785 * (Math.Pow(Q5, 1.85)) * L5) / (perdacarga * ptrabalho);
                        diap = (Math.Pow(diap, 0.2)) * 10;
                        lblSecDiaResp5.Text =  Math.Round(diap, 4).ToString() + " mm";
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Confira os campos. Apenas números são aceitos!");
            }
            
            
        }

    }
}