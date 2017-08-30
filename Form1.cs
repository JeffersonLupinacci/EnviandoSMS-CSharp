using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumindo_WebService_SMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnAdicionarDestinatarios_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mskDestinatario.Text))
                lstDestinatarios.Items.Add(mskDestinatario.Text.Replace("(","").Replace(")","").Replace("-","").Replace(" ", ""));
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            btnEnviar.Enabled = false;

            // Lista de Destinatários
            List<ServiceSMS.Destination> Destinatarios = new List<ServiceSMS.Destination>();

            // Carregando os Destinatarios do List View
            foreach (String numeroDestinatario in lstDestinatarios.Items)
                Destinatarios.Add(new ServiceSMS.Destination() { Number = numeroDestinatario });

            // Montando os Parametros
            ServiceSMS.rSMS Parametros = new ServiceSMS.rSMS();
            Parametros.Destinations = Destinatarios.ToArray();

            // Determinando a Mensagem a ser encaminhada
            Parametros.Msg = edMensagem.ToString();

            // Objeto de Comunicação com o WebService
            ServiceSMS.ServiceSMSSoapClient Client = new ServiceSMS.ServiceSMSSoapClient();

            // Acionando o Recurso no WebService
            edRetornos.Text = Client.SendSMS(edUsuario.Text, edSenha.Text, Parametros);

            btnEnviar.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            edUsuario.Text = "Nome de Usuário";
            edSenha.Text = "Senha de Acesso";
            edMensagem.Text = "Mensagem SMS";
            mskDestinatario.Text = "";
            lstDestinatarios.Items.Clear();
            lstDestinatarios.Items.Add("27981863223");
            edRetornos.Text = "";

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            btnLimpar.PerformClick();
        }
              
    }
}
