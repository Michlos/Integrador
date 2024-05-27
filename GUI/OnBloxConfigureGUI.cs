using Integrador.Domain.OnBloxConfigure;
using Integrador.Repository.OnBloxConfigure;
using Integrador.Services;
using Integrador.Services.OnBloxConfigure;

using System;
using System.Windows.Forms;

namespace Integrador.GUI
{
    public partial class OnBloxConfigureGUI : Form
    {
        private OnBloxConfigureModel _onBloxConfigureModel;
        private OnBloxService _onBloxService;
        public OnBloxConfigureGUI()
        {
            InitializeComponent();
            _onBloxService = new OnBloxService(new OnBloxConfigureRepository(new AppDbContext()));
        }

        private void OnBloxConfigureGUI_Load(object sender, EventArgs e)
        {

            PreencheCampos();
        }
        private void salvarButton_Click(object sender, EventArgs e)
        {
            OnBloxConfigureModel model = new OnBloxConfigureModel();
            if (idTextBox.Text == "")
            {
                model = AddOnBloxConfigure();
                this.idTextBox.Text = model.Id.ToString();
            }
            else
            {
                UpdateOnBloxConfigure();
            }


        }
        private OnBloxConfigureModel AddOnBloxConfigure()
        {
            OnBloxConfigureModel returnModel = new OnBloxConfigureModel();

            OnBloxConfigureModel model = new OnBloxConfigureModel()
            {
                Usuario = usuarioTextBox.Text,
                Senha = senhaTextBox.Text,
                ClienteIntegra = integraClienteCheckBox.Checked,
                ClienteAssuntoEmail = assuntoEmailClienteTextBox.Text,
                ClienteURIPost = uriPostTextBox.Text,
                BateladaIntegra = integraBateladaCheckBox.Checked,
                BateladaLocalArquivo = localArquivoTextBox.Text,
                HoraExecucao = TimeSpan.Parse(horaExecuçãoMaskedTextBox.Text),
                ClienteUlimoIdIntegrado = long.Parse(ultimoIdIntegradoTextBox.Text)
            };

            try
            {
                returnModel = _onBloxService.Add(model);
                MessageBox.Show("Configuraçao da OnBlox salva com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possível adicionar dados da Configurção da Integração OnBlox. MessageError: {e.Message}", e.InnerException);
            }
            return returnModel;



        }

        private void UpdateOnBloxConfigure()
        {
            //_onBloxConfigureModel.Id = int.Parse(idTextBox.Text);
            _onBloxConfigureModel.Usuario = usuarioTextBox.Text;
            _onBloxConfigureModel.Senha = senhaTextBox.Text;
            _onBloxConfigureModel.ClienteIntegra = integraClienteCheckBox.Checked;
            _onBloxConfigureModel.ClienteAssuntoEmail = assuntoEmailClienteTextBox.Text;
            _onBloxConfigureModel.ClienteURIPost = uriPostTextBox.Text;
            _onBloxConfigureModel.BateladaIntegra = integraBateladaCheckBox.Checked;
            _onBloxConfigureModel.BateladaLocalArquivo = localArquivoTextBox.Text;
            _onBloxConfigureModel.HoraExecucao = TimeSpan.Parse(horaExecuçãoMaskedTextBox.Text);
            _onBloxConfigureModel.ClienteUlimoIdIntegrado = long.Parse(ultimoIdIntegradoTextBox.Text);


            try
            {
                _onBloxService.Update(_onBloxConfigureModel);
                MessageBox.Show("Configuraçao da OnBlox atualizada com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possível atualizar dados da Configurção da Integração OnBlox. MessageError: {e.Message}", e.InnerException);
            }
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





        private void PreencheCampos()
        {
            _onBloxConfigureModel = new OnBloxConfigureModel();
            if (idTextBox.Text == "")
            {
                try
                {
                    _onBloxConfigureModel = _onBloxService.GetOnBloxConfigure();
                }
                catch (Exception e)
                {

                    throw new Exception($"Falha ao tentar recuperar os dados de configuração do OnBlox \nErrorMessage: {e.Message}", e.InnerException);
                }
            }

            if (_onBloxConfigureModel != null)
            {
                idTextBox.Text = _onBloxConfigureModel.Id.ToString();
                usuarioTextBox.Text = _onBloxConfigureModel.Usuario;
                senhaTextBox.Text = _onBloxConfigureModel.Senha;
                integraClienteCheckBox.Checked = _onBloxConfigureModel.ClienteIntegra;
                assuntoEmailClienteTextBox.Text = _onBloxConfigureModel.ClienteAssuntoEmail;
                uriPostTextBox.Text = _onBloxConfigureModel.ClienteURIPost;
                integraBateladaCheckBox.Checked = _onBloxConfigureModel.BateladaIntegra;
                localArquivoTextBox.Text = _onBloxConfigureModel.BateladaLocalArquivo;
                horaExecuçãoMaskedTextBox.Text = _onBloxConfigureModel.HoraExecucao.ToString();
                ultimoIdIntegradoTextBox.Text = _onBloxConfigureModel.ClienteUlimoIdIntegrado.ToString();
            }

        }
    }
}
