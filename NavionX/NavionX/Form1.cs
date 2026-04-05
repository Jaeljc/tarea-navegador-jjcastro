using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavionX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Forzar el orden de los views para asegurar que el panel de la interfaz esté siempre encima del navegador
            panelHeader.SendToBack();
            webViewBrowser.BringToFront(); 

            // Aseguramos una altura fija 
            panelHeader.Height = 60;
            panelHeader.Dock = DockStyle.Top;

            // el contenedor del navegador ocupe el resto
            webViewBrowser.Dock = DockStyle.Fill;

            try
            {
                // Inicializa WebView de la interfaz
                await webViewUI.EnsureCoreWebView2Async(null);
                string rutaHTML = Path.Combine(Application.StartupPath, "UI", "index.html");
                if (File.Exists(rutaHTML))
                {
                    webViewUI.CoreWebView2.Navigate("file:///" + rutaHTML);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la interfaz: " + ex.Message);
            }

            // Inicializa el navegador principal
            await webViewBrowser.EnsureCoreWebView2Async(null);
            webViewBrowser.CoreWebView2.Navigate("https://www.google.com");
            webViewUI.WebMessageReceived += Interfaz_WebMessageReceived;

            // html sabe cuando cambia la url 
            webViewBrowser.SourceChanged += (s, a) => {
                webViewUI.CoreWebView2.PostWebMessageAsString(webViewBrowser.Source.ToString());
            };
        }

        private void Interfaz_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            // Capturamos el mensaje que viene desde el HTML
            string mensaje = e.TryGetWebMessageAsString();

            // Comprobamos que orden mando el HTML
            if (mensaje == "back")
            {
                if (webViewBrowser.CoreWebView2.CanGoBack) webViewBrowser.CoreWebView2.GoBack();
            }
            else if (mensaje == "forward")
            {
                if (webViewBrowser.CoreWebView2.CanGoForward) webViewBrowser.CoreWebView2.GoForward();
            }
            else if (mensaje == "reload")
            {
                webViewBrowser.CoreWebView2.Reload();
            }
            else
            {
                string url = mensaje;
                if (!url.StartsWith("http"))
                {
                    url = "https://www.google.com/search?q=" + url;
                }
                webViewBrowser.CoreWebView2.Navigate(url);
            }
        }

        private void webViewUI_Click(object sender, EventArgs e)
        {

        }
    }
}
