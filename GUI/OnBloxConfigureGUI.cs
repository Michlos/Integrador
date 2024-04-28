using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador.GUI
{
    public partial class OnBloxConfigureGUI : Form
    {
        public OnBloxConfigureGUI()
        {
            InitializeComponent();
        }

        private void localArquivoButton_Click(object sender, EventArgs e)
        {

            
            using (FolderBrowserDialog localArquivoBrowserDialog = new FolderBrowserDialog())
            {
                localArquivoBrowserDialog.Description = "Selecione uma pasta.";
                localArquivoBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

                DialogResult result = localArquivoBrowserDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(localArquivoBrowserDialog.SelectedPath))
                {
                    localArquivoTextBox.Text = localArquivoBrowserDialog.SelectedPath;
                }
            }
        }
    }
}
