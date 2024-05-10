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
            this.clientContenPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientListPanel
            // 
            this.clientListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientListPanel.Controls.Add(this.dataGridView1);
            this.clientListPanel.Location = new System.Drawing.Point(12, 12);
            this.clientListPanel.Name = "clientListPanel";
            this.clientListPanel.Size = new System.Drawing.Size(303, 426);
            this.clientListPanel.TabIndex = 0;
            // 
            // clientContenPanel
            // 
            this.clientContenPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientContenPanel.Location = new System.Drawing.Point(321, 12);
            this.clientContenPanel.Name = "clientContenPanel";
            this.clientContenPanel.Size = new System.Drawing.Size(541, 426);
            this.clientContenPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(303, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClientesListGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.clientContenPanel);
            this.Controls.Add(this.clientListPanel);
            this.Name = "ClientesListGUI";
            this.Text = "ClientesListGUI";
            this.Load += new System.EventHandler(this.ClientesListGUI_Load);
            this.clientListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clientListPanel;
        private System.Windows.Forms.Panel clientContenPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}