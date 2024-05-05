namespace Integrador.GUI
{
    partial class MailViewGUI
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
            this.listMailPanel = new System.Windows.Forms.Panel();
            this.listaEmailDataGridView = new System.Windows.Forms.DataGridView();
            this.sairButton = new System.Windows.Forms.Button();
            this.corpoEmailPanel = new System.Windows.Forms.Panel();
            this.corpoEmailTextBox = new System.Windows.Forms.TextBox();
            this.receberEmailsButton = new System.Windows.Forms.Button();
            this.salvarClienteButton = new System.Windows.Forms.Button();
            this.listMailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmailDataGridView)).BeginInit();
            this.corpoEmailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listMailPanel
            // 
            this.listMailPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMailPanel.Controls.Add(this.listaEmailDataGridView);
            this.listMailPanel.Location = new System.Drawing.Point(12, 13);
            this.listMailPanel.Name = "listMailPanel";
            this.listMailPanel.Size = new System.Drawing.Size(776, 187);
            this.listMailPanel.TabIndex = 0;
            // 
            // listaEmailDataGridView
            // 
            this.listaEmailDataGridView.AllowUserToAddRows = false;
            this.listaEmailDataGridView.AllowUserToDeleteRows = false;
            this.listaEmailDataGridView.AllowUserToOrderColumns = true;
            this.listaEmailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaEmailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaEmailDataGridView.Location = new System.Drawing.Point(0, 0);
            this.listaEmailDataGridView.Name = "listaEmailDataGridView";
            this.listaEmailDataGridView.ReadOnly = true;
            this.listaEmailDataGridView.RowHeadersVisible = false;
            this.listaEmailDataGridView.RowHeadersWidth = 100;
            this.listaEmailDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listaEmailDataGridView.Size = new System.Drawing.Size(776, 187);
            this.listaEmailDataGridView.TabIndex = 0;
            // 
            // sairButton
            // 
            this.sairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sairButton.Location = new System.Drawing.Point(713, 415);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 3;
            this.sairButton.Text = "Sai&r";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // corpoEmailPanel
            // 
            this.corpoEmailPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.corpoEmailPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.corpoEmailPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.corpoEmailPanel.Controls.Add(this.corpoEmailTextBox);
            this.corpoEmailPanel.Location = new System.Drawing.Point(15, 206);
            this.corpoEmailPanel.Name = "corpoEmailPanel";
            this.corpoEmailPanel.Size = new System.Drawing.Size(773, 203);
            this.corpoEmailPanel.TabIndex = 4;
            // 
            // corpoEmailTextBox
            // 
            this.corpoEmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.corpoEmailTextBox.Location = new System.Drawing.Point(3, 3);
            this.corpoEmailTextBox.Multiline = true;
            this.corpoEmailTextBox.Name = "corpoEmailTextBox";
            this.corpoEmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.corpoEmailTextBox.Size = new System.Drawing.Size(763, 193);
            this.corpoEmailTextBox.TabIndex = 0;
            // 
            // receberEmailsButton
            // 
            this.receberEmailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.receberEmailsButton.Location = new System.Drawing.Point(15, 415);
            this.receberEmailsButton.Name = "receberEmailsButton";
            this.receberEmailsButton.Size = new System.Drawing.Size(142, 23);
            this.receberEmailsButton.TabIndex = 3;
            this.receberEmailsButton.Text = "&Receber E-Mails";
            this.receberEmailsButton.UseVisualStyleBackColor = true;
            this.receberEmailsButton.Click += new System.EventHandler(this.receberEmailsButton_Click);
            // 
            // salvarClienteButton
            // 
            this.salvarClienteButton.Location = new System.Drawing.Point(174, 415);
            this.salvarClienteButton.Name = "salvarClienteButton";
            this.salvarClienteButton.Size = new System.Drawing.Size(105, 23);
            this.salvarClienteButton.TabIndex = 5;
            this.salvarClienteButton.Text = "Salvar Cliente";
            this.salvarClienteButton.UseVisualStyleBackColor = true;
            this.salvarClienteButton.Click += new System.EventHandler(this.salvarClienteButton_Click);
            // 
            // MailViewGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salvarClienteButton);
            this.Controls.Add(this.corpoEmailPanel);
            this.Controls.Add(this.receberEmailsButton);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.listMailPanel);
            this.Name = "MailViewGUI";
            this.Text = "E-Mail View";
            this.Load += new System.EventHandler(this.MailViewGUI_Load);
            this.listMailPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaEmailDataGridView)).EndInit();
            this.corpoEmailPanel.ResumeLayout(false);
            this.corpoEmailPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listMailPanel;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.DataGridView listaEmailDataGridView;
        private System.Windows.Forms.Panel corpoEmailPanel;
        private System.Windows.Forms.TextBox corpoEmailTextBox;
        private System.Windows.Forms.Button receberEmailsButton;
        private System.Windows.Forms.Button salvarClienteButton;
    }
}