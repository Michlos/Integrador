namespace Integrador.GUI
{
    partial class OnBloxConfigureGUI
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
            this.clientesGroupBox = new System.Windows.Forms.GroupBox();
            this.assuntoEmailClienteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.integraClienteCheckBox = new System.Windows.Forms.CheckBox();
            this.bateladaGroupBox = new System.Windows.Forms.GroupBox();
            this.localArquivoButton = new System.Windows.Forms.Button();
            this.localArquivoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.integraBateladaCheckBox = new System.Windows.Forms.CheckBox();
            this.localArquivoBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.uriPostTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.userGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.clientesGroupBox.SuspendLayout();
            this.bateladaGroupBox.SuspendLayout();
            this.userGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientesGroupBox
            // 
            this.clientesGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.clientesGroupBox.Controls.Add(this.uriPostTextBox);
            this.clientesGroupBox.Controls.Add(this.label3);
            this.clientesGroupBox.Controls.Add(this.assuntoEmailClienteTextBox);
            this.clientesGroupBox.Controls.Add(this.label1);
            this.clientesGroupBox.Controls.Add(this.integraClienteCheckBox);
            this.clientesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesGroupBox.Location = new System.Drawing.Point(12, 119);
            this.clientesGroupBox.Name = "clientesGroupBox";
            this.clientesGroupBox.Size = new System.Drawing.Size(496, 110);
            this.clientesGroupBox.TabIndex = 0;
            this.clientesGroupBox.TabStop = false;
            this.clientesGroupBox.Text = "Clientes";
            // 
            // assuntoEmailClienteTextBox
            // 
            this.assuntoEmailClienteTextBox.Location = new System.Drawing.Point(118, 40);
            this.assuntoEmailClienteTextBox.Name = "assuntoEmailClienteTextBox";
            this.assuntoEmailClienteTextBox.Size = new System.Drawing.Size(357, 20);
            this.assuntoEmailClienteTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assunto do E-Mail:";
            // 
            // integraClienteCheckBox
            // 
            this.integraClienteCheckBox.AutoSize = true;
            this.integraClienteCheckBox.Location = new System.Drawing.Point(17, 19);
            this.integraClienteCheckBox.Name = "integraClienteCheckBox";
            this.integraClienteCheckBox.Size = new System.Drawing.Size(61, 17);
            this.integraClienteCheckBox.TabIndex = 0;
            this.integraClienteCheckBox.Text = "integrar";
            this.integraClienteCheckBox.UseVisualStyleBackColor = true;
            // 
            // bateladaGroupBox
            // 
            this.bateladaGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.bateladaGroupBox.Controls.Add(this.localArquivoButton);
            this.bateladaGroupBox.Controls.Add(this.localArquivoTextBox);
            this.bateladaGroupBox.Controls.Add(this.label2);
            this.bateladaGroupBox.Controls.Add(this.integraBateladaCheckBox);
            this.bateladaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bateladaGroupBox.Location = new System.Drawing.Point(12, 248);
            this.bateladaGroupBox.Name = "bateladaGroupBox";
            this.bateladaGroupBox.Size = new System.Drawing.Size(496, 93);
            this.bateladaGroupBox.TabIndex = 0;
            this.bateladaGroupBox.TabStop = false;
            this.bateladaGroupBox.Text = "Batelada";
            // 
            // localArquivoButton
            // 
            this.localArquivoButton.Location = new System.Drawing.Point(457, 39);
            this.localArquivoButton.Name = "localArquivoButton";
            this.localArquivoButton.Size = new System.Drawing.Size(27, 23);
            this.localArquivoButton.TabIndex = 3;
            this.localArquivoButton.Text = "...";
            this.localArquivoButton.UseVisualStyleBackColor = true;
            this.localArquivoButton.Click += new System.EventHandler(this.localArquivoButton_Click);
            // 
            // localArquivoTextBox
            // 
            this.localArquivoTextBox.Location = new System.Drawing.Point(118, 40);
            this.localArquivoTextBox.Name = "localArquivoTextBox";
            this.localArquivoTextBox.Size = new System.Drawing.Size(333, 20);
            this.localArquivoTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local do Arquivo:";
            // 
            // integraBateladaCheckBox
            // 
            this.integraBateladaCheckBox.AutoSize = true;
            this.integraBateladaCheckBox.Location = new System.Drawing.Point(17, 19);
            this.integraBateladaCheckBox.Name = "integraBateladaCheckBox";
            this.integraBateladaCheckBox.Size = new System.Drawing.Size(61, 17);
            this.integraBateladaCheckBox.TabIndex = 0;
            this.integraBateladaCheckBox.Text = "integrar";
            this.integraBateladaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "URI Post:";
            // 
            // uriPostTextBox
            // 
            this.uriPostTextBox.Location = new System.Drawing.Point(118, 66);
            this.uriPostTextBox.Name = "uriPostTextBox";
            this.uriPostTextBox.Size = new System.Drawing.Size(357, 20);
            this.uriPostTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Usuário:";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(117, 19);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(139, 20);
            this.usuarioTextBox.TabIndex = 2;
            // 
            // userGroupBox
            // 
            this.userGroupBox.Controls.Add(this.senhaTextBox);
            this.userGroupBox.Controls.Add(this.label5);
            this.userGroupBox.Controls.Add(this.usuarioTextBox);
            this.userGroupBox.Controls.Add(this.label4);
            this.userGroupBox.Location = new System.Drawing.Point(13, 13);
            this.userGroupBox.Name = "userGroupBox";
            this.userGroupBox.Size = new System.Drawing.Size(272, 88);
            this.userGroupBox.TabIndex = 1;
            this.userGroupBox.TabStop = false;
            this.userGroupBox.Text = "Configurações do Usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Senha:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(117, 55);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(139, 20);
            this.senhaTextBox.TabIndex = 2;
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(433, 357);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 2;
            this.salvarButton.Text = "&Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            // 
            // OnBloxConfigureGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 392);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.userGroupBox);
            this.Controls.Add(this.bateladaGroupBox);
            this.Controls.Add(this.clientesGroupBox);
            this.Name = "OnBloxConfigureGUI";
            this.Text = "Configuração para Integração do OnBlox";
            this.clientesGroupBox.ResumeLayout(false);
            this.clientesGroupBox.PerformLayout();
            this.bateladaGroupBox.ResumeLayout(false);
            this.bateladaGroupBox.PerformLayout();
            this.userGroupBox.ResumeLayout(false);
            this.userGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox clientesGroupBox;
        private System.Windows.Forms.TextBox assuntoEmailClienteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox integraClienteCheckBox;
        private System.Windows.Forms.GroupBox bateladaGroupBox;
        private System.Windows.Forms.TextBox localArquivoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox integraBateladaCheckBox;
        private System.Windows.Forms.Button localArquivoButton;
        private System.Windows.Forms.FolderBrowserDialog localArquivoBrowserDialog;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uriPostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox userGroupBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button salvarButton;
    }
}