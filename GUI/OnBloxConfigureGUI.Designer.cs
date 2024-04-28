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
            this.integraClienteCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.assuntoEmailClienteTextBox = new System.Windows.Forms.TextBox();
            this.bateladaGroupBox = new System.Windows.Forms.GroupBox();
            this.localArquivoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.integraBateladaCheckBox = new System.Windows.Forms.CheckBox();
            this.localArquivoButton = new System.Windows.Forms.Button();
            this.localArquivoBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.clientesGroupBox.SuspendLayout();
            this.bateladaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientesGroupBox
            // 
            this.clientesGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.clientesGroupBox.Controls.Add(this.assuntoEmailClienteTextBox);
            this.clientesGroupBox.Controls.Add(this.label1);
            this.clientesGroupBox.Controls.Add(this.integraClienteCheckBox);
            this.clientesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.clientesGroupBox.Name = "clientesGroupBox";
            this.clientesGroupBox.Size = new System.Drawing.Size(496, 93);
            this.clientesGroupBox.TabIndex = 0;
            this.clientesGroupBox.TabStop = false;
            this.clientesGroupBox.Text = "Clientes";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assunto do E-Mail:";
            // 
            // assuntoEmailClienteTextBox
            // 
            this.assuntoEmailClienteTextBox.Location = new System.Drawing.Point(118, 40);
            this.assuntoEmailClienteTextBox.Name = "assuntoEmailClienteTextBox";
            this.assuntoEmailClienteTextBox.Size = new System.Drawing.Size(357, 20);
            this.assuntoEmailClienteTextBox.TabIndex = 2;
            // 
            // bateladaGroupBox
            // 
            this.bateladaGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.bateladaGroupBox.Controls.Add(this.localArquivoButton);
            this.bateladaGroupBox.Controls.Add(this.localArquivoTextBox);
            this.bateladaGroupBox.Controls.Add(this.label2);
            this.bateladaGroupBox.Controls.Add(this.integraBateladaCheckBox);
            this.bateladaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bateladaGroupBox.Location = new System.Drawing.Point(12, 127);
            this.bateladaGroupBox.Name = "bateladaGroupBox";
            this.bateladaGroupBox.Size = new System.Drawing.Size(496, 93);
            this.bateladaGroupBox.TabIndex = 0;
            this.bateladaGroupBox.TabStop = false;
            this.bateladaGroupBox.Text = "Batelada";
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
            // OnBloxConfigureGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 293);
            this.Controls.Add(this.bateladaGroupBox);
            this.Controls.Add(this.clientesGroupBox);
            this.Name = "OnBloxConfigureGUI";
            this.Text = "Configuração para Integração do OnBlox";
            this.clientesGroupBox.ResumeLayout(false);
            this.clientesGroupBox.PerformLayout();
            this.bateladaGroupBox.ResumeLayout(false);
            this.bateladaGroupBox.PerformLayout();
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
    }
}