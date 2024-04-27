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
            this.integrarCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.assuntoEmailClienteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tagBuscarClientetextBox = new System.Windows.Forms.TextBox();
            this.clientesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientesGroupBox
            // 
            this.clientesGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.clientesGroupBox.Controls.Add(this.tagBuscarClientetextBox);
            this.clientesGroupBox.Controls.Add(this.label2);
            this.clientesGroupBox.Controls.Add(this.assuntoEmailClienteTextBox);
            this.clientesGroupBox.Controls.Add(this.label1);
            this.clientesGroupBox.Controls.Add(this.integrarCheckBox);
            this.clientesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.clientesGroupBox.Name = "clientesGroupBox";
            this.clientesGroupBox.Size = new System.Drawing.Size(496, 138);
            this.clientesGroupBox.TabIndex = 0;
            this.clientesGroupBox.TabStop = false;
            this.clientesGroupBox.Text = "Clientes";
            // 
            // integrarCheckBox
            // 
            this.integrarCheckBox.AutoSize = true;
            this.integrarCheckBox.Location = new System.Drawing.Point(17, 19);
            this.integrarCheckBox.Name = "integrarCheckBox";
            this.integrarCheckBox.Size = new System.Drawing.Size(61, 17);
            this.integrarCheckBox.TabIndex = 0;
            this.integrarCheckBox.Text = "integrar";
            this.integrarCheckBox.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tag a buscar:";
            // 
            // tagBuscarClientetextBox
            // 
            this.tagBuscarClientetextBox.Location = new System.Drawing.Point(118, 76);
            this.tagBuscarClientetextBox.Name = "tagBuscarClientetextBox";
            this.tagBuscarClientetextBox.Size = new System.Drawing.Size(357, 20);
            this.tagBuscarClientetextBox.TabIndex = 2;
            // 
            // OnBloxConfigureGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientesGroupBox);
            this.Name = "OnBloxConfigureGUI";
            this.Text = "Configuração para Integração do OnBlox";
            this.clientesGroupBox.ResumeLayout(false);
            this.clientesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox clientesGroupBox;
        private System.Windows.Forms.TextBox assuntoEmailClienteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox integrarCheckBox;
        private System.Windows.Forms.TextBox tagBuscarClientetextBox;
        private System.Windows.Forms.Label label2;
    }
}