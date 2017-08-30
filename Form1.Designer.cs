namespace Consumindo_WebService_SMS
{
    partial class Form1
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
            this.edRetornos = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicionarDestinatarios = new System.Windows.Forms.Button();
            this.mskDestinatario = new System.Windows.Forms.MaskedTextBox();
            this.lstDestinatarios = new System.Windows.Forms.ListBox();
            this.edMensagem = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edUsuario = new System.Windows.Forms.TextBox();
            this.edSenha = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edRetornos
            // 
            this.edRetornos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edRetornos.Location = new System.Drawing.Point(12, 347);
            this.edRetornos.Name = "edRetornos";
            this.edRetornos.Size = new System.Drawing.Size(310, 56);
            this.edRetornos.TabIndex = 9;
            this.edRetornos.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Retornos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edSenha);
            this.panel1.Controls.Add(this.edUsuario);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnAdicionarDestinatarios);
            this.panel1.Controls.Add(this.mskDestinatario);
            this.panel1.Controls.Add(this.lstDestinatarios);
            this.panel1.Controls.Add(this.edMensagem);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 301);
            this.panel1.TabIndex = 11;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(221, 265);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAdicionarDestinatarios
            // 
            this.btnAdicionarDestinatarios.Location = new System.Drawing.Point(166, 157);
            this.btnAdicionarDestinatarios.Name = "btnAdicionarDestinatarios";
            this.btnAdicionarDestinatarios.Size = new System.Drawing.Size(131, 23);
            this.btnAdicionarDestinatarios.TabIndex = 4;
            this.btnAdicionarDestinatarios.Text = "Adicionar Destinatário";
            this.btnAdicionarDestinatarios.UseVisualStyleBackColor = true;
            this.btnAdicionarDestinatarios.Click += new System.EventHandler(this.btnAdicionarDestinatarios_Click);
            // 
            // mskDestinatario
            // 
            this.mskDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDestinatario.Location = new System.Drawing.Point(61, 159);
            this.mskDestinatario.Mask = "(99) 00000-0000";
            this.mskDestinatario.Name = "mskDestinatario";
            this.mskDestinatario.Size = new System.Drawing.Size(100, 20);
            this.mskDestinatario.TabIndex = 3;
            // 
            // lstDestinatarios
            // 
            this.lstDestinatarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDestinatarios.FormattingEnabled = true;
            this.lstDestinatarios.Location = new System.Drawing.Point(61, 185);
            this.lstDestinatarios.Name = "lstDestinatarios";
            this.lstDestinatarios.Size = new System.Drawing.Size(236, 67);
            this.lstDestinatarios.TabIndex = 5;
            // 
            // edMensagem
            // 
            this.edMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edMensagem.Location = new System.Drawing.Point(61, 66);
            this.edMensagem.Name = "edMensagem";
            this.edMensagem.Size = new System.Drawing.Size(236, 72);
            this.edMensagem.TabIndex = 2;
            this.edMensagem.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(140, 265);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Usuário";
            // 
            // edUsuario
            // 
            this.edUsuario.Location = new System.Drawing.Point(61, 17);
            this.edUsuario.Name = "edUsuario";
            this.edUsuario.Size = new System.Drawing.Size(235, 20);
            this.edUsuario.TabIndex = 0;
            // 
            // edSenha
            // 
            this.edSenha.Location = new System.Drawing.Point(61, 41);
            this.edSenha.Name = "edSenha";
            this.edSenha.Size = new System.Drawing.Size(235, 20);
            this.edSenha.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edRetornos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumindo Servico de SMS";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox edRetornos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox edMensagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;        
        private System.Windows.Forms.Button btnAdicionarDestinatarios;
        private System.Windows.Forms.MaskedTextBox mskDestinatario;
        private System.Windows.Forms.ListBox lstDestinatarios;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox edSenha;
        private System.Windows.Forms.TextBox edUsuario;
    }
}

