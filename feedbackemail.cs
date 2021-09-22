using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace APH_e_PV
{
    public partial class feedbackemail : Toolbox
    {
        public feedbackemail()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(CancelaX);
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            string indica = "";
            string satisf = "";
            string email = "";

            if (rbbSim.Checked == true)
            {
                indica = "Sim";
            }
            if (rbbNao.Checked == true)
            {
                indica = "Não";
            }

            if(rbbAlto.Checked == true)
            {
                satisf = "Alta";
            }

            if (rbbMedio.Checked == true)
            {
                satisf = "Média";
            }

            if (rbbBaixo.Checked == true)
            {
                satisf = "Baixa";
            }

            email = txbEmail.Text;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("eca4n212021@gmail.com", "tazvaz20");
            MailMessage mail = new MailMessage();
            mail.Sender = new MailAddress("eca4n212021@gmail.com", "ENVIADOR");
            mail.From = new MailAddress("eca4n212021@gmail.com", "ENVIADOR");
            mail.To.Add(new MailAddress("eca4n212021@gmail.com", "RECEBEDOR"));
            mail.Subject = "Contato";
            string msg = " Indicaria: " + indica + "       Satisfação: " + satisf + "       Email: " + email;
            mail.Body = msg;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            try
            {
                client.Send(mail);
            }
            catch
            {
                MessageBox.Show("Erro!! Talvez você esteja sem acesso à internet");
            }

            finally
            {
                mail = null;
                MessageBox.Show("Obrigado por avaliar! ");
                this.Hide();
            }
        }

        private void txbEmail_Click(object sender, EventArgs e)
        {
            txbEmail.Text = null;
        }
    }
}
