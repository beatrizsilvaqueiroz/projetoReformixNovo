using System.Windows.Forms;

namespace Reformix.Tela_Principal
{
    partial class TelaPrincipal : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEstimadorTinta = new System.Windows.Forms.Button();
            this.btnHistoricoCalculo = new System.Windows.Forms.Button();
            this.btnCalculoAzulejo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameLogado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnEstimadorTinta);
            this.panel1.Controls.Add(this.btnHistoricoCalculo);
            this.panel1.Controls.Add(this.btnCalculoAzulejo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 616);
            this.panel1.TabIndex = 0;
            // 
            // btnEstimadorTinta
            // 
            this.btnEstimadorTinta.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEstimadorTinta.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimadorTinta.ForeColor = System.Drawing.Color.White;
            this.btnEstimadorTinta.Location = new System.Drawing.Point(26, 386);
            this.btnEstimadorTinta.Name = "btnEstimadorTinta";
            this.btnEstimadorTinta.Size = new System.Drawing.Size(385, 60);
            this.btnEstimadorTinta.TabIndex = 13;
            this.btnEstimadorTinta.Text = "Estimador de Tinta";
            this.btnEstimadorTinta.UseVisualStyleBackColor = false;
            this.btnEstimadorTinta.Click += new System.EventHandler(this.BtnEstimadorTinta_Click);
            // 
            // btnHistoricoCalculo
            // 
            this.btnHistoricoCalculo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHistoricoCalculo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoricoCalculo.ForeColor = System.Drawing.Color.White;
            this.btnHistoricoCalculo.Location = new System.Drawing.Point(26, 481);
            this.btnHistoricoCalculo.Name = "btnHistoricoCalculo";
            this.btnHistoricoCalculo.Size = new System.Drawing.Size(385, 60);
            this.btnHistoricoCalculo.TabIndex = 11;
            this.btnHistoricoCalculo.Text = "Histórico de Cálculo";
            this.btnHistoricoCalculo.UseVisualStyleBackColor = false;
            this.btnHistoricoCalculo.Click += new System.EventHandler(this.BtnHistoricoCalculo_Click);
            // 
            // btnCalculoAzulejo
            // 
            this.btnCalculoAzulejo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalculoAzulejo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculoAzulejo.ForeColor = System.Drawing.Color.White;
            this.btnCalculoAzulejo.Location = new System.Drawing.Point(26, 296);
            this.btnCalculoAzulejo.Name = "btnCalculoAzulejo";
            this.btnCalculoAzulejo.Size = new System.Drawing.Size(385, 60);
            this.btnCalculoAzulejo.TabIndex = 10;
            this.btnCalculoAzulejo.Text = "Cálculo de Azulejo ";
            this.btnCalculoAzulejo.UseVisualStyleBackColor = false;
            this.btnCalculoAzulejo.Click += new System.EventHandler(this.BtnCalculoAzulejo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "para a reforma de sua casa.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calcule o custo estimado do seu projeto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calculadora de custos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "de renovação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.nameLogado);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Location = new System.Drawing.Point(0, -9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // nameLogado
            // 
            this.nameLogado.AutoSize = true;
            this.nameLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLogado.Location = new System.Drawing.Point(293, 34);
            this.nameLogado.Name = "nameLogado";
            this.nameLogado.Size = new System.Drawing.Size(59, 24);
            this.nameLogado.TabIndex = 14;
            this.nameLogado.Text = "nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "REFORMIX";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(326, 28);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Reformix.Properties.Resources.imagem_logotipo__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 67);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(459, 640);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEstimadorTinta;
        private System.Windows.Forms.Button btnCalculoAzulejo;
        public Button btnHistoricoCalculo;
        private Label nameLogado;
        private PictureBox pictureBox1;
    }
}