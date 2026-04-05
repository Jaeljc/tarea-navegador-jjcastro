using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorJael
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoBack)
            {
                webView21.GoBack();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // Motor de búsqueda - Inicialización segura
            if (webView21 != null && webView21.CoreWebView2 == null)
            {
                await webView21.EnsureCoreWebView2Async(null);
            }

            string input = txtUrl.Text.Trim();
            string targetUrl = "";

            // Heurística de Detección de Intención
            if (!input.Contains("."))
            {
                // Si no tiene punto (ej: "itla"), buscamos en Google
                targetUrl = "https://www.google.com/search?q=" + Uri.EscapeDataString(input);
            }
            else
            {
                // Si tiene punto (ej: "google.com"), es una URL
                targetUrl = input;
                if (!targetUrl.StartsWith("http"))
                {
                    targetUrl = "https://" + targetUrl;
                }
            }

            try
            {
                webView21.CoreWebView2.Navigate(targetUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al navegar: " + ex.Message);
            }
        }

        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            // Actualiza la barra con la URL
            txtUrl.Text = webView21.Source.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            // Heurística #7: Eficiencia de uso
            if (e.KeyCode == Keys.Enter)
            {
                // Llamamos al evento de tu botón de navegar (el que tiene el código de ir)
                button2_Click(sender, e);

                // Evita el sonido de error de Windows al presionar Enter
                e.SuppressKeyPress = true;
            }

            // Heurística #3: Libertad del usuario
            if (e.KeyCode == Keys.Escape)
            {
                txtUrl.Clear();
                // Opcional: devuelve el foco al webview para que el usuario siga navegando
                webView21.Focus();
            }
        }

        private async void buttonHome_Click(object sender, EventArgs e)
        {

            // Validación para evitar el error de la línea roja
            if (webView21 != null && webView21.CoreWebView2 == null)
            {
                await webView21.EnsureCoreWebView2Async(null);
            }

            webView21.CoreWebView2.Navigate("https://www.google.com");
        }
    }
}
