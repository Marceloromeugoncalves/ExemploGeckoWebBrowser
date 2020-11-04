using Gecko;
using System.Windows.Forms;

namespace GeckoExample
{
    public partial class FormBrowser : Form
    {
        public FormBrowser()
        {
            InitializeComponent();

            //Inicializando as dll's da pasta Firefox.
            Xpcom.Initialize("Firefox");

            //Navegação inicial.
            geckoWebBrowser.Navigate("https://www.google.com.br");
        }

        private void textBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //Navegar para a URL.
                geckoWebBrowser.Navigate(textBoxUrl.Text);
            }
        }

        private void buttonVoltar_Click(object sender, System.EventArgs e)
        {
            if (geckoWebBrowser.CanGoBack)
            {
                //Voltar uma página.
                geckoWebBrowser.GoBack();
            }
        }

        private void buttonAvancar_Click(object sender, System.EventArgs e)
        {
            if(geckoWebBrowser.CanGoForward)
            {
                //Avançar uma página.
                geckoWebBrowser.GoForward();
            }
        }

        private void buttonRecarregar_Click(object sender, System.EventArgs e)
        {
            //Recarregar a página.
            geckoWebBrowser.Reload();
        }

        private void buttonHome_Click(object sender, System.EventArgs e)
        {
            //Voltar para a página Home.
            geckoWebBrowser.Navigate("https://www.google.com.br");
        }

        private void geckoWebBrowser_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            //Define a URL no campo após o carregamento do documento.
            textBoxUrl.Text = geckoWebBrowser.Url.ToString();
        }
    }
}
