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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listaEmailDataGridView = new System.Windows.Forms.DataGridView();
            this.listMailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEmailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listMailPanel
            // 
            this.listMailPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMailPanel.Controls.Add(this.listaEmailDataGridView);
            this.listMailPanel.Location = new System.Drawing.Point(12, 13);
            this.listMailPanel.Name = "listMailPanel";
            this.listMailPanel.Size = new System.Drawing.Size(776, 393);
            this.listMailPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sai&r";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Abrir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
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
            this.listaEmailDataGridView.Size = new System.Drawing.Size(776, 393);
            this.listaEmailDataGridView.TabIndex = 0;
            // 
            // MailViewGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listMailPanel);
            this.Name = "MailViewGUI";
            this.Text = "E-Mail View";
            this.listMailPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaEmailDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listMailPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView listaEmailDataGridView;
        private System.Windows.Forms.Button button2;
    }
}