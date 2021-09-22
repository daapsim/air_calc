
namespace APH_e_PV
{
    partial class feedbackemail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feedbackemail));
            this.btnEnvia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbbNao = new System.Windows.Forms.RadioButton();
            this.rbbSim = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbbBaixo = new System.Windows.Forms.RadioButton();
            this.rbbMedio = new System.Windows.Forms.RadioButton();
            this.rbbAlto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnvia
            // 
            this.btnEnvia.Location = new System.Drawing.Point(191, 207);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(75, 23);
            this.btnEnvia.TabIndex = 0;
            this.btnEnvia.Text = "Enviar";
            this.btnEnvia.UseVisualStyleBackColor = true;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.rbbNao);
            this.groupBox1.Controls.Add(this.rbbSim);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indicaria o programa para alguém?";
            // 
            // rbbNao
            // 
            this.rbbNao.AutoSize = true;
            this.rbbNao.Location = new System.Drawing.Point(78, 68);
            this.rbbNao.Name = "rbbNao";
            this.rbbNao.Size = new System.Drawing.Size(45, 17);
            this.rbbNao.TabIndex = 1;
            this.rbbNao.TabStop = true;
            this.rbbNao.Text = "Não";
            this.rbbNao.UseVisualStyleBackColor = true;
            // 
            // rbbSim
            // 
            this.rbbSim.AutoSize = true;
            this.rbbSim.Location = new System.Drawing.Point(78, 32);
            this.rbbSim.Name = "rbbSim";
            this.rbbSim.Size = new System.Drawing.Size(42, 17);
            this.rbbSim.TabIndex = 0;
            this.rbbSim.TabStop = true;
            this.rbbSim.Text = "Sim";
            this.rbbSim.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.rbbBaixo);
            this.groupBox2.Controls.Add(this.rbbMedio);
            this.groupBox2.Controls.Add(this.rbbAlto);
            this.groupBox2.Location = new System.Drawing.Point(235, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grau o seu grau de satisfação?";
            // 
            // rbbBaixo
            // 
            this.rbbBaixo.AutoSize = true;
            this.rbbBaixo.Location = new System.Drawing.Point(75, 77);
            this.rbbBaixo.Name = "rbbBaixo";
            this.rbbBaixo.Size = new System.Drawing.Size(51, 17);
            this.rbbBaixo.TabIndex = 4;
            this.rbbBaixo.TabStop = true;
            this.rbbBaixo.Text = "Baixa";
            this.rbbBaixo.UseVisualStyleBackColor = true;
            // 
            // rbbMedio
            // 
            this.rbbMedio.AutoSize = true;
            this.rbbMedio.Location = new System.Drawing.Point(75, 55);
            this.rbbMedio.Name = "rbbMedio";
            this.rbbMedio.Size = new System.Drawing.Size(54, 17);
            this.rbbMedio.TabIndex = 3;
            this.rbbMedio.TabStop = true;
            this.rbbMedio.Text = "Média";
            this.rbbMedio.UseVisualStyleBackColor = true;
            // 
            // rbbAlto
            // 
            this.rbbAlto.AutoSize = true;
            this.rbbAlto.Location = new System.Drawing.Point(75, 32);
            this.rbbAlto.Name = "rbbAlto";
            this.rbbAlto.Size = new System.Drawing.Size(43, 17);
            this.rbbAlto.TabIndex = 2;
            this.rbbAlto.TabStop = true;
            this.rbbAlto.Text = "Alta";
            this.rbbAlto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o seu e-mail para receber novidades";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(129, 172);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(197, 20);
            this.txbEmail.TabIndex = 4;
            this.txbEmail.Click += new System.EventHandler(this.txbEmail_Click);
            // 
            // feedbackemail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 259);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnvia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "feedbackemail";
            this.Text = "Avaliação";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbbNao;
        private System.Windows.Forms.RadioButton rbbSim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbbBaixo;
        private System.Windows.Forms.RadioButton rbbMedio;
        private System.Windows.Forms.RadioButton rbbAlto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEmail;
    }
}