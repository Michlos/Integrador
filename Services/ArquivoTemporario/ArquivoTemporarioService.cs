using Integrador.Domain.Email;
using Integrador.Domain.EmailConfigure;
using Integrador.Repository.EmailConfigure;
using Integrador.Services.EmailConfigure;

using System;
using System.IO;

namespace Integrador.Services.ArquivoTemporario
{
    public class Indice
    {
        public int inicio;
        public int fim;
    }
    public class ArquivoTemporarioService
    {
        private EmailModel _emailModel = new EmailModel();
        private EmailConfigureService _emailConfigureService;
        private readonly EmailConfigureModel _emailConfigureModel;

        public ArquivoTemporarioService(EmailModel emailModel)
        {
            _emailModel = emailModel;
            _emailConfigureService = new EmailConfigureService(new EmailConfigureRepository(new AppDbContext()));
            _emailConfigureModel = _emailConfigureService.GetEmailConfigure();
        }

        public String[] RetornaLInhas(EmailConfigureService emailConfigService)
        {
            //_emailConfigureService = new EmailConfigureService(new EmailConfigureRepository(new AppDbContext()));
            //CRIA ARQUIVO PARA RECEBER O CORPO DO E-MAIL
            string caminhoDoArquivo = emailConfigService.GetEmailConfigure().PastaTemporaria;

            //CRIA O ARQUIVO TEMPORÁRIO
            StreamWriter sw = new StreamWriter($@"{caminhoDoArquivo}\Temp.txt");

            //SALVA O CORPO DO E-MAIL NO ARQUIVO CRIADO
            sw.WriteLine(_emailModel.ConteudoHtml);

            //FECHA O ARQUIVO
            sw.Close();

            //SALVA DADOS DO ARQUIVO NO ARRAY DE RETORNO
            string[] lines = File.ReadAllLines($@"{caminhoDoArquivo}\Temp.txt");

            return lines;
        }

        public Indice GetIndice(string[] lines)
        {
            Indice indices = new Indice();
            indices.inicio = 0;
            indices.fim = 0;

            int linha = 0;
            string textoInicioRelatorio = _emailConfigureService.GetEmailConfigure().InicioRelatorio;
            string textoFinalRelatorio = _emailConfigureService.GetEmailConfigure().FinalRelatorio;

            while (indices.fim == 0 || indices.inicio == 0)
            {
                if (lines[linha].Contains(textoInicioRelatorio))
                {
                    indices.inicio = linha +2;
                }

                if (lines[linha].Contains(textoFinalRelatorio))
                {
                    indices.fim = linha;
                }
                linha++;
            }
            return indices;
        }
    }
}
