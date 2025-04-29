namespace Reformix.TelaPerfil
{
    partial class TelaPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPerfil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.grpInfoPerfil = new System.Windows.Forms.GroupBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterarFoto = new System.Windows.Forms.Button();
            this.picFotoPerfil = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLogoTexto = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.grpInfoPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnEditarPerfil);
            this.groupBox1.Controls.Add(this.grpInfoPerfil);
            this.groupBox1.Controls.Add(this.btnAlterarFoto);
            this.groupBox1.Controls.Add(this.picFotoPerfil);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 616);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPerfil.Location = new System.Drawing.Point(153, 563);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(116, 36);
            this.btnEditarPerfil.TabIndex = 5;
            this.btnEditarPerfil.Text = "Editar Perfil";
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            // 
            // grpInfoPerfil
            // 
            this.grpInfoPerfil.Controls.Add(this.mtbTelefone);
            this.grpInfoPerfil.Controls.Add(this.lblTelefone);
            this.grpInfoPerfil.Controls.Add(this.txtEmail);
            this.grpInfoPerfil.Controls.Add(this.lblEmail);
            this.grpInfoPerfil.Controls.Add(this.txtNome);
            this.grpInfoPerfil.Controls.Add(this.lblNome);
            this.grpInfoPerfil.Controls.Add(this.label2);
            this.grpInfoPerfil.Location = new System.Drawing.Point(21, 302);
            this.grpInfoPerfil.Name = "grpInfoPerfil";
            this.grpInfoPerfil.Size = new System.Drawing.Size(390, 227);
            this.grpInfoPerfil.TabIndex = 4;
            this.grpInfoPerfil.TabStop = false;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(11, 201);
            this.mtbTelefone.Mask = "(00) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.ReadOnly = true;
            this.mtbTelefone.Size = new System.Drawing.Size(146, 20);
            this.mtbTelefone.TabIndex = 6;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(8, 175);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 17);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(8, 113);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(151, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(8, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(109, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Informações do Perfil";
            // 
            // btnAlterarFoto
            // 
            this.btnAlterarFoto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFoto.Location = new System.Drawing.Point(153, 245);
            this.btnAlterarFoto.Name = "btnAlterarFoto";
            this.btnAlterarFoto.Size = new System.Drawing.Size(120, 37);
            this.btnAlterarFoto.TabIndex = 2;
            this.btnAlterarFoto.Text = "Alterar Foto";
            this.btnAlterarFoto.UseVisualStyleBackColor = true;
            // 
            // picFotoPerfil
            // 
            this.picFotoPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFotoPerfil.BackgroundImage")));
            this.picFotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotoPerfil.Location = new System.Drawing.Point(153, 105);
            this.picFotoPerfil.Name = "picFotoPerfil";
            this.picFotoPerfil.Size = new System.Drawing.Size(120, 120);
            this.picFotoPerfil.TabIndex = 1;
            this.picFotoPerfil.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lblLogoTexto);
            this.groupBox2.Controls.Add(this.picLogo);
            this.groupBox2.Location = new System.Drawing.Point(0, -12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 72);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // lblLogoTexto
            // 
            this.lblLogoTexto.AutoSize = true;
            this.lblLogoTexto.Font = new System.Drawing.Font("Nirmala Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoTexto.Location = new System.Drawing.Point(95, 28);
            this.lblLogoTexto.Name = "lblLogoTexto";
            this.lblLogoTexto.Size = new System.Drawing.Size(106, 25);
            this.lblLogoTexto.TabIndex = 1;
            this.lblLogoTexto.Text = "REFORMIX";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(0, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(112, 58);
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // TelaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(459, 640);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TelaPerfil";
            this.Text = "TelaPerfil";
            this.groupBox1.ResumeLayout(false);
            this.grpInfoPerfil.ResumeLayout(false);
            this.grpInfoPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditarPerfil;
        private System.Windows.Forms.GroupBox grpInfoPerfil;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlterarFoto;
        private System.Windows.Forms.PictureBox picFotoPerfil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLogoTexto;
        private System.Windows.Forms.PictureBox picLogo;
    }
}