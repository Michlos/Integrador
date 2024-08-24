namespace Integrador.GUI
{
    partial class ConfigSysGUI
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
            this.modoExecucaoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modoExecucaoComboBox
            // 
            this.modoExecucaoComboBox.FormattingEnabled = true;
            this.modoExecucaoComboBox.Location = new System.Drawing.Point(135, 26);
            this.modoExecucaoComboBox.Name = "modoExecucaoComboBox";
            this.modoExecucaoComboBox.Size = new System.Drawing.Size(121, 21);
            this.modoExecucaoComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modo de Execução:";
            // 
            // ConfigSysGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modoExecucaoComboBox);
            this.Name = "ConfigSysGUI";
            this.Text = "Configuração do Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox modoExecucaoComboBox;
        private System.Windows.Forms.Label label1;
    }
}