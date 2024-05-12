namespace Integrador.GUI
{
    partial class EmailConfigureGUI
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
            this.sslSaidaCheckBox = new System.Windows.Forms.CheckBox();
            this.sslEntradaCheckBox = new System.Windows.Forms.CheckBox();
            this.smtpPortaTextBox = new System.Windows.Forms.TextBox();
            this.entradaPortaTextBox = new System.Windows.Forms.TextBox();
            this.smtpServerTextBox = new System.Windows.Forms.TextBox();
            this.entradaServerTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.caixaDeEmailTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.PortaDeEnvioLabel = new System.Windows.Forms.Label();
            this.ServidorDeEnvioLabel = new System.Windows.Forms.Label();
            this.PortaDeEntradaLabel = new System.Windows.Forms.Label();
            this.ServidorEntradaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SenhaLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.salvarButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.verEmailButton = new System.Windows.Forms.Button();
            this.configContaEmailGroupBox = new System.Windows.Forms.GroupBox();
            this.configBuscaEmailGroupBox = new System.Windows.Forms.GroupBox();
            this.pastaTemporariaButton = new System.Windows.Forms.Button();
            this.pastaTemporairaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tagsExtracaoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.finalRelatorioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailAssuntoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inicioRelatoiroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selecaoPastaTemporariafolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.configContaEmailGroupBox.SuspendLayout();
            this.configBuscaEmailGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sslSaidaCheckBox
            // 
            this.sslSaidaCheckBox.AutoSize = true;
            this.sslSaidaCheckBox.Location = new System.Drawing.Point(200, 188);
            this.sslSaidaCheckBox.Name = "sslSaidaCheckBox";
            this.sslSaidaCheckBox.Size = new System.Drawing.Size(46, 17);
            this.sslSaidaCheckBox.TabIndex = 7;
            this.sslSaidaCheckBox.Text = "SSL";
            this.sslSaidaCheckBox.UseVisualStyleBackColor = true;
            // 
            // sslEntradaCheckBox
            // 
            this.sslEntradaCheckBox.AutoSize = true;
            this.sslEntradaCheckBox.Location = new System.Drawing.Point(200, 124);
            this.sslEntradaCheckBox.Name = "sslEntradaCheckBox";
            this.sslEntradaCheckBox.Size = new System.Drawing.Size(46, 17);
            this.sslEntradaCheckBox.TabIndex = 4;
            this.sslEntradaCheckBox.Text = "SSL";
            this.sslEntradaCheckBox.UseVisualStyleBackColor = true;
            // 
            // smtpPortaTextBox
            // 
            this.smtpPortaTextBox.Location = new System.Drawing.Point(126, 186);
            this.smtpPortaTextBox.Name = "smtpPortaTextBox";
            this.smtpPortaTextBox.Size = new System.Drawing.Size(62, 20);
            this.smtpPortaTextBox.TabIndex = 6;
            this.smtpPortaTextBox.WordWrap = false;
            // 
            // entradaPortaTextBox
            // 
            this.entradaPortaTextBox.Location = new System.Drawing.Point(126, 122);
            this.entradaPortaTextBox.Name = "entradaPortaTextBox";
            this.entradaPortaTextBox.Size = new System.Drawing.Size(62, 20);
            this.entradaPortaTextBox.TabIndex = 3;
            this.entradaPortaTextBox.WordWrap = false;
            // 
            // smtpServerTextBox
            // 
            this.smtpServerTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.smtpServerTextBox.Location = new System.Drawing.Point(126, 154);
            this.smtpServerTextBox.Name = "smtpServerTextBox";
            this.smtpServerTextBox.Size = new System.Drawing.Size(132, 20);
            this.smtpServerTextBox.TabIndex = 5;
            this.smtpServerTextBox.WordWrap = false;
            // 
            // entradaServerTextBox
            // 
            this.entradaServerTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.entradaServerTextBox.Location = new System.Drawing.Point(126, 90);
            this.entradaServerTextBox.Name = "entradaServerTextBox";
            this.entradaServerTextBox.Size = new System.Drawing.Size(132, 20);
            this.entradaServerTextBox.TabIndex = 2;
            this.entradaServerTextBox.WordWrap = false;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(61, 58);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(121, 20);
            this.senhaTextBox.TabIndex = 1;
            this.senhaTextBox.WordWrap = false;
            // 
            // caixaDeEmailTextBox
            // 
            this.caixaDeEmailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.caixaDeEmailTextBox.Location = new System.Drawing.Point(118, 26);
            this.caixaDeEmailTextBox.Name = "caixaDeEmailTextBox";
            this.caixaDeEmailTextBox.Size = new System.Drawing.Size(88, 20);
            this.caixaDeEmailTextBox.TabIndex = 0;
            this.caixaDeEmailTextBox.WordWrap = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.emailTextBox.Location = new System.Drawing.Point(61, 26);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(219, 20);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.WordWrap = false;
            // 
            // PortaDeEnvioLabel
            // 
            this.PortaDeEnvioLabel.AutoSize = true;
            this.PortaDeEnvioLabel.Location = new System.Drawing.Point(40, 189);
            this.PortaDeEnvioLabel.Name = "PortaDeEnvioLabel";
            this.PortaDeEnvioLabel.Size = new System.Drawing.Size(80, 13);
            this.PortaDeEnvioLabel.TabIndex = 0;
            this.PortaDeEnvioLabel.Text = "Porta de Envio:";
            // 
            // ServidorDeEnvioLabel
            // 
            this.ServidorDeEnvioLabel.AutoSize = true;
            this.ServidorDeEnvioLabel.Location = new System.Drawing.Point(26, 157);
            this.ServidorDeEnvioLabel.Name = "ServidorDeEnvioLabel";
            this.ServidorDeEnvioLabel.Size = new System.Drawing.Size(94, 13);
            this.ServidorDeEnvioLabel.TabIndex = 0;
            this.ServidorDeEnvioLabel.Text = "Servidor de Envio:";
            // 
            // PortaDeEntradaLabel
            // 
            this.PortaDeEntradaLabel.AutoSize = true;
            this.PortaDeEntradaLabel.Location = new System.Drawing.Point(30, 125);
            this.PortaDeEntradaLabel.Name = "PortaDeEntradaLabel";
            this.PortaDeEntradaLabel.Size = new System.Drawing.Size(90, 13);
            this.PortaDeEntradaLabel.TabIndex = 0;
            this.PortaDeEntradaLabel.Text = "Porta de Entrada:";
            // 
            // ServidorEntradaLabel
            // 
            this.ServidorEntradaLabel.AutoSize = true;
            this.ServidorEntradaLabel.Location = new System.Drawing.Point(16, 93);
            this.ServidorEntradaLabel.Name = "ServidorEntradaLabel";
            this.ServidorEntradaLabel.Size = new System.Drawing.Size(104, 13);
            this.ServidorEntradaLabel.TabIndex = 0;
            this.ServidorEntradaLabel.Text = "Servidor de Entrada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caixa de E-Mail:";
            // 
            // SenhaLabel
            // 
            this.SenhaLabel.AutoSize = true;
            this.SenhaLabel.Location = new System.Drawing.Point(16, 61);
            this.SenhaLabel.Name = "SenhaLabel";
            this.SenhaLabel.Size = new System.Drawing.Size(41, 13);
            this.SenhaLabel.TabIndex = 0;
            this.SenhaLabel.Text = "Senha:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(16, 29);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(39, 13);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "E-Mail:";
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(578, 245);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 3;
            this.salvarButton.Text = "&Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(659, 244);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 4;
            this.sairButton.Text = "Sai&r";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // verEmailButton
            // 
            this.verEmailButton.Location = new System.Drawing.Point(11, 244);
            this.verEmailButton.Name = "verEmailButton";
            this.verEmailButton.Size = new System.Drawing.Size(90, 23);
            this.verEmailButton.TabIndex = 2;
            this.verEmailButton.Text = "Listar E-Mails";
            this.verEmailButton.UseVisualStyleBackColor = true;
            this.verEmailButton.Click += new System.EventHandler(this.verEmailButton_Click);
            // 
            // configContaEmailGroupBox
            // 
            this.configContaEmailGroupBox.Controls.Add(this.sslSaidaCheckBox);
            this.configContaEmailGroupBox.Controls.Add(this.senhaTextBox);
            this.configContaEmailGroupBox.Controls.Add(this.sslEntradaCheckBox);
            this.configContaEmailGroupBox.Controls.Add(this.EmailLabel);
            this.configContaEmailGroupBox.Controls.Add(this.smtpPortaTextBox);
            this.configContaEmailGroupBox.Controls.Add(this.SenhaLabel);
            this.configContaEmailGroupBox.Controls.Add(this.entradaPortaTextBox);
            this.configContaEmailGroupBox.Controls.Add(this.ServidorEntradaLabel);
            this.configContaEmailGroupBox.Controls.Add(this.smtpServerTextBox);
            this.configContaEmailGroupBox.Controls.Add(this.PortaDeEntradaLabel);
            this.configContaEmailGroupBox.Controls.Add(this.entradaServerTextBox);
            this.configContaEmailGroupBox.Controls.Add(this.ServidorDeEnvioLabel);
            this.configContaEmailGroupBox.Controls.Add(this.PortaDeEnvioLabel);
            this.configContaEmailGroupBox.Controls.Add(this.emailTextBox);
            this.configContaEmailGroupBox.Location = new System.Drawing.Point(12, 12);
            this.configContaEmailGroupBox.Name = "configContaEmailGroupBox";
            this.configContaEmailGroupBox.Size = new System.Drawing.Size(334, 226);
            this.configContaEmailGroupBox.TabIndex = 0;
            this.configContaEmailGroupBox.TabStop = false;
            this.configContaEmailGroupBox.Text = "Conta de E-Mail";
            // 
            // configBuscaEmailGroupBox
            // 
            this.configBuscaEmailGroupBox.Controls.Add(this.pastaTemporariaButton);
            this.configBuscaEmailGroupBox.Controls.Add(this.caixaDeEmailTextBox);
            this.configBuscaEmailGroupBox.Controls.Add(this.label1);
            this.configBuscaEmailGroupBox.Controls.Add(this.pastaTemporairaTextBox);
            this.configBuscaEmailGroupBox.Controls.Add(this.label5);
            this.configBuscaEmailGroupBox.Controls.Add(this.tagsExtracaoTextBox);
            this.configBuscaEmailGroupBox.Controls.Add(this.label4);
            this.configBuscaEmailGroupBox.Controls.Add(this.finalRelatorioTextBox);
            this.configBuscaEmailGroupBox.Controls.Add(this.label3);
            this.configBuscaEmailGroupBox.Controls.Add(this.emailAssuntoTextBox);
            this.configBuscaEmailGroupBox.Controls.Add(this.label6);
            this.configBuscaEmailGroupBox.Controls.Add(this.inicioRelatoiroTextBox);
            this.configBuscaEmailGroupBox.Controls.Add(this.label2);
            this.configBuscaEmailGroupBox.Location = new System.Drawing.Point(365, 12);
            this.configBuscaEmailGroupBox.Name = "configBuscaEmailGroupBox";
            this.configBuscaEmailGroupBox.Size = new System.Drawing.Size(369, 226);
            this.configBuscaEmailGroupBox.TabIndex = 1;
            this.configBuscaEmailGroupBox.TabStop = false;
            this.configBuscaEmailGroupBox.Text = "Configureção de Busca";
            // 
            // pastaTemporariaButton
            // 
            this.pastaTemporariaButton.Location = new System.Drawing.Point(320, 181);
            this.pastaTemporariaButton.Name = "pastaTemporariaButton";
            this.pastaTemporariaButton.Size = new System.Drawing.Size(23, 23);
            this.pastaTemporariaButton.TabIndex = 5;
            this.pastaTemporariaButton.Text = "...";
            this.pastaTemporariaButton.UseVisualStyleBackColor = true;
            this.pastaTemporariaButton.Click += new System.EventHandler(this.pastaTemporariaButton_Click);
            // 
            // pastaTemporairaTextBox
            // 
            this.pastaTemporairaTextBox.Location = new System.Drawing.Point(118, 182);
            this.pastaTemporairaTextBox.Name = "pastaTemporairaTextBox";
            this.pastaTemporairaTextBox.Size = new System.Drawing.Size(196, 20);
            this.pastaTemporairaTextBox.TabIndex = 4;
            this.pastaTemporairaTextBox.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pasta Temporária:";
            // 
            // tagsExtracaoTextBox
            // 
            this.tagsExtracaoTextBox.Location = new System.Drawing.Point(118, 150);
            this.tagsExtracaoTextBox.Name = "tagsExtracaoTextBox";
            this.tagsExtracaoTextBox.Size = new System.Drawing.Size(133, 20);
            this.tagsExtracaoTextBox.TabIndex = 3;
            this.tagsExtracaoTextBox.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tags de  Extração:";
            // 
            // finalRelatorioTextBox
            // 
            this.finalRelatorioTextBox.Location = new System.Drawing.Point(118, 118);
            this.finalRelatorioTextBox.Name = "finalRelatorioTextBox";
            this.finalRelatorioTextBox.Size = new System.Drawing.Size(225, 20);
            this.finalRelatorioTextBox.TabIndex = 2;
            this.finalRelatorioTextBox.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Final do Relatório:";
            // 
            // emailAssuntoTextBox
            // 
            this.emailAssuntoTextBox.Location = new System.Drawing.Point(118, 58);
            this.emailAssuntoTextBox.Name = "emailAssuntoTextBox";
            this.emailAssuntoTextBox.Size = new System.Drawing.Size(225, 20);
            this.emailAssuntoTextBox.TabIndex = 1;
            this.emailAssuntoTextBox.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Assunto do E-Mail:";
            // 
            // inicioRelatoiroTextBox
            // 
            this.inicioRelatoiroTextBox.Location = new System.Drawing.Point(118, 86);
            this.inicioRelatoiroTextBox.Name = "inicioRelatoiroTextBox";
            this.inicioRelatoiroTextBox.Size = new System.Drawing.Size(225, 20);
            this.inicioRelatoiroTextBox.TabIndex = 1;
            this.inicioRelatoiroTextBox.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Início do Relatório:";
            // 
            // selecaoPastaTemporariafolderBrowserDialog
            // 
            this.selecaoPastaTemporariafolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.selecaoPastaTemporariafolderBrowserDialog.SelectedPath = "C:\\";
            // 
            // EmailConfigureGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(746, 280);
            this.Controls.Add(this.configBuscaEmailGroupBox);
            this.Controls.Add(this.configContaEmailGroupBox);
            this.Controls.Add(this.verEmailButton);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.salvarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailConfigureGUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuração de E-Mail";
            this.Load += new System.EventHandler(this.EmailConfigureGUI_Load);
            this.configContaEmailGroupBox.ResumeLayout(false);
            this.configContaEmailGroupBox.PerformLayout();
            this.configBuscaEmailGroupBox.ResumeLayout(false);
            this.configBuscaEmailGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SenhaLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label PortaDeEnvioLabel;
        private System.Windows.Forms.Label ServidorDeEnvioLabel;
        private System.Windows.Forms.Label PortaDeEntradaLabel;
        private System.Windows.Forms.Label ServidorEntradaLabel;
        private System.Windows.Forms.TextBox entradaPortaTextBox;
        private System.Windows.Forms.TextBox entradaServerTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox smtpServerTextBox;
        private System.Windows.Forms.CheckBox sslSaidaCheckBox;
        private System.Windows.Forms.CheckBox sslEntradaCheckBox;
        private System.Windows.Forms.TextBox smtpPortaTextBox;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button verEmailButton;
        private System.Windows.Forms.TextBox caixaDeEmailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox configContaEmailGroupBox;
        private System.Windows.Forms.GroupBox configBuscaEmailGroupBox;
        private System.Windows.Forms.TextBox inicioRelatoiroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tagsExtracaoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox finalRelatorioTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pastaTemporariaButton;
        private System.Windows.Forms.TextBox pastaTemporairaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog selecaoPastaTemporariafolderBrowserDialog;
        private System.Windows.Forms.TextBox emailAssuntoTextBox;
        private System.Windows.Forms.Label label6;
    }
}