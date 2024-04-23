﻿namespace Integrador.GUI
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
            this.panelEmailConfigure = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.PortaDeEnvioLabel = new System.Windows.Forms.Label();
            this.ServidorDeEnvioLabel = new System.Windows.Forms.Label();
            this.PortaDeEntradaLabel = new System.Windows.Forms.Label();
            this.ServidorEntradaLabel = new System.Windows.Forms.Label();
            this.SenhaLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.entradaServerTextBox = new System.Windows.Forms.TextBox();
            this.entradaPortaTextBox = new System.Windows.Forms.TextBox();
            this.smtpServerTextBox = new System.Windows.Forms.TextBox();
            this.smtpPortaTextBox = new System.Windows.Forms.TextBox();
            this.sslEntradaCheckBox = new System.Windows.Forms.CheckBox();
            this.sslSaidaCheckBox = new System.Windows.Forms.CheckBox();
            this.salvarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelEmailConfigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmailConfigure
            // 
            this.panelEmailConfigure.Controls.Add(this.sslSaidaCheckBox);
            this.panelEmailConfigure.Controls.Add(this.sslEntradaCheckBox);
            this.panelEmailConfigure.Controls.Add(this.smtpPortaTextBox);
            this.panelEmailConfigure.Controls.Add(this.entradaPortaTextBox);
            this.panelEmailConfigure.Controls.Add(this.smtpServerTextBox);
            this.panelEmailConfigure.Controls.Add(this.entradaServerTextBox);
            this.panelEmailConfigure.Controls.Add(this.senhaTextBox);
            this.panelEmailConfigure.Controls.Add(this.emailTextBox);
            this.panelEmailConfigure.Controls.Add(this.PortaDeEnvioLabel);
            this.panelEmailConfigure.Controls.Add(this.ServidorDeEnvioLabel);
            this.panelEmailConfigure.Controls.Add(this.PortaDeEntradaLabel);
            this.panelEmailConfigure.Controls.Add(this.ServidorEntradaLabel);
            this.panelEmailConfigure.Controls.Add(this.SenhaLabel);
            this.panelEmailConfigure.Controls.Add(this.EmailLabel);
            this.panelEmailConfigure.Location = new System.Drawing.Point(12, 12);
            this.panelEmailConfigure.Name = "panelEmailConfigure";
            this.panelEmailConfigure.Size = new System.Drawing.Size(479, 233);
            this.panelEmailConfigure.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.emailTextBox.Location = new System.Drawing.Point(65, 19);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(219, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // PortaDeEnvioLabel
            // 
            this.PortaDeEnvioLabel.AutoSize = true;
            this.PortaDeEnvioLabel.Location = new System.Drawing.Point(44, 182);
            this.PortaDeEnvioLabel.Name = "PortaDeEnvioLabel";
            this.PortaDeEnvioLabel.Size = new System.Drawing.Size(80, 13);
            this.PortaDeEnvioLabel.TabIndex = 0;
            this.PortaDeEnvioLabel.Text = "Porta de Envio:";
            // 
            // ServidorDeEnvioLabel
            // 
            this.ServidorDeEnvioLabel.AutoSize = true;
            this.ServidorDeEnvioLabel.Location = new System.Drawing.Point(30, 150);
            this.ServidorDeEnvioLabel.Name = "ServidorDeEnvioLabel";
            this.ServidorDeEnvioLabel.Size = new System.Drawing.Size(94, 13);
            this.ServidorDeEnvioLabel.TabIndex = 0;
            this.ServidorDeEnvioLabel.Text = "Servidor de Envio:";
            // 
            // PortaDeEntradaLabel
            // 
            this.PortaDeEntradaLabel.AutoSize = true;
            this.PortaDeEntradaLabel.Location = new System.Drawing.Point(34, 118);
            this.PortaDeEntradaLabel.Name = "PortaDeEntradaLabel";
            this.PortaDeEntradaLabel.Size = new System.Drawing.Size(90, 13);
            this.PortaDeEntradaLabel.TabIndex = 0;
            this.PortaDeEntradaLabel.Text = "Porta de Entrada:";
            // 
            // ServidorEntradaLabel
            // 
            this.ServidorEntradaLabel.AutoSize = true;
            this.ServidorEntradaLabel.Location = new System.Drawing.Point(20, 86);
            this.ServidorEntradaLabel.Name = "ServidorEntradaLabel";
            this.ServidorEntradaLabel.Size = new System.Drawing.Size(104, 13);
            this.ServidorEntradaLabel.TabIndex = 0;
            this.ServidorEntradaLabel.Text = "Servidor de Entrada:";
            // 
            // SenhaLabel
            // 
            this.SenhaLabel.AutoSize = true;
            this.SenhaLabel.Location = new System.Drawing.Point(20, 54);
            this.SenhaLabel.Name = "SenhaLabel";
            this.SenhaLabel.Size = new System.Drawing.Size(41, 13);
            this.SenhaLabel.TabIndex = 0;
            this.SenhaLabel.Text = "Senha:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(20, 22);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(39, 13);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "E-Mail:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(65, 51);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(132, 20);
            this.senhaTextBox.TabIndex = 1;
            // 
            // entradaServerTextBox
            // 
            this.entradaServerTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.entradaServerTextBox.Location = new System.Drawing.Point(130, 83);
            this.entradaServerTextBox.Name = "entradaServerTextBox";
            this.entradaServerTextBox.Size = new System.Drawing.Size(132, 20);
            this.entradaServerTextBox.TabIndex = 1;
            // 
            // entradaPortaTextBox
            // 
            this.entradaPortaTextBox.Location = new System.Drawing.Point(130, 115);
            this.entradaPortaTextBox.Name = "entradaPortaTextBox";
            this.entradaPortaTextBox.Size = new System.Drawing.Size(62, 20);
            this.entradaPortaTextBox.TabIndex = 1;
            // 
            // smtpServerTextBox
            // 
            this.smtpServerTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.smtpServerTextBox.Location = new System.Drawing.Point(130, 147);
            this.smtpServerTextBox.Name = "smtpServerTextBox";
            this.smtpServerTextBox.Size = new System.Drawing.Size(132, 20);
            this.smtpServerTextBox.TabIndex = 1;
            // 
            // smtpPortaTextBox
            // 
            this.smtpPortaTextBox.Location = new System.Drawing.Point(130, 179);
            this.smtpPortaTextBox.Name = "smtpPortaTextBox";
            this.smtpPortaTextBox.Size = new System.Drawing.Size(62, 20);
            this.smtpPortaTextBox.TabIndex = 1;
            // 
            // sslEntradaCheckBox
            // 
            this.sslEntradaCheckBox.AutoSize = true;
            this.sslEntradaCheckBox.Location = new System.Drawing.Point(204, 117);
            this.sslEntradaCheckBox.Name = "sslEntradaCheckBox";
            this.sslEntradaCheckBox.Size = new System.Drawing.Size(46, 17);
            this.sslEntradaCheckBox.TabIndex = 2;
            this.sslEntradaCheckBox.Text = "SSL";
            this.sslEntradaCheckBox.UseVisualStyleBackColor = true;
            // 
            // sslSaidaCheckBox
            // 
            this.sslSaidaCheckBox.AutoSize = true;
            this.sslSaidaCheckBox.Location = new System.Drawing.Point(204, 181);
            this.sslSaidaCheckBox.Name = "sslSaidaCheckBox";
            this.sslSaidaCheckBox.Size = new System.Drawing.Size(46, 17);
            this.sslSaidaCheckBox.TabIndex = 2;
            this.sslSaidaCheckBox.Text = "SSL";
            this.sslSaidaCheckBox.UseVisualStyleBackColor = true;
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(317, 252);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 1;
            this.salvarButton.Text = "&Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sai&r";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EmailConfigureGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.panelEmailConfigure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailConfigureGUI";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de E-Mail";
            this.panelEmailConfigure.ResumeLayout(false);
            this.panelEmailConfigure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmailConfigure;
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
        private System.Windows.Forms.Button button1;
    }
}