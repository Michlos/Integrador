using Integrador.Domain.Cliente;
using Integrador.Repository.Cliente;
using Integrador.Services;
using Integrador.Services.Cliente;
using Integrador.WebService;

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
        private List<ClienteModel> clienteModelList;
        private ClienteService _clienteService;
        private IEnumerable<ClienteModel> clienteListDGVEnum;
        int indexOfDGV = 0;
        public ClientesListGUI()
        {
            InitializeComponent();
            _clienteService = new ClienteService(new ClienteRepository(new AppDbContext()));
        }

        private void ClientesListGUI_Load(object sender, EventArgs e)
        {
            LerDadosClientesParaDataGridView();
            LoadClientes2DataGrid();
        }

        private void LoadClientes2DataGrid()
        {
            clienteListDGVEnum = clienteModelList;

            

            DataTable tableClientes = ModelaTable();
            ModelaRowTable(tableClientes, clienteListDGVEnum);
            clientesDataGridView.DataSource = tableClientes;
            ConfiguraDataGrid();
        }

        private void ModelaRowTable(DataTable tableClientes, IEnumerable<ClienteModel> clienteListDGV)
        {
            DataRow row;
            if (clienteListDGV.Any())
            {
                foreach (var model in clienteListDGV)
                {
                    bool integrado;
                    row = tableClientes.NewRow();
                    row["ClienteId"] = int.Parse(model.Id.ToString());
                    row["Codigo"] = model.codigo;
                    bool.TryParse(model.integrado.ToString(), out integrado);
                    row["Integrado"] = integrado;

                    tableClientes.Rows.Add(row);
                }
            }
        }

        private void ConfiguraDataGrid()
        {
            clientesDataGridView.Columns[0].HeaderText = "Id";
            clientesDataGridView.Columns[0].Width = 50;

            clientesDataGridView.Columns[1].HeaderText = "Codigo";
            clientesDataGridView.Columns[1].Width = 100;

            clientesDataGridView.Columns[2].HeaderText = "Integrado";
            clientesDataGridView.Columns[2].Width = 50;

        }

        private DataTable ModelaTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ClienteId", typeof(int));
            table.Columns.Add("Codigo", typeof(string));
            table.Columns.Add("Integrado", typeof(bool));

            return table;
        }

        private IEnumerable<ClienteModel> ConfiguraDGV(IEnumerable<ClienteModel> clienteListDGV)
        {
            throw new NotImplementedException();
        }

        private void LerDadosClientesParaDataGridView()
        {
            clienteModelList = new List<ClienteModel>();
            clienteModelList = (List<ClienteModel>)_clienteService.GetAll();
        }

        private void clientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clientesDataGridView.CurrentRow != null)
            {
                indexOfDGV = clientesDataGridView.CurrentRow.Index;
            }
        }

        private void IntegraButton_Click(object sender, EventArgs e)
        {
            JsonService json = new JsonService();
            ClienteModel clienteModel = new ClienteModel();
            clienteModel = _clienteService.GetById(int.Parse(clientesDataGridView.CurrentRow.Cells[0].Value.ToString()));
            if (clienteModel != null)
            {
                json.SendData(clienteModel);
                
            }

        }
    }
}
