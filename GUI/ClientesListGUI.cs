using Integrador.Domain.Cliente;

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
    public partial class ClientesListGUI : Form
    {
        private List<ClienteModel> clienteModelList = null;
        public ClientesListGUI()
        {
            InitializeComponent();
        }

        private void ClientesListGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void LerDadosClientesParaDataGridView(ClienteModel clienteModel)
        {
            
        }
    }
}
