namespace Integrador.GUI
{
    partial class ClientesListGUI
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
            this.clientListPanel = new System.Windows.Forms.Panel();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.IntegraButton = new System.Windows.Forms.Button();
            this.clientListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientListPanel
            // 
            this.clientListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientListPanel.Controls.Add(this.clientesDataGridView);
            this.clientListPanel.Location = new System.Drawing.Point(12, 12);
            this.clientListPanel.Name = "clientListPanel";
            this.clientListPanel.Size = new System.Drawing.Size(425, 381);
            this.clientListPanel.TabIndex = 0;
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AllowUserToAddRows = false;
            this.clientesDataGridView.AllowUserToDeleteRows = false;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.ReadOnly = true;
            this.clientesDataGridView.Size = new System.Drawing.Size(425, 381);
            this.clientesDataGridView.TabIndex = 0;
            this.clientesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesDataGridView_CellClick);
            // 
            // IntegraButton
            // 
            this.IntegraButton.Location = new System.Drawing.Point(362, 415);
            this.IntegraButton.Name = "IntegraButton";
            this.IntegraButton.Size = new System.Drawing.Size(75, 23);
            this.IntegraButton.TabIndex = 1;
            this.IntegraButton.Text = "Integra";
            this.IntegraButton.UseVisualStyleBackColor = true;
            this.IntegraButton.Click += new System.EventHandler(this.IntegraButton_Click);
            // 
            // ClientesListGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.IntegraButton);
            this.Controls.Add(this.clientListPanel);
            this.Name = "ClientesListGUI";
            this.Text = "ClientesListGUI";
            this.Load += new System.EventHandler(this.ClientesListGUI_Load);
            this.clientListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clientListPanel;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.Button IntegraButton;
    }
}